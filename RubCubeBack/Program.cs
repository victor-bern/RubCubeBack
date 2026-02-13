using Microsoft.OpenApi;
using RubCubeBack.Handlers;
using RubCubeBack.Infra;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddInfrastructure(builder.Configuration);


builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi(options =>
{
    options.AddDocumentTransformer((document, context, cancellationToken) =>
    {
        var scheme = new OpenApiSecurityScheme
        {
            Type = SecuritySchemeType.Http,
            Scheme = "bearer",
            BearerFormat = "JWT"
        };

        document.Components ??= new OpenApiComponents();
        document.Components.SecuritySchemes?.Add("MyBearerAuth", scheme);
        return Task.CompletedTask;
    });
});

builder.Services.AddSecurity(builder.Configuration);
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

var app = builder.Build();

app.UseExceptionHandler();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(opt =>
    {
        opt.ForceDarkMode();
        opt.AddPreferredSecuritySchemes("MyBearerAuth");
    });
}


app.RunMigrations();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
