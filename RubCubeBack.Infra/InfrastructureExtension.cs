using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Sinks.PostgreSQL;
using Microsoft.IdentityModel.Tokens;
using NpgsqlTypes;
using RubCubeBack.Application.Interfaces;
using RubCubeBack.Application.Services;
using RubCubeBack.Domain.Interfaces;
using RubCubeBack.Domain.Repositories;
using RubCubeBack.Infra.Clients;
using RubCubeBack.Infra.Context;
using RubCubeBack.Infra.Middleware;
using RubCubeBack.Infra.Repositories;
using RubCubeBack.Infra.Security;
using RubCubeBack.Infra.Security.Authentication;
using System.Text;
using Microsoft.Extensions.Logging;
using RubCubeBack.Infra.Cache;

namespace RubCubeBack.Infra
{
    public static class InfrastructureExtension
    {
        extension(ConfigureHostBuilder host)
        {
            public ConfigureHostBuilder AddSerilog(IConfiguration configuration, ILoggingBuilder logging)
            {
                var columnWriters = new Dictionary<string, ColumnWriterBase>
{
    { "Id", new SinglePropertyColumnWriter("Id", PropertyWriteMethod.Raw, NpgsqlDbType.Uuid) },
    { "Path", new SinglePropertyColumnWriter("Path", PropertyWriteMethod.Raw, NpgsqlDbType.Text) },
    { "Request", new SinglePropertyColumnWriter("Request", PropertyWriteMethod.Raw, NpgsqlDbType.Jsonb) },
    { "StatusCode", new SinglePropertyColumnWriter("StatusCode", PropertyWriteMethod.Raw, NpgsqlDbType.Integer) },
    { "UserId", new SinglePropertyColumnWriter("UserId", PropertyWriteMethod.Raw, NpgsqlDbType.Uuid) },
    { "Created", new SinglePropertyColumnWriter("Created", PropertyWriteMethod.Raw, NpgsqlDbType.TimestampTz) }
};
                var connectionString = configuration.GetConnectionString("DefaultConnection");

                Log.Logger = new LoggerConfiguration()
                    .Enrich.FromLogContext()
                    .WriteTo.Console(outputTemplate: "{Timestamp:HH:mm:ss} [{Level}] {Message}{NewLine}{Properties}{NewLine}{Exception}")
                    .WriteTo.PostgreSQL(
                        connectionString: connectionString,
                        tableName: "Logs",
                        columnOptions: columnWriters,
                        needAutoCreateTable: false,
                        respectCase: true
                    )
                    .CreateLogger();

                Serilog.Debugging.SelfLog.Enable(msg => Console.WriteLine(msg));
                return host;
            }
        }


        extension(IServiceCollection services)
        {
            public IServiceCollection AddInfrastructure(IConfiguration configuration)
            {
                services.AddDbContext<Context.RubAppDbContext>(options =>
                {
                    var connectionString = configuration.GetConnectionString("DefaultConnection");
                    options.UseNpgsql(connectionString);
                });


                services.AddStackExchangeRedisCache(options =>
                {
                    options.Configuration = configuration.GetConnectionString("Redis");
                    options.InstanceName = "Rubcube";
                });

                services.AddScoped<IUserRepository, UserRepository>();
                services.AddScoped<IUserService, UserService>();
                services.AddScoped<IPasswordHasher, PasswordHasher>();
                services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
                services.AddScoped<IAuthService, AuthService>();
                services.AddScoped<IMetalPriceClientService, MetalPriceClientService>();
                services.AddScoped<ILogRepository, LogRepository>();
                services.AddScoped<ILogService, LogService>();
                services.AddScoped<IMetalPriceSymbolsRepository, MetalPriceSymbolsRepository>();
                services.AddScoped<IRedisCacheService, RedisCacheService>();
                services.AddScoped<ICurrencyService, CurrencyService>();

                return services;
            }

            public IServiceCollection AddSecurity(IConfiguration configuration)
            {

                var key = Encoding.ASCII.GetBytes(configuration["JwtSettings:Secret"]!);

                services.AddAuthentication(x =>
                {
                    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                    .AddJwtBearer(x =>
                    {
                        x.RequireHttpsMetadata = false;
                        x.SaveToken = true;
                        x.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateIssuerSigningKey = true,
                            IssuerSigningKey = new SymmetricSecurityKey(key),
                            ValidateIssuer = false,
                            ValidateAudience = false,
                            ValidateLifetime = true
                        };

                        x.Events = new JwtBearerEvents
                        {
                            OnTokenValidated = async context =>
                            {
                                var userId = context.Principal?.FindFirst("Id")?.Value;

                                var userRepository = context.HttpContext.RequestServices.GetRequiredService<IUserRepository>();

                                if (string.IsNullOrEmpty(userId) || await userRepository.GetByIdAsync(Guid.Parse(userId), context.HttpContext.RequestAborted) is null)
                                {
                                    context.Fail("User not found or account is deleted");
                                }
                            }
                        };
                    });

                services.AddAuthorization();

                return services;
            }
        

        }

        extension (IApplicationBuilder applicationBuilder)
        {
            public IApplicationBuilder RunMigrations()
            {
                using IServiceScope scope = applicationBuilder.ApplicationServices.CreateScope();

                using var context = scope.ServiceProvider.GetRequiredService<RubAppDbContext>();

                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }

                return applicationBuilder;
            }

            public IApplicationBuilder UseRequestLogging()
            {
                return applicationBuilder.UseMiddleware<LogRequestMiddleware>();
            }
        }
        
    }
}
