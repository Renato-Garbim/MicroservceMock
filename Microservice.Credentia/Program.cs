using InfraMiggration;
using Microservice.Credentia.API.ProgramConfig;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



// Implementa a Config do Mapper e do IOC que estao na pasta ProgramConfig
builder.Services.StartRegisterServices();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var connection = @"Server=DESKTOP-FSTOFJN;initial catalog=APIMockUp.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";
//var connection = @"Server=localhost;initial catalog=APIMockUp.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";

builder.Services.AddDbContext<MicroserviceCredentiaContext>(options => options.UseSqlServer(connection));

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
