using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using RubCubeBack.Application.Interfaces;
using RubCubeBack.Application.Services;
using RubCubeBack.Domain.Interfaces;
using RubCubeBack.Domain.Repositories;
using RubCubeBack.Infra.Context;
using RubCubeBack.Infra.Repositories;
using RubCubeBack.Infra.Security;
using RubCubeBack.Infra.Security.Authentication;
using System;
using System.Collections.Generic;
using System.Text;

namespace RubCubeBack.Infra
{
    public static class InfrastructureExtension
    {
        extension(IServiceCollection services)
        {
            public IServiceCollection AddInfrastructure(IConfiguration configuration)
            {
                services.AddDbContext<Context.RubAppDbContext>(options =>
                {
                    var connectionString = configuration.GetConnectionString("DefaultConnection");
                    options.UseNpgsql(connectionString);
                });

                services.AddScoped<IUserRepository, UserRepository>();
                services.AddScoped<IUserService, UserService>();
                services.AddScoped<IPasswordHasher, PasswordHasher>();
                services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
                services.AddScoped<IAuthService, AuthService>();

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
        }
        
    }
}
