using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PublisherData.Migrations
{
    public partial class SeedBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Esteban", "Smitham", new DateTime(2024, 2, 29, 7, 32, 2, 327, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Queenie", "Stanton", new DateTime(2024, 2, 24, 10, 0, 11, 190, DateTimeKind.Local).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Sabryna", "Blanda", new DateTime(2024, 3, 12, 0, 32, 34, 581, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Queen", "Dicki", new DateTime(2024, 3, 9, 11, 7, 20, 316, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Torey", "McCullough", new DateTime(2024, 3, 2, 19, 3, 32, 987, DateTimeKind.Local).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Hailie", "Wolf", new DateTime(2024, 3, 12, 4, 24, 41, 677, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Shany", "Leuschke", new DateTime(2024, 3, 19, 13, 0, 7, 894, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 8,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Valentine", "Gibson", new DateTime(2024, 3, 2, 17, 23, 37, 521, DateTimeKind.Local).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Joyce", "Streich", new DateTime(2024, 3, 10, 21, 24, 40, 307, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Kariane", "Gislason", new DateTime(2024, 3, 19, 5, 30, 32, 597, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 11,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Shemar", "Ziemann", new DateTime(2024, 3, 20, 12, 27, 50, 711, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 12,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Ashlee", "Schuster", new DateTime(2024, 2, 23, 17, 16, 31, 354, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 13,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Dameon", "Trantow", new DateTime(2024, 3, 13, 4, 5, 20, 441, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 14,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Tyrell", "Gerhold", new DateTime(2024, 3, 13, 5, 28, 23, 868, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 15,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Birdie", "Langworth", new DateTime(2024, 2, 23, 21, 59, 27, 305, DateTimeKind.Local).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 16,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Gudrun", "Hegmann", new DateTime(2024, 3, 18, 18, 53, 17, 566, DateTimeKind.Local).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 17,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Katharina", "Lakin", new DateTime(2024, 3, 4, 9, 25, 34, 331, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 18,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Dedrick", "Thiel", new DateTime(2024, 3, 18, 4, 8, 45, 169, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 19,
                columns: new[] { "FirstName", "LastUpdated" },
                values: new object[] { "Rocky", new DateTime(2024, 3, 15, 2, 16, 30, 74, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 20,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Karli", "Jakubowski", new DateTime(2024, 3, 9, 1, 36, 35, 187, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 21,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Callie", "Grady", new DateTime(2024, 3, 19, 21, 51, 31, 53, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 22,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Evie", "Wintheiser", new DateTime(2024, 3, 12, 0, 52, 31, 98, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 23,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Stephania", "Moore", new DateTime(2024, 3, 21, 8, 33, 40, 75, DateTimeKind.Local).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 24,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Arvid", "Connelly", new DateTime(2024, 2, 27, 7, 52, 4, 887, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 25,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Hanna", "Conroy", new DateTime(2024, 2, 28, 15, 8, 3, 287, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 26,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Rudolph", "Wolf", new DateTime(2024, 3, 16, 12, 3, 14, 163, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 27,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Chris", "O'Connell", new DateTime(2024, 3, 19, 19, 55, 20, 188, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 28,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Una", "Hodkiewicz", new DateTime(2024, 3, 14, 22, 12, 6, 41, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 29,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Eryn", "Williamson", new DateTime(2024, 2, 25, 23, 6, 42, 40, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 30,
                columns: new[] { "FirstName", "LastUpdated" },
                values: new object[] { "Ceasar", new DateTime(2024, 3, 9, 2, 44, 14, 444, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 31,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Lillian", "Conroy", new DateTime(2024, 2, 26, 3, 19, 20, 125, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 32,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Sincere", "Bechtelar", new DateTime(2024, 3, 7, 16, 46, 10, 293, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 33,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Polly", "Witting", new DateTime(2024, 3, 20, 10, 45, 34, 951, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 34,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Cicero", "McDermott", new DateTime(2024, 3, 10, 22, 49, 38, 370, DateTimeKind.Local).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 35,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Daryl", "Mohr", new DateTime(2024, 3, 7, 1, 3, 3, 522, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 36,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Jackie", "Brakus", new DateTime(2024, 3, 2, 6, 57, 53, 186, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 37,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Gertrude", "Grimes", new DateTime(2024, 2, 25, 6, 29, 59, 528, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 38,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Domenica", "Erdman", new DateTime(2024, 3, 1, 7, 41, 32, 392, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 39,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Rocio", "Sauer", new DateTime(2024, 3, 13, 17, 25, 39, 326, DateTimeKind.Local).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 40,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Candelario", "Daniel", new DateTime(2024, 3, 9, 1, 54, 58, 836, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 41,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Janae", "Dietrich", new DateTime(2024, 3, 4, 1, 2, 55, 175, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 42,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Shanon", "Bradtke", new DateTime(2024, 3, 18, 13, 59, 51, 146, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 43,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Mireille", "Abshire", new DateTime(2024, 3, 17, 2, 49, 47, 125, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 44,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Taya", "Larson", new DateTime(2024, 2, 26, 13, 16, 39, 987, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 45,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Lavina", "Denesik", new DateTime(2024, 3, 3, 21, 18, 15, 991, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 46,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Addie", "Rowe", new DateTime(2024, 3, 17, 4, 13, 52, 768, DateTimeKind.Local).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 47,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Duncan", "Witting", new DateTime(2024, 3, 6, 22, 42, 39, 579, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 48,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Gregoria", "Graham", new DateTime(2024, 3, 8, 7, 31, 17, 898, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 49,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Ahmed", "Ondricka", new DateTime(2024, 3, 16, 18, 9, 14, 213, DateTimeKind.Local).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 50,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Watson", "Larkin", new DateTime(2024, 2, 28, 19, 55, 8, 265, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 51,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Shanna", "Kihn", new DateTime(2024, 3, 22, 10, 1, 53, 756, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 52,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Laurine", "Zboncak", new DateTime(2024, 3, 7, 17, 50, 9, 579, DateTimeKind.Local).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 53,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Rogelio", "Strosin", new DateTime(2024, 3, 11, 4, 25, 6, 901, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 54,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Myriam", "O'Keefe", new DateTime(2024, 2, 24, 20, 24, 31, 763, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 55,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Julio", "West", new DateTime(2024, 3, 21, 14, 21, 32, 520, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 56,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Heloise", "Crooks", new DateTime(2024, 2, 27, 14, 47, 49, 115, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 57,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Orland", "O'Hara", new DateTime(2024, 2, 28, 23, 54, 58, 321, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 58,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Erick", "Ruecker", new DateTime(2024, 2, 22, 14, 49, 49, 888, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 59,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Deron", "Goyette", new DateTime(2024, 3, 6, 16, 27, 28, 755, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 60,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Kiarra", "Kuhic", new DateTime(2024, 3, 8, 16, 59, 48, 231, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 61,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Florence", "Windler", new DateTime(2024, 2, 21, 18, 3, 23, 5, DateTimeKind.Local).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 62,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Autumn", "Huel", new DateTime(2024, 2, 24, 16, 32, 32, 801, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 63,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Eugene", "Hettinger", new DateTime(2024, 2, 28, 23, 41, 41, 804, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 64,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Marlen", "Abernathy", new DateTime(2024, 3, 20, 23, 7, 27, 513, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 65,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Antonia", "Oberbrunner", new DateTime(2024, 3, 19, 14, 16, 42, 817, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 66,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Wiley", "Senger", new DateTime(2024, 3, 13, 1, 32, 27, 762, DateTimeKind.Local).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 67,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Rhett", "Osinski", new DateTime(2024, 2, 22, 0, 25, 57, 29, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 68,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Jewel", "Volkman", new DateTime(2024, 3, 14, 19, 37, 15, 715, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 69,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Hermina", "Stroman", new DateTime(2024, 3, 12, 22, 55, 16, 46, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 70,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Thomas", "Wisoky", new DateTime(2024, 2, 29, 16, 3, 30, 332, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 71,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Caesar", "Hackett", new DateTime(2024, 3, 9, 17, 30, 18, 4, DateTimeKind.Local).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 72,
                columns: new[] { "FirstName", "LastUpdated" },
                values: new object[] { "Joe", new DateTime(2024, 3, 22, 8, 32, 51, 601, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 73,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Ruby", "Grady", new DateTime(2024, 3, 3, 16, 21, 41, 182, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 74,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Elton", "Gleason", new DateTime(2024, 3, 1, 11, 22, 28, 775, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 75,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Urban", "Vandervort", new DateTime(2024, 2, 22, 13, 7, 16, 294, DateTimeKind.Local).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 76,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Alia", "Kuvalis", new DateTime(2024, 3, 9, 6, 57, 34, 483, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 77,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Samara", "Simonis", new DateTime(2024, 3, 20, 17, 40, 59, 87, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 78,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Jazlyn", "Bayer", new DateTime(2024, 3, 1, 20, 48, 18, 870, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 79,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Gaetano", "Krajcik", new DateTime(2024, 2, 29, 4, 10, 15, 482, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 80,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Ewald", "Howell", new DateTime(2024, 3, 22, 1, 7, 47, 949, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 81,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Geoffrey", "Weimann", new DateTime(2024, 3, 14, 7, 37, 28, 724, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 82,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Kim", "Collins", new DateTime(2024, 3, 15, 16, 5, 38, 232, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 83,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Janessa", "Dooley", new DateTime(2024, 2, 22, 2, 50, 16, 279, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 84,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Fannie", "Jacobi", new DateTime(2024, 3, 7, 23, 7, 4, 413, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 85,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Danika", "Quitzon", new DateTime(2024, 2, 22, 7, 46, 27, 248, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 86,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Lisa", "Rath", new DateTime(2024, 3, 19, 19, 37, 14, 575, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 87,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Kayley", "Schoen", new DateTime(2024, 2, 28, 23, 13, 3, 173, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 88,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Ford", "Nolan", new DateTime(2024, 3, 1, 22, 40, 47, 162, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 89,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Benedict", "Welch", new DateTime(2024, 3, 13, 16, 12, 42, 975, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 90,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Gina", "Senger", new DateTime(2024, 3, 14, 11, 42, 55, 158, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 91,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Emilia", "Shields", new DateTime(2024, 3, 19, 8, 7, 0, 571, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 92,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Harley", "Hodkiewicz", new DateTime(2024, 3, 6, 17, 16, 14, 457, DateTimeKind.Local).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 93,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Hiram", "McGlynn", new DateTime(2024, 3, 3, 17, 2, 6, 869, DateTimeKind.Local).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 94,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Evelyn", "Dooley", new DateTime(2024, 3, 12, 1, 23, 18, 584, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 95,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Lori", "Macejkovic", new DateTime(2024, 3, 14, 22, 59, 2, 885, DateTimeKind.Local).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 96,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Liza", "West", new DateTime(2024, 3, 1, 4, 10, 8, 142, DateTimeKind.Local).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 97,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Terrell", "Wilderman", new DateTime(2024, 3, 19, 14, 20, 45, 446, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 98,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Mireya", "Jast", new DateTime(2024, 3, 9, 0, 0, 10, 601, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 99,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Frances", "Denesik", new DateTime(2024, 2, 23, 10, 12, 51, 760, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 100,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Lori", "Heller", new DateTime(2024, 2, 26, 7, 29, 32, 445, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 25, 60.885423972223275m, new DateTime(2022, 9, 12, 8, 13, 5, 193, DateTimeKind.Local).AddTicks(1398), "transition robust e-markets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 90, 51.714200538699345m, new DateTime(2023, 5, 2, 2, 50, 29, 512, DateTimeKind.Local).AddTicks(9190), "aggregate back-end synergies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 63, 36.326879413568765m, new DateTime(2020, 5, 16, 17, 25, 44, 368, DateTimeKind.Local).AddTicks(1537), "transform world-class synergies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 47, 75.789107054461020m, new DateTime(2020, 10, 3, 7, 40, 5, 344, DateTimeKind.Local).AddTicks(7134), "disintermediate magnetic users" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 26, 25.625221708531165m, new DateTime(2017, 3, 4, 17, 13, 33, 572, DateTimeKind.Local).AddTicks(3812), "expedite holistic initiatives" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 11, 53.212348043261290m, new DateTime(2018, 4, 16, 0, 40, 44, 790, DateTimeKind.Local).AddTicks(1378), "brand visionary convergence" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 62, 95.304495786126580m, new DateTime(2019, 8, 15, 21, 39, 23, 586, DateTimeKind.Local).AddTicks(2928), "strategize e-business metrics" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 91, 89.412406085671175m, new DateTime(2021, 11, 14, 5, 54, 38, 411, DateTimeKind.Local).AddTicks(602), "whiteboard cross-platform e-commerce" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 37, 38.616421654110840m, new DateTime(2019, 10, 7, 12, 42, 51, 743, DateTimeKind.Local).AddTicks(5441), "integrate proactive vortals" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 62, 73.041568354603140m, new DateTime(2023, 7, 10, 20, 25, 31, 324, DateTimeKind.Local).AddTicks(7745), "recontextualize sexy architectures" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 85, 14.535031600282575m, new DateTime(2023, 9, 3, 9, 9, 44, 459, DateTimeKind.Local).AddTicks(4824), "envisioneer cross-platform experiences" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 20, 25.099523255942875m, new DateTime(2016, 12, 7, 11, 29, 8, 739, DateTimeKind.Local).AddTicks(510), "brand leading-edge platforms" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                columns: new[] { "BasePrice", "PublishDate", "Title" },
                values: new object[] { 75.828712116217090m, new DateTime(2023, 11, 8, 11, 44, 28, 894, DateTimeKind.Local).AddTicks(5966), "leverage enterprise initiatives" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 89, 11.186097820464195m, new DateTime(2019, 7, 24, 16, 36, 19, 209, DateTimeKind.Local).AddTicks(9706), "incentivize B2C action-items" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 63, 48.284445162498235m, new DateTime(2019, 10, 9, 5, 45, 1, 408, DateTimeKind.Local).AddTicks(5519), "matrix real-time metrics" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 81, 88.219007648847335m, new DateTime(2022, 9, 8, 21, 53, 20, 303, DateTimeKind.Local).AddTicks(1214), "evolve killer applications" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 26, 45.95703266729720m, new DateTime(2016, 12, 18, 15, 40, 2, 570, DateTimeKind.Local).AddTicks(1550), "visualize B2B portals" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 74, 25.993848286950110m, new DateTime(2014, 5, 29, 13, 21, 41, 57, DateTimeKind.Local).AddTicks(2583), "utilize B2B synergies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 44, 20.830353369712155m, new DateTime(2019, 3, 6, 15, 40, 1, 405, DateTimeKind.Local).AddTicks(136), "envisioneer robust channels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 54, 13.9206945229349235m, new DateTime(2023, 4, 10, 12, 11, 57, 406, DateTimeKind.Local).AddTicks(9285), "transform cross-media infomediaries" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 7, 94.902997778534380m, new DateTime(2019, 2, 7, 20, 25, 16, 185, DateTimeKind.Local).AddTicks(2467), "visualize integrated functionalities" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 6, 94.660404042693335m, new DateTime(2023, 11, 29, 16, 46, 54, 476, DateTimeKind.Local).AddTicks(2589), "recontextualize innovative e-markets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 17, 49.816595646968585m, new DateTime(2019, 6, 30, 9, 16, 33, 31, DateTimeKind.Local).AddTicks(2436), "optimize frictionless action-items" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 24,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 46, 87.388365141321330m, new DateTime(2022, 7, 6, 16, 3, 56, 836, DateTimeKind.Local).AddTicks(9580), "drive holistic supply-chains" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 25,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 12, 55.437353088385635m, new DateTime(2015, 7, 22, 21, 2, 11, 809, DateTimeKind.Local).AddTicks(7182), "maximize innovative partnerships" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 26,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 65, 96.62613368187715m, new DateTime(2019, 12, 1, 14, 26, 18, 272, DateTimeKind.Local).AddTicks(5698), "scale strategic portals" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 70, 88.521472572070885m, new DateTime(2018, 4, 27, 16, 44, 33, 466, DateTimeKind.Local).AddTicks(7949), "whiteboard next-generation interfaces" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 9, 90.707729591327065m, new DateTime(2023, 10, 21, 16, 14, 50, 51, DateTimeKind.Local).AddTicks(5068), "strategize seamless relationships" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 29,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 50, 68.9373457595795m, new DateTime(2021, 10, 1, 9, 44, 28, 26, DateTimeKind.Local).AddTicks(4353), "brand collaborative web-readiness" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 30,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 73, 97.488270684259895m, new DateTime(2023, 2, 25, 18, 32, 42, 913, DateTimeKind.Local).AddTicks(2629), "facilitate ubiquitous initiatives" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 31,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 24, 86.573369370598595m, new DateTime(2019, 7, 10, 2, 56, 47, 250, DateTimeKind.Local).AddTicks(5439), "integrate open-source niches" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 32,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 59, 68.390668078959420m, new DateTime(2014, 8, 16, 8, 44, 18, 185, DateTimeKind.Local).AddTicks(5427), "e-enable value-added e-commerce" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 33,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 83, 44.579563127941685m, new DateTime(2024, 3, 14, 13, 0, 42, 221, DateTimeKind.Local).AddTicks(619), "innovate 24/7 web services" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 34,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 19, 42.055688650065380m, new DateTime(2019, 8, 22, 10, 54, 15, 225, DateTimeKind.Local).AddTicks(900), "empower magnetic web services" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 35,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 16, 90.418158963482315m, new DateTime(2018, 3, 27, 6, 22, 30, 596, DateTimeKind.Local).AddTicks(9610), "incentivize vertical mindshare" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 36,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 85, 30.563409303953955m, new DateTime(2015, 12, 18, 11, 35, 45, 87, DateTimeKind.Local).AddTicks(1658), "extend killer solutions" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 37,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 91, 67.874567274316675m, new DateTime(2015, 8, 4, 8, 12, 16, 297, DateTimeKind.Local).AddTicks(7473), "integrate dynamic deliverables" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 38,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 13, 60.404938700989180m, new DateTime(2016, 12, 10, 23, 59, 35, 301, DateTimeKind.Local).AddTicks(3621), "implement one-to-one portals" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 39,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 61, 50.016212015441990m, new DateTime(2018, 1, 5, 4, 51, 43, 137, DateTimeKind.Local).AddTicks(7643), "reintermediate sticky e-commerce" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 40,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 54, 80.957925711293510m, new DateTime(2018, 2, 1, 23, 59, 24, 295, DateTimeKind.Local).AddTicks(4314), "drive turn-key networks" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 41,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 47, 39.218254727676530m, new DateTime(2017, 3, 25, 6, 25, 33, 7, DateTimeKind.Local).AddTicks(4022), "matrix revolutionary infrastructures" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 42,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 13, 48.915757656156215m, new DateTime(2016, 8, 20, 3, 31, 57, 219, DateTimeKind.Local).AddTicks(1496), "synthesize user-centric schemas" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 43,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 29, 55.14503062322835m, new DateTime(2017, 3, 4, 6, 19, 24, 636, DateTimeKind.Local).AddTicks(3037), "maximize transparent eyeballs" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 44,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 20, 11.0728488186627390m, new DateTime(2023, 1, 24, 8, 57, 42, 581, DateTimeKind.Local).AddTicks(435), "repurpose seamless e-markets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 45,
                columns: new[] { "BasePrice", "PublishDate", "Title" },
                values: new object[] { 45.158815778058870m, new DateTime(2022, 9, 15, 6, 6, 57, 113, DateTimeKind.Local).AddTicks(5426), "aggregate turn-key networks" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 46,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 12, 63.930270225874910m, new DateTime(2017, 9, 8, 1, 16, 40, 283, DateTimeKind.Local).AddTicks(611), "utilize bricks-and-clicks e-services" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 47,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 27, 78.568451723305390m, new DateTime(2014, 7, 6, 15, 49, 27, 967, DateTimeKind.Local).AddTicks(8634), "productize intuitive action-items" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 48,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 93, 8.7330749910065520m, new DateTime(2014, 4, 24, 10, 20, 46, 485, DateTimeKind.Local).AddTicks(869), "generate innovative e-business" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 49,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 97, 20.585401467901130m, new DateTime(2020, 10, 13, 17, 34, 48, 494, DateTimeKind.Local).AddTicks(8693), "evolve rich experiences" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 50,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 96, 51.650695548754955m, new DateTime(2018, 2, 11, 6, 29, 48, 512, DateTimeKind.Local).AddTicks(3992), "grow proactive applications" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 51,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 85, 87.967713687618640m, new DateTime(2018, 1, 20, 21, 22, 15, 713, DateTimeKind.Local).AddTicks(6060), "reinvent robust users" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 52,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 32, 37.952273037774815m, new DateTime(2023, 12, 15, 3, 42, 30, 791, DateTimeKind.Local).AddTicks(3458), "cultivate mission-critical schemas" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 53,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 11, 11.3512016213436475m, new DateTime(2018, 4, 27, 13, 37, 25, 874, DateTimeKind.Local).AddTicks(3178), "utilize 24/365 infrastructures" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 54,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 86, 74.739878044094115m, new DateTime(2015, 3, 16, 19, 30, 3, 942, DateTimeKind.Local).AddTicks(1166), "transform transparent action-items" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 55,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 17, 30.195499485729070m, new DateTime(2021, 8, 9, 16, 15, 6, 906, DateTimeKind.Local).AddTicks(6729), "unleash distributed metrics" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 56,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 78, 42.0440298858825m, new DateTime(2014, 3, 28, 22, 18, 0, 86, DateTimeKind.Local).AddTicks(8501), "brand transparent markets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 57,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 1, 6.0508698074255180m, new DateTime(2018, 5, 9, 15, 0, 14, 299, DateTimeKind.Local).AddTicks(8213), "utilize user-centric synergies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 58,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 50, 65.63554667300205m, new DateTime(2019, 4, 30, 17, 34, 5, 162, DateTimeKind.Local).AddTicks(5038), "whiteboard e-business experiences" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 59,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 47, 72.96824286085785m, new DateTime(2023, 6, 4, 22, 10, 59, 255, DateTimeKind.Local).AddTicks(6439), "deliver e-business applications" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 60,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 37, 90.895893699022340m, new DateTime(2015, 5, 2, 1, 4, 8, 772, DateTimeKind.Local).AddTicks(5409), "whiteboard world-class mindshare" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 61,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 35, 71.818054571351825m, new DateTime(2017, 6, 28, 21, 11, 43, 313, DateTimeKind.Local).AddTicks(9634), "transform killer networks" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 62,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 28, 88.102630384108420m, new DateTime(2022, 6, 12, 21, 9, 26, 538, DateTimeKind.Local).AddTicks(5374), "synergize sticky infrastructures" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 63,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 48, 26.351250477164005m, new DateTime(2017, 6, 3, 2, 0, 51, 701, DateTimeKind.Local).AddTicks(5095), "facilitate cutting-edge experiences" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 64,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 74, 27.184798688297590m, new DateTime(2018, 8, 17, 12, 48, 51, 254, DateTimeKind.Local).AddTicks(5015), "expedite compelling models" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 65,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 84, 29.116707992789755m, new DateTime(2018, 5, 29, 0, 18, 52, 447, DateTimeKind.Local).AddTicks(1762), "architect back-end ROI" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 66,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 16, 55.770501375424090m, new DateTime(2021, 9, 26, 3, 37, 39, 47, DateTimeKind.Local).AddTicks(7719), "transform extensible paradigms" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 67,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 55, 72.532881049461525m, new DateTime(2015, 12, 2, 23, 37, 11, 125, DateTimeKind.Local).AddTicks(5648), "aggregate robust paradigms" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 68,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 97, 63.668458183343095m, new DateTime(2015, 6, 25, 14, 7, 39, 610, DateTimeKind.Local).AddTicks(7666), "repurpose cross-media content" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 69,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 64, 34.444452322037365m, new DateTime(2018, 3, 18, 15, 31, 43, 902, DateTimeKind.Local).AddTicks(3632), "integrate next-generation systems" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 70,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 47, 60.55712298431440m, new DateTime(2023, 7, 3, 0, 34, 59, 108, DateTimeKind.Local).AddTicks(540), "disintermediate B2C e-markets" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 71,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 26, 10.189082295526315m, new DateTime(2017, 10, 5, 8, 44, 43, 768, DateTimeKind.Local).AddTicks(1930), "extend strategic methodologies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 72,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 15, 96.001719997900295m, new DateTime(2015, 12, 31, 16, 31, 55, 606, DateTimeKind.Local).AddTicks(9499), "grow front-end blockchains" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 73,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 33, 22.312216858831830m, new DateTime(2018, 12, 25, 20, 15, 52, 518, DateTimeKind.Local).AddTicks(7651), "transition cross-platform mindshare" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 74,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 83, 48.162125601227560m, new DateTime(2014, 12, 16, 0, 6, 37, 703, DateTimeKind.Local).AddTicks(6371), "harness clicks-and-mortar web-readiness" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 75,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 51, 26.008567819381195m, new DateTime(2015, 7, 26, 18, 36, 8, 722, DateTimeKind.Local).AddTicks(7417), "monetize ubiquitous eyeballs" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 76,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 89, 30.218368293754640m, new DateTime(2020, 2, 20, 19, 37, 4, 940, DateTimeKind.Local).AddTicks(5213), "visualize virtual functionalities" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 77,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 14, 52.207169608699140m, new DateTime(2019, 4, 8, 2, 51, 36, 642, DateTimeKind.Local).AddTicks(4674), "leverage B2C e-commerce" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 78,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 15, 76.361713520950695m, new DateTime(2021, 2, 26, 5, 40, 46, 833, DateTimeKind.Local).AddTicks(2281), "deliver efficient relationships" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 79,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 13, 43.87845665300740m, new DateTime(2022, 11, 24, 1, 30, 4, 518, DateTimeKind.Local).AddTicks(3811), "syndicate open-source synergies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 80,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 83, 9.5214601086555295m, new DateTime(2014, 12, 8, 9, 2, 54, 127, DateTimeKind.Local).AddTicks(5657), "productize innovative users" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 81,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 98, 16.556940431420745m, new DateTime(2020, 2, 28, 20, 12, 9, 472, DateTimeKind.Local).AddTicks(3350), "transform frictionless channels" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 82,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 34, 28.073061571679270m, new DateTime(2015, 6, 12, 6, 17, 19, 434, DateTimeKind.Local).AddTicks(5924), "disintermediate intuitive e-tailers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 83,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 35, 34.325160641222820m, new DateTime(2022, 12, 17, 13, 48, 31, 878, DateTimeKind.Local).AddTicks(5178), "envisioneer 24/7 e-commerce" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 84,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 72, 96.33774888783880m, new DateTime(2017, 9, 18, 15, 20, 49, 947, DateTimeKind.Local).AddTicks(1314), "exploit next-generation functionalities" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 85,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 88, 37.255142243280390m, new DateTime(2020, 4, 25, 11, 55, 4, 496, DateTimeKind.Local).AddTicks(8400), "orchestrate one-to-one paradigms" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 86,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 66, 36.72977840935645m, new DateTime(2018, 11, 26, 4, 37, 55, 860, DateTimeKind.Local).AddTicks(7312), "engineer enterprise deliverables" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 87,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 90, 7.6390102126277985m, new DateTime(2019, 7, 5, 2, 13, 1, 335, DateTimeKind.Local).AddTicks(4875), "aggregate leading-edge initiatives" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 88,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 81, 92.224620493422580m, new DateTime(2015, 1, 15, 20, 28, 43, 131, DateTimeKind.Local).AddTicks(4618), "envisioneer world-class applications" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 89,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 27, 70.906194160631435m, new DateTime(2022, 8, 11, 10, 37, 52, 10, DateTimeKind.Local).AddTicks(6521), "implement mission-critical synergies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 90,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 69, 68.484221928046845m, new DateTime(2018, 5, 14, 3, 29, 56, 410, DateTimeKind.Local).AddTicks(5854), "deploy turn-key architectures" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 91,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 1, 22.384118139324370m, new DateTime(2023, 7, 22, 23, 49, 28, 156, DateTimeKind.Local).AddTicks(772), "benchmark ubiquitous methodologies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 92,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 73, 59.733761191810990m, new DateTime(2021, 3, 8, 12, 6, 34, 644, DateTimeKind.Local).AddTicks(6902), "expedite sexy interfaces" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 93,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 72, 90.457665080398155m, new DateTime(2015, 7, 3, 8, 36, 9, 196, DateTimeKind.Local).AddTicks(4648), "grow impactful synergies" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 94,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 100, 37.132701996032265m, new DateTime(2021, 2, 21, 14, 51, 4, 315, DateTimeKind.Local).AddTicks(5208), "leverage scalable architectures" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 95,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 100, 29.615689051181375m, new DateTime(2020, 7, 11, 13, 46, 57, 883, DateTimeKind.Local).AddTicks(9281), "synergize back-end web services" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 96,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 22, 27.427251805660375m, new DateTime(2020, 3, 31, 7, 6, 6, 641, DateTimeKind.Local).AddTicks(6366), "whiteboard revolutionary metrics" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 97,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 48, 59.115475826742210m, new DateTime(2014, 7, 6, 18, 54, 1, 322, DateTimeKind.Local).AddTicks(8996), "incubate next-generation interfaces" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 98,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 18, 17.000586731085720m, new DateTime(2014, 10, 17, 3, 37, 55, 601, DateTimeKind.Local).AddTicks(9452), "iterate holistic communities" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 99,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 81, 49.252794253192735m, new DateTime(2020, 10, 7, 8, 38, 4, 719, DateTimeKind.Local).AddTicks(7849), "engage integrated relationships" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 100,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 44, 6.5682432309173285m, new DateTime(2019, 2, 18, 9, 28, 22, 161, DateTimeKind.Local).AddTicks(9034), "repurpose revolutionary bandwidth" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Jaleel", "Flatley", new DateTime(2024, 3, 15, 1, 32, 1, 436, DateTimeKind.Local).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Maddison", "Ullrich", new DateTime(2024, 3, 5, 12, 21, 31, 194, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Henderson", "Reinger", new DateTime(2024, 3, 14, 7, 59, 42, 302, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Hortense", "Adams", new DateTime(2024, 2, 27, 10, 27, 49, 259, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Catalina", "Lind", new DateTime(2024, 3, 11, 18, 3, 59, 959, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Katharina", "Rowe", new DateTime(2024, 2, 26, 17, 15, 3, 992, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Terrance", "Kshlerin", new DateTime(2024, 3, 14, 1, 30, 36, 30, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 8,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Adrien", "Reynolds", new DateTime(2024, 3, 20, 6, 28, 51, 413, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Brianne", "Kuhn", new DateTime(2024, 3, 4, 0, 36, 45, 158, DateTimeKind.Local).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Chloe", "Zboncak", new DateTime(2024, 3, 1, 13, 49, 29, 252, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 11,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Vicenta", "Littel", new DateTime(2024, 2, 29, 19, 9, 42, 952, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 12,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Porter", "Lindgren", new DateTime(2024, 2, 25, 10, 33, 42, 873, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 13,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Joanie", "Lesch", new DateTime(2024, 2, 24, 18, 5, 55, 65, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 14,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Alden", "Bernhard", new DateTime(2024, 2, 22, 6, 25, 51, 744, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 15,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Freida", "Champlin", new DateTime(2024, 3, 10, 6, 57, 6, 466, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 16,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Mabelle", "Hackett", new DateTime(2024, 2, 21, 23, 26, 4, 768, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 17,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Lina", "Bednar", new DateTime(2024, 3, 21, 9, 35, 2, 658, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 18,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Maude", "Durgan", new DateTime(2024, 3, 22, 7, 0, 22, 113, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 19,
                columns: new[] { "FirstName", "LastUpdated" },
                values: new object[] { "Keon", new DateTime(2024, 3, 20, 10, 41, 24, 635, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 20,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Robyn", "Hand", new DateTime(2024, 3, 18, 0, 55, 41, 569, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 21,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Estelle", "Langosh", new DateTime(2024, 3, 4, 9, 26, 49, 658, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 22,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Leonie", "Kertzmann", new DateTime(2024, 2, 29, 2, 17, 30, 4, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 23,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Ulices", "Reinger", new DateTime(2024, 3, 18, 22, 9, 26, 719, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 24,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Milan", "Gusikowski", new DateTime(2024, 3, 17, 23, 26, 41, 807, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 25,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Cassidy", "Purdy", new DateTime(2024, 2, 25, 18, 26, 45, 672, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 26,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Frederique", "Rolfson", new DateTime(2024, 2, 26, 17, 12, 3, 737, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 27,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Mary", "Mosciski", new DateTime(2024, 2, 29, 11, 55, 54, 950, DateTimeKind.Local).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 28,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Ken", "Bergstrom", new DateTime(2024, 2, 26, 23, 35, 44, 168, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 29,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Ashtyn", "Zemlak", new DateTime(2024, 3, 1, 21, 47, 44, 164, DateTimeKind.Local).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 30,
                columns: new[] { "FirstName", "LastUpdated" },
                values: new object[] { "Rico", new DateTime(2024, 3, 18, 22, 24, 59, 747, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 31,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Orval", "Howell", new DateTime(2024, 3, 7, 8, 49, 20, 903, DateTimeKind.Local).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 32,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Camille", "Wuckert", new DateTime(2024, 3, 2, 7, 20, 22, 437, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 33,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Sunny", "Rutherford", new DateTime(2024, 3, 2, 9, 44, 26, 273, DateTimeKind.Local).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 34,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Chris", "Franecki", new DateTime(2024, 3, 6, 4, 4, 40, 309, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 35,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Else", "Hodkiewicz", new DateTime(2024, 3, 9, 7, 49, 30, 523, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 36,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Candido", "Boehm", new DateTime(2024, 3, 12, 6, 48, 9, 899, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 37,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Linda", "Senger", new DateTime(2024, 3, 21, 4, 58, 56, 419, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 38,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Doug", "Veum", new DateTime(2024, 3, 21, 13, 53, 52, 913, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 39,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Amy", "Morar", new DateTime(2024, 3, 22, 15, 56, 18, 824, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 40,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Muriel", "O'Reilly", new DateTime(2024, 3, 11, 15, 47, 4, 487, DateTimeKind.Local).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 41,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Dana", "Bergnaum", new DateTime(2024, 3, 14, 10, 20, 5, 831, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 42,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Kiana", "Hegmann", new DateTime(2024, 3, 3, 9, 49, 0, 493, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 43,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Maribel", "Wolff", new DateTime(2024, 3, 11, 22, 1, 56, 461, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 44,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Vickie", "Gerhold", new DateTime(2024, 2, 22, 7, 52, 54, 324, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 45,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Jaiden", "Auer", new DateTime(2024, 3, 20, 0, 43, 13, 36, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 46,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Sasha", "Langworth", new DateTime(2024, 2, 24, 21, 46, 56, 762, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 47,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Reed", "Kiehn", new DateTime(2024, 3, 8, 14, 44, 25, 2, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 48,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Remington", "Batz", new DateTime(2024, 2, 24, 3, 4, 13, 70, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 49,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Jennifer", "Cole", new DateTime(2024, 3, 14, 13, 36, 34, 268, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 50,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Chelsea", "Rempel", new DateTime(2024, 3, 3, 7, 37, 45, 298, DateTimeKind.Local).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 51,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Lauretta", "Kris", new DateTime(2024, 3, 1, 8, 54, 37, 998, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 52,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Celestino", "Rippin", new DateTime(2024, 2, 26, 11, 28, 32, 783, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 53,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Janis", "Hagenes", new DateTime(2024, 3, 19, 14, 45, 42, 646, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 54,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Amelie", "Dooley", new DateTime(2024, 3, 10, 20, 0, 5, 215, DateTimeKind.Local).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 55,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Valentin", "Dibbert", new DateTime(2024, 3, 8, 3, 23, 58, 629, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 56,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Felton", "Koelpin", new DateTime(2024, 3, 8, 17, 45, 39, 330, DateTimeKind.Local).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 57,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Leonel", "Dietrich", new DateTime(2024, 3, 3, 13, 8, 31, 111, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 58,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Raven", "Lakin", new DateTime(2024, 3, 7, 22, 38, 6, 838, DateTimeKind.Local).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 59,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Mattie", "Beatty", new DateTime(2024, 3, 15, 11, 51, 30, 60, DateTimeKind.Local).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 60,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Kenna", "Walter", new DateTime(2024, 3, 21, 4, 52, 36, 952, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 61,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Rex", "Brown", new DateTime(2024, 3, 8, 12, 0, 13, 737, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 62,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Reyna", "Kreiger", new DateTime(2024, 3, 12, 9, 20, 56, 251, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 63,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Casimir", "Larson", new DateTime(2024, 3, 16, 11, 28, 41, 503, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 64,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Elian", "Veum", new DateTime(2024, 2, 29, 19, 0, 5, 846, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 65,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Sophia", "Emard", new DateTime(2024, 3, 18, 8, 10, 52, 368, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 66,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Althea", "Goyette", new DateTime(2024, 2, 29, 10, 9, 35, 680, DateTimeKind.Local).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 67,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Brooks", "Williamson", new DateTime(2024, 3, 15, 3, 28, 56, 235, DateTimeKind.Local).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 68,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Alphonso", "Ritchie", new DateTime(2024, 3, 7, 15, 14, 24, 538, DateTimeKind.Local).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 69,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Theresia", "Macejkovic", new DateTime(2024, 3, 10, 4, 6, 38, 912, DateTimeKind.Local).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 70,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Virgie", "Pfannerstill", new DateTime(2024, 3, 13, 21, 36, 12, 389, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 71,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Rachael", "Bednar", new DateTime(2024, 2, 27, 18, 13, 17, 262, DateTimeKind.Local).AddTicks(3835) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 72,
                columns: new[] { "FirstName", "LastUpdated" },
                values: new object[] { "Orie", new DateTime(2024, 3, 21, 16, 46, 58, 162, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 73,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Maximilian", "Bednar", new DateTime(2024, 3, 9, 5, 56, 35, 566, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 74,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Mertie", "Larson", new DateTime(2024, 2, 27, 21, 44, 1, 7, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 75,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Clarissa", "Smith", new DateTime(2024, 3, 3, 12, 6, 18, 773, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 76,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Glen", "Hane", new DateTime(2024, 2, 26, 1, 30, 4, 468, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 77,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Kattie", "Roob", new DateTime(2024, 3, 19, 0, 41, 36, 78, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 78,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Lauren", "Nienow", new DateTime(2024, 3, 6, 21, 23, 23, 733, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 79,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Annetta", "Bogan", new DateTime(2024, 2, 24, 5, 17, 49, 889, DateTimeKind.Local).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 80,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Katharina", "McLaughlin", new DateTime(2024, 2, 25, 21, 21, 9, 489, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 81,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Maci", "Gaylord", new DateTime(2024, 3, 5, 11, 39, 42, 578, DateTimeKind.Local).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 82,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Jairo", "O'Hara", new DateTime(2024, 2, 26, 1, 33, 46, 755, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 83,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Cheyenne", "Berge", new DateTime(2024, 2, 23, 4, 42, 55, 813, DateTimeKind.Local).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 84,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Walker", "Denesik", new DateTime(2024, 3, 22, 6, 59, 49, 661, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 85,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Nikita", "Koepp", new DateTime(2024, 3, 10, 4, 24, 58, 793, DateTimeKind.Local).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 86,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Harold", "Rolfson", new DateTime(2024, 3, 17, 20, 25, 24, 926, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 87,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Ethel", "Herzog", new DateTime(2024, 3, 22, 14, 31, 17, 816, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 88,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Lilla", "O'Keefe", new DateTime(2024, 2, 29, 2, 9, 42, 309, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 89,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Madie", "Zieme", new DateTime(2024, 3, 4, 4, 23, 19, 572, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 90,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Trevor", "Heidenreich", new DateTime(2024, 3, 16, 8, 30, 27, 193, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 91,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Hulda", "Yost", new DateTime(2024, 2, 23, 13, 13, 6, 981, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 92,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Sidney", "Hudson", new DateTime(2024, 3, 2, 6, 56, 33, 573, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 93,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Kiel", "Green", new DateTime(2024, 3, 20, 8, 1, 19, 378, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 94,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Ulises", "Langworth", new DateTime(2024, 3, 20, 2, 23, 21, 209, DateTimeKind.Local).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 95,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Owen", "Schamberger", new DateTime(2024, 2, 29, 5, 27, 41, 603, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 96,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Randall", "Murphy", new DateTime(2024, 3, 15, 8, 56, 25, 718, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 97,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Larue", "Moen", new DateTime(2024, 3, 5, 5, 51, 6, 631, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 98,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Adam", "Haag", new DateTime(2024, 3, 2, 14, 45, 56, 235, DateTimeKind.Local).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 99,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Jeffery", "Jones", new DateTime(2024, 3, 2, 2, 20, 49, 747, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 100,
                columns: new[] { "FirstName", "LastName", "LastUpdated" },
                values: new object[] { "Deborah", "Rowe", new DateTime(2024, 2, 28, 10, 28, 18, 218, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 8, 60.192063938802985m, new DateTime(2021, 11, 5, 15, 7, 14, 637, DateTimeKind.Local).AddTicks(4531), "Tempore culpa omnis nobis totam et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 17, 30.983346839972530m, new DateTime(2021, 4, 7, 7, 5, 25, 690, DateTimeKind.Local).AddTicks(4798), "Omnis nulla qui eligendi debitis voluptatem et quasi et sint." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 39, 67.82730199103945m, new DateTime(2021, 10, 1, 11, 57, 48, 593, DateTimeKind.Local).AddTicks(6690), "Non voluptas quas sed non enim minus consequatur qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 86, 37.151577397568260m, new DateTime(2019, 12, 11, 0, 14, 13, 616, DateTimeKind.Local).AddTicks(9831), "Aut deserunt alias laboriosam ea ut necessitatibus et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 34, 92.619498786528190m, new DateTime(2023, 11, 16, 15, 23, 35, 196, DateTimeKind.Local).AddTicks(7964), "Aliquam labore ab voluptas iste ducimus magnam ipsa." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 90, 45.862103016763130m, new DateTime(2021, 5, 13, 8, 52, 22, 552, DateTimeKind.Local).AddTicks(8817), "Error cumque aspernatur." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 78, 17.357348145412885m, new DateTime(2021, 10, 26, 5, 51, 57, 943, DateTimeKind.Local).AddTicks(9119), "Dolor qui molestiae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 77, 24.301045564623180m, new DateTime(2014, 12, 29, 9, 11, 42, 516, DateTimeKind.Local).AddTicks(9083), "Corporis enim ut vitae et saepe similique omnis et inventore." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 85, 35.932385586804840m, new DateTime(2023, 12, 25, 23, 38, 6, 823, DateTimeKind.Local).AddTicks(3193), "Ullam eos rerum unde sed aut incidunt voluptas voluptates rerum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 37, 6.3056529867507885m, new DateTime(2018, 10, 2, 17, 46, 56, 237, DateTimeKind.Local).AddTicks(1611), "Enim quod sed qui accusantium numquam non quia asperiores accusantium." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 19, 51.256338890757660m, new DateTime(2016, 9, 23, 2, 6, 36, 717, DateTimeKind.Local).AddTicks(8912), "Atque unde labore dolorem sequi id ullam sed blanditiis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 66, 75.463023991775075m, new DateTime(2015, 5, 26, 15, 53, 8, 652, DateTimeKind.Local).AddTicks(1059), "Omnis et et tempore et hic sed debitis enim." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13,
                columns: new[] { "BasePrice", "PublishDate", "Title" },
                values: new object[] { 67.66494846455025m, new DateTime(2023, 9, 29, 9, 15, 2, 613, DateTimeKind.Local).AddTicks(7505), "Reprehenderit eos ut debitis dolorem laudantium et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 44, 26.256242388630020m, new DateTime(2020, 1, 2, 15, 57, 57, 754, DateTimeKind.Local).AddTicks(8965), "Quis veritatis reprehenderit qui illum ea ratione ad et id." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 34, 12.9534560567910845m, new DateTime(2019, 1, 21, 6, 33, 44, 21, DateTimeKind.Local).AddTicks(1796), "Quas aperiam voluptatem eius velit ea fugiat molestiae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 68, 14.3525690559643665m, new DateTime(2014, 9, 11, 13, 33, 31, 547, DateTimeKind.Local).AddTicks(4482), "Et et tenetur optio eos perspiciatis ut consequuntur assumenda." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 15, 81.001019432217370m, new DateTime(2023, 9, 22, 22, 56, 23, 343, DateTimeKind.Local).AddTicks(2317), "Ea consequatur id aperiam harum cumque corrupti." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 29, 36.53750217704980m, new DateTime(2018, 2, 28, 14, 44, 35, 72, DateTimeKind.Local).AddTicks(1211), "Quis cupiditate quam accusantium delectus officia sunt a." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 61, 80.489032380024110m, new DateTime(2022, 8, 31, 10, 14, 29, 679, DateTimeKind.Local).AddTicks(9311), "Perferendis est sed fugit deleniti consequatur eos sapiente delectus culpa." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 23, 10.5647021612649995m, new DateTime(2017, 12, 11, 9, 16, 25, 430, DateTimeKind.Local).AddTicks(3237), "Autem qui quae dolorem dicta quibusdam libero dignissimos ut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 73, 89.371684757958145m, new DateTime(2020, 12, 9, 5, 52, 10, 971, DateTimeKind.Local).AddTicks(5735), "Rerum quod omnis fugit suscipit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 100, 81.415570419897570m, new DateTime(2022, 11, 9, 10, 44, 43, 274, DateTimeKind.Local).AddTicks(5454), "Totam voluptatibus quis similique ratione possimus et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 10, 19.333040735055670m, new DateTime(2023, 12, 2, 16, 25, 50, 866, DateTimeKind.Local).AddTicks(425), "Dolores nihil esse aut beatae repellat qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 24,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 26, 41.338005326589035m, new DateTime(2016, 5, 19, 14, 48, 16, 842, DateTimeKind.Local).AddTicks(3448), "Aut error optio non." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 25,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 1, 63.874259302207905m, new DateTime(2015, 4, 14, 5, 18, 7, 347, DateTimeKind.Local).AddTicks(8529), "Quisquam modi veniam sint magni eaque dolores est." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 26,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 87, 86.901495802680270m, new DateTime(2014, 8, 20, 9, 9, 37, 86, DateTimeKind.Local).AddTicks(8998), "Est in nesciunt maiores iusto impedit harum optio non." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 93, 38.13938168121040m, new DateTime(2022, 10, 13, 9, 1, 7, 344, DateTimeKind.Local).AddTicks(7717), "Vero tempora culpa." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 27, 21.854135111362225m, new DateTime(2023, 11, 15, 14, 1, 18, 424, DateTimeKind.Local).AddTicks(4784), "Sit similique impedit quam qui error minus dolores et sed." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 29,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 45, 31.27549025961335m, new DateTime(2016, 4, 30, 9, 17, 13, 831, DateTimeKind.Local).AddTicks(6830), "Eos nam sint eligendi molestias voluptatem fugiat iure aut ipsum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 30,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 92, 65.028405255689360m, new DateTime(2020, 11, 12, 13, 48, 36, 62, DateTimeKind.Local).AddTicks(4244), "Veniam perspiciatis architecto." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 31,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 100, 52.474470143723245m, new DateTime(2020, 4, 23, 5, 20, 55, 495, DateTimeKind.Local).AddTicks(1828), "Fugit nobis aspernatur quidem omnis quo et non explicabo." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 32,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 63, 17.023719719979470m, new DateTime(2019, 7, 25, 7, 27, 19, 655, DateTimeKind.Local).AddTicks(1221), "Voluptas doloremque omnis veritatis a blanditiis consequatur voluptate pariatur." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 33,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 63, 96.988629494356645m, new DateTime(2015, 4, 27, 4, 34, 48, 376, DateTimeKind.Local).AddTicks(8572), "Cupiditate laudantium excepturi eius dolores dolorem illum eos facere consectetur." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 34,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 82, 96.324809735618590m, new DateTime(2017, 4, 28, 23, 18, 34, 392, DateTimeKind.Local).AddTicks(9919), "Atque rerum tempora aut provident odio." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 35,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 36, 77.829371661103020m, new DateTime(2016, 1, 29, 23, 38, 36, 635, DateTimeKind.Local).AddTicks(7883), "Ipsa vel id velit laborum quod sequi cum aut cum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 36,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 86, 86.982556548766880m, new DateTime(2019, 12, 5, 22, 13, 5, 648, DateTimeKind.Local).AddTicks(3922), "Temporibus esse eum sit et cumque aut et non nihil." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 37,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 16, 26.982894059160175m, new DateTime(2016, 5, 18, 17, 41, 3, 842, DateTimeKind.Local).AddTicks(4690), "Saepe odit dolorem tempore amet quo ipsam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 38,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 27, 11.8101963628995510m, new DateTime(2022, 12, 2, 6, 14, 7, 591, DateTimeKind.Local).AddTicks(1461), "Dolore aut ab." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 39,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 72, 37.634007415624835m, new DateTime(2023, 8, 25, 4, 37, 1, 197, DateTimeKind.Local).AddTicks(6675), "Aliquam tempora cum quisquam illum qui nostrum doloremque nihil." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 40,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 38, 98.805060221864490m, new DateTime(2014, 10, 3, 16, 54, 30, 505, DateTimeKind.Local).AddTicks(9185), "Quo enim laborum et quisquam repellendus sed vero natus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 41,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 21, 59.329609015700785m, new DateTime(2016, 4, 25, 10, 27, 33, 789, DateTimeKind.Local).AddTicks(4722), "Temporibus quos necessitatibus culpa ipsa omnis corporis occaecati quo beatae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 42,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 24, 32.374847019052125m, new DateTime(2020, 3, 29, 10, 1, 35, 945, DateTimeKind.Local).AddTicks(5772), "Modi tempora praesentium." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 43,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 77, 31.41168940435435m, new DateTime(2014, 11, 9, 16, 48, 37, 156, DateTimeKind.Local).AddTicks(2585), "Aut cumque ut velit rerum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 44,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 70, 25.15574508766455m, new DateTime(2017, 7, 16, 17, 50, 49, 969, DateTimeKind.Local).AddTicks(5705), "Est est tempore ut odio aut qui quidem recusandae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 45,
                columns: new[] { "BasePrice", "PublishDate", "Title" },
                values: new object[] { 55.046249564349440m, new DateTime(2021, 8, 14, 5, 31, 42, 699, DateTimeKind.Local).AddTicks(1975), "Natus vel eos minus est excepturi molestiae placeat accusamus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 46,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 99, 14.519462197441755m, new DateTime(2024, 3, 1, 13, 22, 57, 407, DateTimeKind.Local).AddTicks(4112), "Impedit voluptatibus sunt dolor distinctio suscipit id soluta." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 47,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 95, 77.134246454035880m, new DateTime(2022, 10, 15, 13, 4, 24, 860, DateTimeKind.Local).AddTicks(2414), "Veritatis sapiente ratione at ipsam possimus et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 48,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 61, 28.67094212083375m, new DateTime(2021, 6, 19, 16, 53, 49, 996, DateTimeKind.Local).AddTicks(599), "Quasi consequatur vel eos dolorem autem sunt fugiat." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 49,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 16, 80.1357607149410m, new DateTime(2023, 2, 27, 9, 9, 8, 18, DateTimeKind.Local).AddTicks(3377), "Mollitia recusandae sunt eum et quis cumque repellendus voluptatum et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 50,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 87, 79.276761432343180m, new DateTime(2021, 10, 10, 23, 16, 44, 461, DateTimeKind.Local).AddTicks(1970), "Magni sapiente aut ex." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 51,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 63, 56.301924163850875m, new DateTime(2016, 4, 2, 15, 13, 19, 953, DateTimeKind.Local).AddTicks(994), "Exercitationem neque libero culpa nostrum eum consequatur." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 52,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 49, 22.12074736595385m, new DateTime(2019, 3, 2, 16, 6, 57, 281, DateTimeKind.Local).AddTicks(5429), "Ab eos qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 53,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 69, 76.994776863138455m, new DateTime(2023, 1, 21, 21, 26, 14, 666, DateTimeKind.Local).AddTicks(1111), "Incidunt sequi omnis sit in magnam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 54,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 75, 24.452152118957375m, new DateTime(2023, 7, 10, 18, 24, 27, 725, DateTimeKind.Local).AddTicks(2213), "Ipsam velit dolor dolorem sed ipsum nesciunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 55,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 67, 6.5566309525189040m, new DateTime(2022, 7, 1, 14, 33, 46, 363, DateTimeKind.Local).AddTicks(8391), "Suscipit impedit ullam repudiandae eaque deserunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 56,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 97, 13.197798179303875m, new DateTime(2014, 6, 12, 7, 52, 51, 200, DateTimeKind.Local).AddTicks(4176), "Quibusdam adipisci vel aut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 57,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 98, 45.237365851370640m, new DateTime(2016, 2, 21, 23, 14, 47, 630, DateTimeKind.Local).AddTicks(1038), "Quos quidem similique consequatur quidem quasi sed neque esse." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 58,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 99, 43.257195101035m, new DateTime(2020, 5, 10, 20, 46, 16, 272, DateTimeKind.Local).AddTicks(3127), "Sint autem nisi labore." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 59,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 15, 11.7129534375112010m, new DateTime(2017, 8, 12, 0, 34, 47, 812, DateTimeKind.Local).AddTicks(4312), "Nesciunt minus maiores laborum rerum commodi." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 60,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 66, 27.592712292339930m, new DateTime(2019, 9, 8, 12, 16, 7, 538, DateTimeKind.Local).AddTicks(2088), "Labore quia aperiam non totam rerum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 61,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 39, 94.814762698232990m, new DateTime(2015, 6, 11, 9, 20, 51, 270, DateTimeKind.Local).AddTicks(8582), "Cumque non illum nihil est dolor vel." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 62,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 86, 11.4754943957895885m, new DateTime(2020, 12, 29, 15, 55, 16, 604, DateTimeKind.Local).AddTicks(1822), "Voluptatem sapiente saepe." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 63,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 25, 97.473347980047555m, new DateTime(2019, 7, 18, 6, 55, 28, 854, DateTimeKind.Local).AddTicks(4659), "Voluptatem aspernatur similique ea beatae aut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 64,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 67, 86.697323430428890m, new DateTime(2022, 5, 4, 15, 24, 38, 687, DateTimeKind.Local).AddTicks(900), "Cum mollitia ullam ad enim id aperiam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 65,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 15, 95.395414584588340m, new DateTime(2016, 5, 31, 18, 8, 40, 540, DateTimeKind.Local).AddTicks(409), "Sapiente perspiciatis nesciunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 66,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 7, 11.0846911385844020m, new DateTime(2018, 2, 22, 21, 4, 29, 552, DateTimeKind.Local).AddTicks(5120), "Quia voluptatem voluptatem aut fugiat et autem debitis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 67,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 2, 40.489241350028275m, new DateTime(2014, 7, 17, 8, 44, 37, 111, DateTimeKind.Local).AddTicks(2345), "Nihil error excepturi tempora numquam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 68,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 34, 78.839882953549990m, new DateTime(2015, 11, 6, 20, 14, 49, 911, DateTimeKind.Local).AddTicks(4605), "Laudantium consequatur reprehenderit eveniet eos nihil cupiditate et blanditiis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 69,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 20, 95.762406482778595m, new DateTime(2019, 8, 4, 5, 9, 11, 199, DateTimeKind.Local).AddTicks(7791), "Iure aut et voluptas omnis cumque officiis nam error facere." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 70,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 86, 54.450413356821070m, new DateTime(2018, 2, 14, 7, 31, 39, 861, DateTimeKind.Local).AddTicks(1506), "Expedita voluptatem recusandae ducimus assumenda quo at rerum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 71,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 67, 49.823521951373675m, new DateTime(2015, 4, 28, 14, 30, 53, 380, DateTimeKind.Local).AddTicks(500), "Qui fugit animi eos sint molestiae deserunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 72,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 92, 5.10974530373134195m, new DateTime(2015, 4, 16, 19, 27, 53, 712, DateTimeKind.Local).AddTicks(4413), "Iusto non quia qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 73,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 51, 24.961735898668510m, new DateTime(2017, 10, 13, 4, 31, 52, 604, DateTimeKind.Local).AddTicks(556), "Quia eligendi labore voluptatem molestiae nesciunt quam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 74,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 99, 64.203448066560115m, new DateTime(2016, 2, 12, 2, 44, 1, 387, DateTimeKind.Local).AddTicks(5200), "Cupiditate eius molestiae aspernatur aut fuga sint." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 75,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 85, 86.659630156233110m, new DateTime(2014, 9, 22, 20, 12, 19, 588, DateTimeKind.Local).AddTicks(9841), "Aut iusto est ipsum voluptates assumenda qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 76,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 91, 98.167884948644765m, new DateTime(2020, 6, 22, 5, 48, 28, 306, DateTimeKind.Local).AddTicks(7600), "Voluptates quibusdam dicta omnis debitis explicabo eum non fuga." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 77,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 65, 58.176098836895470m, new DateTime(2015, 3, 3, 16, 20, 53, 428, DateTimeKind.Local).AddTicks(1497), "Vel corporis aliquid non ullam fugiat et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 78,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 51, 37.755040603206955m, new DateTime(2020, 10, 4, 13, 6, 10, 545, DateTimeKind.Local).AddTicks(9348), "Dolorum ut qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 79,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 17, 36.644487011633535m, new DateTime(2021, 10, 21, 6, 29, 11, 3, DateTimeKind.Local).AddTicks(3831), "Quod iure iste." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 80,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 73, 61.074007084713220m, new DateTime(2021, 9, 28, 12, 3, 19, 25, DateTimeKind.Local).AddTicks(9633), "Et vel voluptatibus soluta sed doloremque rem ut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 81,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 74, 77.897019753094340m, new DateTime(2022, 2, 20, 19, 57, 19, 30, DateTimeKind.Local).AddTicks(4758), "A voluptatibus tenetur est placeat minima." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 82,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 82, 24.188931535104310m, new DateTime(2022, 8, 2, 15, 2, 39, 708, DateTimeKind.Local).AddTicks(8392), "Nostrum temporibus dolores in." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 83,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 66, 36.907616303626160m, new DateTime(2014, 12, 17, 12, 36, 3, 418, DateTimeKind.Local).AddTicks(6056), "Minus sit sunt dolore eveniet sit et excepturi labore." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 84,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 81, 6.6369687971062915m, new DateTime(2022, 9, 29, 7, 54, 9, 821, DateTimeKind.Local).AddTicks(7178), "Ratione pariatur eos in dolor aliquid ut voluptate rerum qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 85,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 93, 40.189333528170135m, new DateTime(2015, 2, 15, 20, 43, 57, 359, DateTimeKind.Local).AddTicks(8265), "Recusandae esse ipsam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 86,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 99, 92.351486463045820m, new DateTime(2020, 6, 22, 18, 57, 48, 273, DateTimeKind.Local).AddTicks(1821), "Ut nesciunt rerum deserunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 87,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 45, 87.468794254813310m, new DateTime(2024, 2, 13, 4, 21, 9, 632, DateTimeKind.Local).AddTicks(8762), "Quod ipsum assumenda aspernatur eum eveniet." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 88,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 99, 24.616409000725735m, new DateTime(2020, 1, 25, 16, 27, 39, 431, DateTimeKind.Local).AddTicks(4584), "Incidunt voluptates vitae assumenda velit id pariatur est." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 89,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 80, 71.946224122653825m, new DateTime(2014, 7, 30, 11, 15, 43, 410, DateTimeKind.Local).AddTicks(8080), "Voluptate eaque illo ipsam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 90,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 42, 93.154485182125065m, new DateTime(2014, 9, 30, 3, 20, 18, 907, DateTimeKind.Local).AddTicks(1050), "Nisi voluptatibus deleniti." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 91,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 84, 19.747954411026185m, new DateTime(2024, 3, 20, 7, 34, 14, 285, DateTimeKind.Local).AddTicks(3959), "Commodi quis esse provident facere commodi quis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 92,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 44, 21.705391995666730m, new DateTime(2018, 12, 4, 8, 8, 59, 354, DateTimeKind.Local).AddTicks(8938), "Suscipit nihil temporibus excepturi corporis modi rerum veritatis nulla qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 93,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 31, 9.1390206145931360m, new DateTime(2022, 4, 14, 20, 24, 49, 694, DateTimeKind.Local).AddTicks(1660), "Repudiandae qui id placeat ut cupiditate." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 94,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 72, 11.4800666277543780m, new DateTime(2020, 1, 21, 13, 24, 0, 246, DateTimeKind.Local).AddTicks(5011), "Dignissimos voluptatibus ut laboriosam minus quibusdam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 95,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 57, 57.299611298309920m, new DateTime(2022, 8, 14, 1, 27, 5, 271, DateTimeKind.Local).AddTicks(6927), "Excepturi repudiandae nostrum quis quaerat." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 96,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 14, 5.0034907285453161790m, new DateTime(2022, 11, 22, 23, 34, 2, 535, DateTimeKind.Local).AddTicks(8176), "Facilis consequuntur totam voluptatem voluptas quo esse eveniet deserunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 97,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 64, 19.76766971223770m, new DateTime(2019, 8, 11, 7, 24, 6, 972, DateTimeKind.Local).AddTicks(4574), "Eligendi sequi numquam alias occaecati saepe qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 98,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 69, 64.73445403507025m, new DateTime(2019, 1, 16, 1, 37, 5, 682, DateTimeKind.Local).AddTicks(2322), "Cum sed iure enim inventore iure." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 99,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 49, 64.805713140820630m, new DateTime(2021, 3, 25, 1, 55, 40, 948, DateTimeKind.Local).AddTicks(8498), "Sit perferendis sapiente dolore ut eos commodi." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 100,
                columns: new[] { "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 50, 5.25867430008654190m, new DateTime(2021, 2, 22, 21, 23, 2, 361, DateTimeKind.Local).AddTicks(4758), "Dolores sint dolorem et dolorem qui quia sint." });
        }
    }
}
