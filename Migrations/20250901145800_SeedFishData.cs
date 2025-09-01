using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace aspnet_fishies.Migrations
{
    /// <inheritdoc />
    public partial class SeedFishData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fish",
                columns: new[] { "Id", "AverageWeightKg", "Description", "Habitat", "ImageUrl", "LastUpdated", "Location", "MarketValue", "Name", "ScientificName", "Seasonality", "Status" },
                values: new object[,]
                {
                    { 1, 4.5m, "A popular fish found in the North Atlantic, valued for its flavor.", "Saltwater", "https://example.com/salmon.jpg", new DateTime(2025, 9, 1, 14, 57, 59, 747, DateTimeKind.Utc).AddTicks(3228), "North Atlantic Ocean", 15.5m, "Atlantic Salmon", "Salmo salar", "Spring-Summer", "LeastConcern" },
                    { 2, 250m, "Highly prized for sushi and sashimi, found in the Atlantic and Pacific.", "Saltwater", "https://example.com/tuna.jpg", new DateTime(2025, 9, 1, 14, 57, 59, 747, DateTimeKind.Utc).AddTicks(3304), "Atlantic & Pacific Oceans", 200.0m, "Bluefin Tuna", "Thunnus thynnus", "Year-round", "Endangered" },
                    { 3, 2.0m, "A freshwater fish known for its vibrant coloration and popularity among anglers.", "Freshwater", "https://example.com/trout.jpg", new DateTime(2025, 9, 1, 14, 57, 59, 747, DateTimeKind.Utc).AddTicks(3306), "North American rivers and lakes", 12.0m, "Rainbow Trout", "Oncorhynchus mykiss", "Spring-Fall", "LeastConcern" },
                    { 4, 1.5m, "A migratory fish with a complex life cycle, currently facing population decline.", "Brackish", "https://example.com/eel.jpg", new DateTime(2025, 9, 1, 14, 57, 59, 747, DateTimeKind.Utc).AddTicks(3308), "European coastal and inland waters", 30.0m, "European Eel", "Anguilla anguilla", "Winter", "CriticallyEndangered" },
                    { 5, 1.2m, "A widely farmed freshwater fish known for its mild flavor and affordability.", "Freshwater", "https://example.com/tilapia.jpg", new DateTime(2025, 9, 1, 14, 57, 59, 747, DateTimeKind.Utc).AddTicks(3310), "Global aquaculture farms", 5.0m, "Tilapia", "Oreochromis niloticus", "Year-round", "LeastConcern" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
