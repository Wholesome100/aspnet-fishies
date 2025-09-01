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

app.MapGet("/", () =>
{
    var message = """
    Welcome to aspnet-fishies!
    This is a small project to get familiar with ASP.NET Core, Entity Framework,
    and containerization.

    This project presents a REST API layer, running within a container hosted on
    Google Cloud Run.

    Available Endpoints:
    GET    /fish                  - List all fish
    GET    /fish/{id}             - Get fish by ID
    POST   /fish                  - Add a new fish
    PUT    /fish/{id}             - Update a fish
    DELETE /fish/{id}             - Remove a fish

    Additional Features:
    GET    /fish/search?name=...  - Search fish by name
    GET    /fish/habitat/{type}   - Filter by habitat (Freshwater, Saltwater, Brackish)
    GET    /fish/status/{status}  - Filter by conservation status
    GET    /fish/random           - Get a random fish
    GET    /fish/top-value/{n}    - Top N most valuable fish
    GET    /stats                 - Summary stats

    Example:
    curl https://your-api-url/fish
    """;

    return Results.Text(message, "text/plain");
});

app.MapGet("/fish", async (FishDbContext db) => await db.Fish.ToListAsync());

app.MapGet("/fish/{id:int}", async (int id, FishDbContext db) =>
    await db.Fish.FindAsync(id) is Fish fish ? Results.Ok(fish) : Results.NotFound());

app.MapPost("/fish", async (Fish fish, FishDbContext db) =>
{
    db.Fish.Add(fish);
    await db.SaveChangesAsync();
    return Results.Created($"/fish/{fish.Id}", fish);
});

app.MapPut("/fish/{id:int}", async (int id, Fish updated, FishDbContext db) =>
{
    var fish = await db.Fish.FindAsync(id);
    if (fish is null) return Results.NotFound();

    fish.Name = updated.Name;
    fish.Habitat = updated.Habitat;
    fish.Status = updated.Status;
    fish.MarketValue = updated.MarketValue;

    await db.SaveChangesAsync();
    return Results.Ok(fish);
});

app.MapDelete("/fish/{id:int}", async (int id, FishDbContext db) =>
{
    var fish = await db.Fish.FindAsync(id);
    if (fish is null) return Results.NotFound();

    db.Fish.Remove(fish);
    await db.SaveChangesAsync();
    return Results.NoContent();
});


app.Run();