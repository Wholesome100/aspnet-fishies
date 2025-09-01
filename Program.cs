using aspnet_fishies.Data;  
using aspnet_fishies.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

if (string.IsNullOrWhiteSpace(connectionString))
{
    throw new InvalidOperationException("Database connection string not configured.");
}

builder.Services.AddDbContext<FishDbContext>(options => 
    options.UseNpgsql(connectionString));

var app = builder.Build();

app.MapGet("/", () => "Fishies");

app.MapGet("/fish", async (FishDbContext db) => await db.Fish.ToListAsync());

app.Run();