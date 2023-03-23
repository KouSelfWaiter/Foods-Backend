using Applicaiton;
using Applicaiton.Features.Commands.Products.CreateProduct;
using FluentValidation.AspNetCore;
using Infrastructure;
using Infrastructure.Filters;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddPersistenceService(builder.Configuration);
builder.Services.AddApplicationService();
builder.Services.AddInfrastructureService();

builder.Services.AddControllers(options => options.Filters.Add<ValidationFilter>())
.AddFluentValidation(configuration => configuration
                .RegisterValidatorsFromAssemblyContaining<CreateProductCommandValidator>())
            .ConfigureApiBehaviorOptions(o => o.SuppressModelStateInvalidFilter = true);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
