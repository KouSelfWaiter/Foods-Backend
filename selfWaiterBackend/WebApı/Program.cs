using Applicaiton;
using Applicaiton.Features.Commands.Products.CreateProduct;
using FluentValidation.AspNetCore;
using Infrastructure;
using Infrastructure.Filters;
using Infrastructure.Services.Storage.GCP;
using Infrastructure.Services.Storage.Local;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.Extensions.Logging;
using Persistence;
using SelfWaiterSignalR;
using Serilog;
using Serilog.Core;
using WebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddPersistenceService(builder.Configuration);
builder.Services.AddApplicationService();
builder.Services.AddInfrastructureService();
builder.Services.AddSignalRService();
//NOT: hangi stroage kullancaksan sececeksin
builder.Services.AddStorage<LocalStorage>();
// builder.Services.AddStorage<GCPStorage>();


//Cors
builder.Services.AddCors(options =>
{
   options.AddPolicy("swFrontPolicy", builder=> {
       builder.WithOrigins("http://localhost:3000", "https://localhost:3000")
      .AllowAnyMethod()
      .AllowAnyHeader()
        .AllowCredentials()
        . SetIsOriginAllowed(origin => true);
   });
});

builder.Services.AddControllers(options => options.Filters.Add<ValidationFilter>())
.AddFluentValidation(configuration => configuration
                .RegisterValidatorsFromAssemblyContaining<CreateProductCommandValidator>())
            .ConfigureApiBehaviorOptions(o => o.SuppressModelStateInvalidFilter = true);


Logger log = new LoggerConfiguration()
    .WriteTo.PostgreSQL(
        builder.Configuration.GetConnectionString("PostgreSQL"),
        "Logs",
        needAutoCreateTable: true)
    .MinimumLevel.Error()
    .CreateLogger();


builder.Host.UseSerilog(log);

builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.All;
    logging.RequestHeaders.Add("sec-ch-ua");
    logging.MediaTypeOptions.AddText("application/javascript");
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;

});

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

app.ConfigureExceptionHandler<Program>(app.Services.GetRequiredService<ILogger<Program>>());

app.UseStaticFiles();


app.UseSerilogRequestLogging();
app.UseHttpLogging();

app.UseCors("swFrontPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHubs();

app.Run();
