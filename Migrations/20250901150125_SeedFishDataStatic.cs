using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnet_fishies.Migrations
{
    /// <inheritdoc />
    public partial class SeedFishDataStatic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdated",
                value: new DateTime(2025, 9, 1, 10, 59, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdated",
                value: new DateTime(2025, 9, 1, 10, 59, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdated",
                value: new DateTime(2025, 9, 1, 10, 59, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdated",
                value: new DateTime(2025, 9, 1, 10, 59, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdated",
                value: new DateTime(2025, 9, 1, 10, 59, 0, 0, DateTimeKind.Utc));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdated",
                value: new DateTime(2025, 9, 1, 15, 0, 19, 652, DateTimeKind.Utc).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdated",
                value: new DateTime(2025, 9, 1, 15, 0, 19, 652, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdated",
                value: new DateTime(2025, 9, 1, 15, 0, 19, 652, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdated",
                value: new DateTime(2025, 9, 1, 15, 0, 19, 652, DateTimeKind.Utc).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdated",
                value: new DateTime(2025, 9, 1, 15, 0, 19, 652, DateTimeKind.Utc).AddTicks(5110));
        }
    }
}
