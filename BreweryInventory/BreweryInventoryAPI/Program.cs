using BreweryInventoryEFClasses.Models;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(Options => {
    Options.AddDefaultPolicy(
    builder => {
        builder.AllowAnyOrigin()
        .WithMethods("POST", "PUT", "DELETE", "GET", "OPTIONS")
        .AllowAnyHeader();
    });
});

// Add services to the container.

builder.Services.AddDbContext<BreweryInventoryContext>();
builder.Services.AddControllers();
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

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
