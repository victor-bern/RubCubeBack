using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi;

using RubCubeBack.Handlers;
using RubCubeBack.Infra;
using Scalar.AspNetCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddInfrastructure(builder.Configuration);


builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Rubcube API", Version = "v1" });

    // 1. Definimos COMO a autenticação aparece (A definição)
    var securityDefinition = new OpenApiSecurityScheme
    {
        Name = "Bearer",
        Description = "Coloque apenas o token JWT",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer", // Importante: minúsculo
        BearerFormat = "JWT"
    };

    c.AddSecurityDefinition("Bearer", securityDefinition);
});

builder.Services.AddSecurity(builder.Configuration);
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();
builder.Logging.ClearProviders();
builder.Host.AddSerilog(builder.Configuration, builder.Logging);

var app = builder.Build();
app.UseRequestLogging();

app.UseExceptionHandler();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.RunMigrations();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
