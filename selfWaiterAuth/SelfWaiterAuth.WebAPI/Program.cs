using Core.Security.Configurations;
using Core.Security.Extensions;
using FluentValidation.AspNetCore;
using SelfWaiterAuth.Application;
using SelfWaiterAuth.Infrastructure;
using SelfWaiterAuth.Persistence;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("swFrontPolicy", builder => {
        builder.WithOrigins("http://localhost:3000", "https://localhost:3000")
       .AllowAnyMethod()
       .AllowAnyHeader()
         .AllowCredentials()
         .SetIsOriginAllowed(origin => true);
    });
});


builder.Services.AddControllers().AddFluentValidation(options =>
{
    options.ImplicitlyValidateChildProperties = true;
    options.ImplicitlyValidateRootCollectionElements = true;

    options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
});

builder.Services.AddCustomValidationResponseService();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthPersistenceService(builder.Configuration);
builder.Services.AddAuthInfrastructureService();
builder.Services.AddAuthApplicationService();

builder.Services.Configure<CustomTokenOptions>(builder.Configuration.GetSection("TokenOptions"));

var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<CustomTokenOptions>();

builder.Services.AddCustomTokenAuth(tokenOptions);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("swFrontPolicy");
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
