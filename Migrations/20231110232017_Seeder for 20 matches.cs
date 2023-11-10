using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BettingAPI.Migrations
{
    /// <inheritdoc />
    public partial class Seederfor20matches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Match",
                columns: new[] { "ID", "Description", "MatchDate", "MatchTime", "Sport", "TeamA", "TeamB" },
                values: new object[,]
                {
                    { new Guid("09d63ecd-9b44-4704-9e30-7e8917f86cd9"), "AEL - OFI", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 13, 20, 0, 0, 0, DateTimeKind.Unspecified), 1, "AEL", "OFI" },
                    { new Guid("0b56834f-f6a8-4f7f-9c06-9ec654c3273b"), "ARIS - AEK", new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 17, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, "ARIS", "AEK" },
                    { new Guid("0e911fa2-0984-480f-aa0c-f4fe5952c288"), "PAO - AEL", new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 7, 19, 30, 0, 0, DateTimeKind.Unspecified), 2, "PAO", "AEL" },
                    { new Guid("11292fdc-469c-4b83-a3a6-89714400648f"), "OFI - PAS", new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 2, "OFI", "PAS" },
                    { new Guid("1c2d829b-574b-4018-a013-2e495961e5af"), "OSFP - PAO", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), 1, "OSFP", "PAO" },
                    { new Guid("2245137d-f773-4e15-beb6-63e33efde74b"), "PAS - IRAKLIS", new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 5, 15, 30, 0, 0, DateTimeKind.Unspecified), 2, "PAS", "IRAKLIS" },
                    { new Guid("388dbe54-27b6-4fdd-8896-eb9481a95ff6"), "PAS - IRAKLIS", new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 14, 15, 30, 0, 0, DateTimeKind.Unspecified), 2, "PAS", "IRAKLIS" },
                    { new Guid("3dc581e4-c4ac-453a-bbdb-96e47ec0f8f5"), "IRAKLIS - ATROMITOS", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, "IRAKLIS", "ATROMITOS" },
                    { new Guid("43b2cbea-f255-48de-bc8b-9f57c69b1a74"), "ATROMITOS - OSFP", new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, "ATROMITOS", "OSFP" },
                    { new Guid("6816f154-9e2a-46f5-93df-58581e1af7e5"), "AEK - ARIS", new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, "AEK", "ARIS" },
                    { new Guid("98eddf51-4fcb-43fb-901d-f377c895615a"), "OSFP - PAO", new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, "OSFP", "PAO" },
                    { new Guid("a1ed0b7f-bd55-47e3-ac8f-a9cfc084f493"), "AEK - ARIS", new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 2, "AEK", "ARIS" },
                    { new Guid("a842f311-5435-4edd-8c92-f19dd4cb3ad3"), "OSFP - PAO", new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, "OSFP", "PAO" },
                    { new Guid("b94fea12-4905-48b4-afdc-cd6ea480b527"), "IRAKLIS - ATROMITOS", new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, "IRAKLIS", "ATROMITOS" },
                    { new Guid("bc17ed3f-f331-4b2d-97d6-54508460e773"), "OFI - PAS", new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), 2, "OFI", "PAS" },
                    { new Guid("d41a1476-7915-4787-96b0-cd1554897e8e"), "OSFP - PAO", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 2, 14, 30, 0, 0, DateTimeKind.Unspecified), 2, "OSFP", "PAO" },
                    { new Guid("e407ae90-843c-4221-8bcc-4e1174f55d7b"), "AEL - OFI", new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 4, 20, 0, 0, 0, DateTimeKind.Unspecified), 1, "AEL", "OFI" },
                    { new Guid("efb755a6-facf-4c74-a5df-4d5a8c776513"), "ARIS - AEK", new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, "ARIS", "AEK" },
                    { new Guid("f99c5691-782c-4474-8e6e-ec3324986d2e"), "ATROMITOS - OSFP", new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, "ATROMITOS", "OSFP" },
                    { new Guid("faeace46-f6ae-4ca5-8a40-756ccbe739bc"), "PAO - AEL", new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 16, 19, 30, 0, 0, DateTimeKind.Unspecified), 2, "PAO", "AEL" }
                });

            migrationBuilder.InsertData(
                table: "MatchOdds",
                columns: new[] { "ID", "MatchID", "Odd", "Specifier" },
                values: new object[,]
                {
                    { new Guid("0151a1c3-224f-49f6-8320-fb962a40185a"), new Guid("1c2d829b-574b-4018-a013-2e495961e5af"), 1.5m, 1 },
                    { new Guid("1479255b-5581-4758-a0f6-fac8b350609a"), new Guid("a1ed0b7f-bd55-47e3-ac8f-a9cfc084f493"), 21.5m, 1 },
                    { new Guid("30287165-9956-4c56-be7f-4964595afef4"), new Guid("faeace46-f6ae-4ca5-8a40-756ccbe739bc"), 3.5m, 2 },
                    { new Guid("3098d611-a6a3-4bf4-9af0-4f0fcc664f71"), new Guid("efb755a6-facf-4c74-a5df-4d5a8c776513"), 5.7m, 3 },
                    { new Guid("31a31beb-1952-4c76-9407-29526196268d"), new Guid("6816f154-9e2a-46f5-93df-58581e1af7e5"), 2.5m, 2 },
                    { new Guid("34ff33b0-0512-46df-948f-a35f765aa79e"), new Guid("3dc581e4-c4ac-453a-bbdb-96e47ec0f8f5"), 2.1m, 1 },
                    { new Guid("39f5eb58-4593-4702-bf73-321532e02283"), new Guid("3dc581e4-c4ac-453a-bbdb-96e47ec0f8f5"), 6.2m, 3 },
                    { new Guid("3bd6b4dd-54b8-4b67-950a-66d39a8e43e6"), new Guid("3dc581e4-c4ac-453a-bbdb-96e47ec0f8f5"), 4.3m, 2 },
                    { new Guid("3dcd3315-a7c2-4b88-b5a1-b84de847c336"), new Guid("f99c5691-782c-4474-8e6e-ec3324986d2e"), 4.5m, 2 },
                    { new Guid("3ec52597-b870-452c-b0bf-f394695196da"), new Guid("2245137d-f773-4e15-beb6-63e33efde74b"), 15.0m, 2 },
                    { new Guid("468e17e0-954a-463e-82cd-1e8544ab862e"), new Guid("09d63ecd-9b44-4704-9e30-7e8917f86cd9"), 1.8m, 3 },
                    { new Guid("4f221313-0336-4638-85e2-e98aec58db3d"), new Guid("bc17ed3f-f331-4b2d-97d6-54508460e773"), 3.5m, 2 },
                    { new Guid("5011bad6-afe4-4185-bf79-4b74d720b531"), new Guid("bc17ed3f-f331-4b2d-97d6-54508460e773"), 1.8m, 1 },
                    { new Guid("56205b3b-a765-4e95-bc55-39e8f1306df7"), new Guid("d41a1476-7915-4787-96b0-cd1554897e8e"), 2.5m, 1 },
                    { new Guid("564d081d-5757-458c-ac87-e3fcd006a5d3"), new Guid("43b2cbea-f255-48de-bc8b-9f57c69b1a74"), 2.8m, 3 },
                    { new Guid("5e530860-cafa-460e-9a58-bb4f56378150"), new Guid("f99c5691-782c-4474-8e6e-ec3324986d2e"), 2.8m, 1 },
                    { new Guid("6412e81d-1d65-4240-a476-563f849acbe5"), new Guid("1c2d829b-574b-4018-a013-2e495961e5af"), 2.1m, 2 },
                    { new Guid("642797a3-aebc-4f18-8361-0306379da16d"), new Guid("43b2cbea-f255-48de-bc8b-9f57c69b1a74"), 1.9m, 2 },
                    { new Guid("66e40d2c-828c-437b-9e35-d8d42a5c6fb0"), new Guid("0e911fa2-0984-480f-aa0c-f4fe5952c288"), 3.5m, 1 },
                    { new Guid("6ee491ae-e8f5-4229-b5f0-96e162ff3093"), new Guid("faeace46-f6ae-4ca5-8a40-756ccbe739bc"), 4.2m, 1 },
                    { new Guid("72466db3-0ba1-4cb9-adcd-d034e3f0c347"), new Guid("bc17ed3f-f331-4b2d-97d6-54508460e773"), 2.2m, 3 },
                    { new Guid("7a993817-976c-4abf-b271-854b32980a2e"), new Guid("11292fdc-469c-4b83-a3a6-89714400648f"), 3.5m, 3 },
                    { new Guid("7c28036d-8879-440e-99b7-7e99fde2183f"), new Guid("b94fea12-4905-48b4-afdc-cd6ea480b527"), 6.2m, 1 },
                    { new Guid("8059b378-4877-4a67-8b77-87030e58b416"), new Guid("f99c5691-782c-4474-8e6e-ec3324986d2e"), 1.9m, 3 },
                    { new Guid("8efc0e9c-211c-4abe-8a16-38d0200e48b0"), new Guid("d41a1476-7915-4787-96b0-cd1554897e8e"), 11.2m, 3 },
                    { new Guid("8f75c42a-60fc-4d01-93f7-5bc8fa1d41d7"), new Guid("a842f311-5435-4edd-8c92-f19dd4cb3ad3"), 2.9m, 3 },
                    { new Guid("945e526a-b25c-460e-bc97-a408718eb798"), new Guid("a1ed0b7f-bd55-47e3-ac8f-a9cfc084f493"), 10.1m, 2 },
                    { new Guid("95a69baf-1885-4c4f-af88-605f6ade5ee2"), new Guid("faeace46-f6ae-4ca5-8a40-756ccbe739bc"), 2.1m, 3 },
                    { new Guid("96062e2b-7117-460a-ba1a-a994175837b7"), new Guid("09d63ecd-9b44-4704-9e30-7e8917f86cd9"), 2.5m, 1 },
                    { new Guid("9773ab24-86a1-4fe3-bb68-30bd17502164"), new Guid("0b56834f-f6a8-4f7f-9c06-9ec654c3273b"), 5.7m, 1 },
                    { new Guid("9a5cf555-c013-40d2-abcf-28179c901bed"), new Guid("a1ed0b7f-bd55-47e3-ac8f-a9cfc084f493"), 14.2m, 3 },
                    { new Guid("9acdbd57-99a2-4adc-97ac-812139c84ea2"), new Guid("2245137d-f773-4e15-beb6-63e33efde74b"), 12.0m, 3 },
                    { new Guid("9bfd4ff8-76bb-4fc9-b13e-199803806dfa"), new Guid("0b56834f-f6a8-4f7f-9c06-9ec654c3273b"), 3.2m, 3 },
                    { new Guid("9c28f914-548a-4708-ab10-32cea4d6995d"), new Guid("e407ae90-843c-4221-8bcc-4e1174f55d7b"), 6.2m, 3 },
                    { new Guid("b2ad695c-10b4-42ba-8f14-49994acff6f4"), new Guid("388dbe54-27b6-4fdd-8896-eb9481a95ff6"), 1.5m, 2 },
                    { new Guid("b3eff906-ec60-4e68-a571-3ec13dd19dc0"), new Guid("98eddf51-4fcb-43fb-901d-f377c895615a"), 2.9m, 2 },
                    { new Guid("b77f498f-fb66-4d06-ab75-64f1054edb53"), new Guid("2245137d-f773-4e15-beb6-63e33efde74b"), 9.5m, 1 },
                    { new Guid("b80ff5fe-8009-47b1-9207-c508662dec30"), new Guid("a842f311-5435-4edd-8c92-f19dd4cb3ad3"), 3.5m, 2 },
                    { new Guid("b8d92d07-3a81-454b-b845-48cea35d626a"), new Guid("efb755a6-facf-4c74-a5df-4d5a8c776513"), 3.2m, 2 },
                    { new Guid("bb2f2de5-989a-42fd-936f-d1da583653b1"), new Guid("0b56834f-f6a8-4f7f-9c06-9ec654c3273b"), 2.3m, 2 },
                    { new Guid("bb86e5e4-369e-40ea-9d09-17466e02613d"), new Guid("e407ae90-843c-4221-8bcc-4e1174f55d7b"), 5.0m, 2 },
                    { new Guid("bc99e591-61e7-4655-93b2-495ea68b6662"), new Guid("11292fdc-469c-4b83-a3a6-89714400648f"), 1.8m, 2 },
                    { new Guid("bf3af53b-a579-4292-b98e-dabb380ef5dd"), new Guid("6816f154-9e2a-46f5-93df-58581e1af7e5"), 1.9m, 1 },
                    { new Guid("c4afcb79-a7ea-48c8-9959-65dd785b98ff"), new Guid("b94fea12-4905-48b4-afdc-cd6ea480b527"), 4.3m, 3 },
                    { new Guid("c6abcbad-3388-4b2c-9a7d-573c670fe076"), new Guid("0e911fa2-0984-480f-aa0c-f4fe5952c288"), 4.2m, 3 },
                    { new Guid("c6c6cddb-c380-45a7-ad82-e6a651923825"), new Guid("43b2cbea-f255-48de-bc8b-9f57c69b1a74"), 4.5m, 1 },
                    { new Guid("c8299be9-c99c-4a58-afc1-81ea7177af66"), new Guid("388dbe54-27b6-4fdd-8896-eb9481a95ff6"), 2.1m, 3 },
                    { new Guid("cbdcd566-e18c-45e3-a1aa-2154cf279aec"), new Guid("6816f154-9e2a-46f5-93df-58581e1af7e5"), 4.3m, 3 },
                    { new Guid("cdbaed02-3be1-43f4-83e3-e708ab252fe9"), new Guid("0e911fa2-0984-480f-aa0c-f4fe5952c288"), 2.1m, 2 },
                    { new Guid("cf2a6b8b-7f78-4c37-a70d-22723456298d"), new Guid("388dbe54-27b6-4fdd-8896-eb9481a95ff6"), 3.2m, 1 },
                    { new Guid("db15a8d0-6857-42c5-a1a0-a75155935f96"), new Guid("11292fdc-469c-4b83-a3a6-89714400648f"), 2.2m, 1 },
                    { new Guid("db692d51-91c3-4f06-b95a-56d7830ebc1f"), new Guid("98eddf51-4fcb-43fb-901d-f377c895615a"), 3.5m, 1 },
                    { new Guid("dc2cb33a-572b-44ec-a4ac-dc01730a34ff"), new Guid("e407ae90-843c-4221-8bcc-4e1174f55d7b"), 3.5m, 1 },
                    { new Guid("e88e832f-88ff-45ba-8c14-d762fec142ec"), new Guid("d41a1476-7915-4787-96b0-cd1554897e8e"), 4.1m, 2 },
                    { new Guid("ebe0d5c1-6983-4f08-a7ec-e28661c02a5c"), new Guid("1c2d829b-574b-4018-a013-2e495961e5af"), 3.2m, 3 },
                    { new Guid("ee7874ee-1523-498c-ae85-1ac81eb020df"), new Guid("98eddf51-4fcb-43fb-901d-f377c895615a"), 7.1m, 3 },
                    { new Guid("f4647e4e-6810-42cc-924a-92f77d11aa96"), new Guid("a842f311-5435-4edd-8c92-f19dd4cb3ad3"), 7.1m, 1 },
                    { new Guid("fa9b5071-8644-4f06-8b9e-3ac8896e5d64"), new Guid("b94fea12-4905-48b4-afdc-cd6ea480b527"), 2.1m, 2 },
                    { new Guid("fc221c13-96b4-4f23-876d-b54fcfb3cdf8"), new Guid("09d63ecd-9b44-4704-9e30-7e8917f86cd9"), 4.0m, 2 },
                    { new Guid("fc99b406-4350-4331-a8c5-404a13779b4e"), new Guid("efb755a6-facf-4c74-a5df-4d5a8c776513"), 2.3m, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("0151a1c3-224f-49f6-8320-fb962a40185a"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("1479255b-5581-4758-a0f6-fac8b350609a"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("30287165-9956-4c56-be7f-4964595afef4"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("3098d611-a6a3-4bf4-9af0-4f0fcc664f71"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("31a31beb-1952-4c76-9407-29526196268d"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("34ff33b0-0512-46df-948f-a35f765aa79e"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("39f5eb58-4593-4702-bf73-321532e02283"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("3bd6b4dd-54b8-4b67-950a-66d39a8e43e6"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("3dcd3315-a7c2-4b88-b5a1-b84de847c336"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("3ec52597-b870-452c-b0bf-f394695196da"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("468e17e0-954a-463e-82cd-1e8544ab862e"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("4f221313-0336-4638-85e2-e98aec58db3d"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("5011bad6-afe4-4185-bf79-4b74d720b531"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("56205b3b-a765-4e95-bc55-39e8f1306df7"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("564d081d-5757-458c-ac87-e3fcd006a5d3"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("5e530860-cafa-460e-9a58-bb4f56378150"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("6412e81d-1d65-4240-a476-563f849acbe5"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("642797a3-aebc-4f18-8361-0306379da16d"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("66e40d2c-828c-437b-9e35-d8d42a5c6fb0"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("6ee491ae-e8f5-4229-b5f0-96e162ff3093"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("72466db3-0ba1-4cb9-adcd-d034e3f0c347"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("7a993817-976c-4abf-b271-854b32980a2e"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("7c28036d-8879-440e-99b7-7e99fde2183f"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("8059b378-4877-4a67-8b77-87030e58b416"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("8efc0e9c-211c-4abe-8a16-38d0200e48b0"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("8f75c42a-60fc-4d01-93f7-5bc8fa1d41d7"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("945e526a-b25c-460e-bc97-a408718eb798"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("95a69baf-1885-4c4f-af88-605f6ade5ee2"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("96062e2b-7117-460a-ba1a-a994175837b7"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("9773ab24-86a1-4fe3-bb68-30bd17502164"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("9a5cf555-c013-40d2-abcf-28179c901bed"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("9acdbd57-99a2-4adc-97ac-812139c84ea2"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("9bfd4ff8-76bb-4fc9-b13e-199803806dfa"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("9c28f914-548a-4708-ab10-32cea4d6995d"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("b2ad695c-10b4-42ba-8f14-49994acff6f4"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("b3eff906-ec60-4e68-a571-3ec13dd19dc0"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("b77f498f-fb66-4d06-ab75-64f1054edb53"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("b80ff5fe-8009-47b1-9207-c508662dec30"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("b8d92d07-3a81-454b-b845-48cea35d626a"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("bb2f2de5-989a-42fd-936f-d1da583653b1"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("bb86e5e4-369e-40ea-9d09-17466e02613d"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("bc99e591-61e7-4655-93b2-495ea68b6662"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("bf3af53b-a579-4292-b98e-dabb380ef5dd"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("c4afcb79-a7ea-48c8-9959-65dd785b98ff"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("c6abcbad-3388-4b2c-9a7d-573c670fe076"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("c6c6cddb-c380-45a7-ad82-e6a651923825"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("c8299be9-c99c-4a58-afc1-81ea7177af66"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("cbdcd566-e18c-45e3-a1aa-2154cf279aec"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("cdbaed02-3be1-43f4-83e3-e708ab252fe9"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("cf2a6b8b-7f78-4c37-a70d-22723456298d"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("db15a8d0-6857-42c5-a1a0-a75155935f96"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("db692d51-91c3-4f06-b95a-56d7830ebc1f"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("dc2cb33a-572b-44ec-a4ac-dc01730a34ff"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("e88e832f-88ff-45ba-8c14-d762fec142ec"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("ebe0d5c1-6983-4f08-a7ec-e28661c02a5c"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("ee7874ee-1523-498c-ae85-1ac81eb020df"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("f4647e4e-6810-42cc-924a-92f77d11aa96"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("fa9b5071-8644-4f06-8b9e-3ac8896e5d64"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("fc221c13-96b4-4f23-876d-b54fcfb3cdf8"));

            migrationBuilder.DeleteData(
                table: "MatchOdds",
                keyColumn: "ID",
                keyValue: new Guid("fc99b406-4350-4331-a8c5-404a13779b4e"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("09d63ecd-9b44-4704-9e30-7e8917f86cd9"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("0b56834f-f6a8-4f7f-9c06-9ec654c3273b"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("0e911fa2-0984-480f-aa0c-f4fe5952c288"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("11292fdc-469c-4b83-a3a6-89714400648f"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("1c2d829b-574b-4018-a013-2e495961e5af"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("2245137d-f773-4e15-beb6-63e33efde74b"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("388dbe54-27b6-4fdd-8896-eb9481a95ff6"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("3dc581e4-c4ac-453a-bbdb-96e47ec0f8f5"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("43b2cbea-f255-48de-bc8b-9f57c69b1a74"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("6816f154-9e2a-46f5-93df-58581e1af7e5"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("98eddf51-4fcb-43fb-901d-f377c895615a"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("a1ed0b7f-bd55-47e3-ac8f-a9cfc084f493"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("a842f311-5435-4edd-8c92-f19dd4cb3ad3"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("b94fea12-4905-48b4-afdc-cd6ea480b527"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("bc17ed3f-f331-4b2d-97d6-54508460e773"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("d41a1476-7915-4787-96b0-cd1554897e8e"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("e407ae90-843c-4221-8bcc-4e1174f55d7b"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("efb755a6-facf-4c74-a5df-4d5a8c776513"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("f99c5691-782c-4474-8e6e-ec3324986d2e"));

            migrationBuilder.DeleteData(
                table: "Match",
                keyColumn: "ID",
                keyValue: new Guid("faeace46-f6ae-4ca5-8a40-756ccbe739bc"));

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
    }
}
