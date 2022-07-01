using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AddFatsSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SmokePoint",
                table: "Fats",
                newName: "SmokePointFahrenheit");

            migrationBuilder.AddColumn<int>(
                name: "SmokePointCelsius",
                table: "Fats",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Fats",
                columns: new[] { "Id", "DbCreateTimestamp", "DbLastModifiedTimestamp", "Description", "Guid", "Name", "SmokePointCelsius", "SmokePointFahrenheit" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 7, 1, 20, 19, 12, 961, DateTimeKind.Utc).AddTicks(8919), new DateTime(2022, 7, 1, 20, 19, 12, 961, DateTimeKind.Utc).AddTicks(8920), "", new Guid("46f11f51-511a-4bb4-ad49-dbe3436a5102"), "extra virgin olive oil", 0, 375 },
                    { 2L, new DateTime(2022, 7, 1, 20, 19, 12, 961, DateTimeKind.Utc).AddTicks(8927), new DateTime(2022, 7, 1, 20, 19, 12, 961, DateTimeKind.Utc).AddTicks(8928), "", new Guid("470d7ac3-f921-47da-aeab-c544dffd8332"), "butter", 177, 350 },
                    { 3L, new DateTime(2022, 7, 1, 20, 19, 12, 961, DateTimeKind.Utc).AddTicks(8931), new DateTime(2022, 7, 1, 20, 19, 12, 961, DateTimeKind.Utc).AddTicks(8931), null, new Guid("ee867dda-7a2e-4844-8d89-154127b26612"), "clarified butter", 252, 485 },
                    { 4L, new DateTime(2022, 7, 1, 20, 19, 12, 961, DateTimeKind.Utc).AddTicks(8933), new DateTime(2022, 7, 1, 20, 19, 12, 961, DateTimeKind.Utc).AddTicks(8933), null, new Guid("ee867dda-7a2e-4844-8d89-154127b26612"), "canola oil", 204, 400 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fats",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Fats",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Fats",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Fats",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DropColumn(
                name: "SmokePointCelsius",
                table: "Fats");

            migrationBuilder.RenameColumn(
                name: "SmokePointFahrenheit",
                table: "Fats",
                newName: "SmokePoint");
        }
    }
}
