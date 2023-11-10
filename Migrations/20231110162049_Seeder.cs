using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BettingAPI.Migrations
{
    /// <inheritdoc />
    public partial class Seeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Match",
                columns: new[] { "ID", "Description", "MatchDate", "MatchTime", "Sport", "TeamA", "TeamB" },
                values: new object[,]
                {
                    { new Guid("12f961ed-7e67-4ee1-baae-d3d9fbdc57b0"), "OSFP - PAO", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 11, 10, 18, 20, 49, 715, DateTimeKind.Local).AddTicks(8538), 1, "OSFP", "PAO" },
                    { new Guid("58910587-eeb2-4d3f-8cd1-f57e084c5c93"), "OSFP - PAO", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 11, 10, 18, 20, 49, 715, DateTimeKind.Local).AddTicks(8541), 2, "OSFP", "PAO" },
                    { new Guid("9f901ef4-3878-4b20-8b0a-f3c4717b6524"), "AEK - ARIS", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 11, 10, 18, 20, 49, 715, DateTimeKind.Local).AddTicks(8547), 2, "AEK", "ARIS" }
                });

            migrationBuilder.InsertData(
                table: "MatchOdds",
                columns: new[] { "ID", "MatchID", "Odd", "Specifier" },
                values: new object[,]
                {
                    { new Guid("010c0c20-989f-4047-98e5-aa81670e882c"), new Guid("58910587-eeb2-4d3f-8cd1-f57e084c5c93"), 2.5m, 1 },
                    { new Guid("0aa64f8e-2490-4443-90ab-99a7b67ba57d"), new Guid("58910587-eeb2-4d3f-8cd1-f57e084c5c93"), 11.2m, 3 },
                    { new Guid("135a728a-e39f-4cad-8a1e-7665b944b2ec"), new Guid("9f901ef4-3878-4b20-8b0a-f3c4717b6524"), 10.1m, 2 },
                    { new Guid("683d4cd0-82ae-4cc1-bc23-308cca81c776"), new Guid("9f901ef4-3878-4b20-8b0a-f3c4717b6524"), 14.2m, 3 },
                    { new Guid("749eba9a-b05c-4e39-81bc-b7429cfb035e"), new Guid("12f961ed-7e67-4ee1-baae-d3d9fbdc57b0"), 2.1m, 2 },
                    { new Guid("8193092d-42ff-419f-83e8-d15b187df1ec"), new Guid("58910587-eeb2-4d3f-8cd1-f57e084c5c93"), 4.1m, 2 },
                    { new Guid("8d778844-59dd-4598-a0e7-54344e1d23bb"), new Guid("12f961ed-7e67-4ee1-baae-d3d9fbdc57b0"), 3.2m, 3 },
                    { new Guid("bc5c91b7-f042-4f5e-99d6-e5a5572105e1"), new Guid("12f961ed-7e67-4ee1-baae-d3d9fbdc57b0"), 1.5m, 1 },
                    { new Guid("f212fb32-204f-429a-962a-1c5f9ea4a4db"), new Guid("9f901ef4-3878-4b20-8b0a-f3c4717b6524"), 21.5m, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("010c0c20-989f-4047-98e5-aa81670e882c"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("0aa64f8e-2490-4443-90ab-99a7b67ba57d"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("135a728a-e39f-4cad-8a1e-7665b944b2ec"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("683d4cd0-82ae-4cc1-bc23-308cca81c776"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("749eba9a-b05c-4e39-81bc-b7429cfb035e"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("8193092d-42ff-419f-83e8-d15b187df1ec"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("8d778844-59dd-4598-a0e7-54344e1d23bb"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("bc5c91b7-f042-4f5e-99d6-e5a5572105e1"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("f212fb32-204f-429a-962a-1c5f9ea4a4db"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("12f961ed-7e67-4ee1-baae-d3d9fbdc57b0"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("58910587-eeb2-4d3f-8cd1-f57e084c5c93"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("9f901ef4-3878-4b20-8b0a-f3c4717b6524"));
        }
    }
}
