using Filler.API.Models.Sites;
using Filler.API.Repositories;
using Filler.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// using dependency injection for repo
builder.Services.AddScoped<IFuelRepo, FuelRepo>();
// adding db context connection string to come from config 
builder.Services.AddDbContext<FuelSiteContext>(options => options.UseInMemoryDatabase("FuelDb"));




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    builder.Configuration.AddUserSecrets<Program>(optional: true);
}

using (var serviceScope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
{
    serviceScope.ServiceProvider.GetService<FuelSiteContext>().EnsureSeedData();
    
}

// secrets and keys to be stored in and retrieved from Azure Key Vault

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
