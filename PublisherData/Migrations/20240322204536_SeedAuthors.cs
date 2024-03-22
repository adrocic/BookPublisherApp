using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PublisherData.Migrations
{
    public partial class SeedAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "FirstName", "LastName", "LastUpdated" },
                values: new object[,]
                {
                    { 1, "Johnson", "Schmeler", new DateTime(2024, 3, 11, 7, 21, 32, 611, DateTimeKind.Local).AddTicks(2499) },
                    { 2, "Maud", "Walter", new DateTime(2024, 3, 17, 7, 58, 38, 265, DateTimeKind.Local).AddTicks(6889) },
                    { 3, "Xander", "Roob", new DateTime(2024, 2, 22, 10, 12, 12, 622, DateTimeKind.Local).AddTicks(1364) },
                    { 4, "Moses", "Will", new DateTime(2024, 3, 13, 5, 29, 12, 822, DateTimeKind.Local).AddTicks(3226) },
                    { 5, "Rudolph", "Hayes", new DateTime(2024, 2, 23, 15, 49, 14, 920, DateTimeKind.Local).AddTicks(3031) },
                    { 6, "Harry", "Jakubowski", new DateTime(2024, 3, 14, 20, 21, 41, 736, DateTimeKind.Local).AddTicks(7347) },
                    { 7, "Kenya", "Stokes", new DateTime(2024, 3, 20, 18, 22, 56, 592, DateTimeKind.Local).AddTicks(4639) },
                    { 8, "Elwyn", "Kub", new DateTime(2024, 3, 10, 7, 11, 18, 857, DateTimeKind.Local).AddTicks(6687) },
                    { 9, "Zora", "Beier", new DateTime(2024, 3, 13, 10, 57, 43, 895, DateTimeKind.Local).AddTicks(7482) },
                    { 10, "Terrence", "Ward", new DateTime(2024, 3, 6, 8, 38, 58, 513, DateTimeKind.Local).AddTicks(6867) },
                    { 11, "Hazle", "Bartell", new DateTime(2024, 3, 21, 9, 20, 0, 823, DateTimeKind.Local).AddTicks(3238) },
                    { 12, "Berenice", "Lesch", new DateTime(2024, 3, 7, 2, 36, 54, 655, DateTimeKind.Local).AddTicks(8914) },
                    { 13, "Clement", "Harvey", new DateTime(2024, 2, 22, 1, 59, 58, 553, DateTimeKind.Local).AddTicks(7026) },
                    { 14, "Kaela", "Larkin", new DateTime(2024, 3, 20, 4, 45, 9, 957, DateTimeKind.Local).AddTicks(6783) },
                    { 15, "Stanford", "Roberts", new DateTime(2024, 2, 23, 2, 39, 38, 793, DateTimeKind.Local).AddTicks(7028) },
                    { 16, "Reva", "Beatty", new DateTime(2024, 2, 23, 14, 27, 58, 222, DateTimeKind.Local).AddTicks(934) },
                    { 17, "Lois", "Reilly", new DateTime(2024, 3, 11, 13, 50, 29, 482, DateTimeKind.Local).AddTicks(2182) },
                    { 18, "Keeley", "Leuschke", new DateTime(2024, 3, 8, 2, 17, 49, 642, DateTimeKind.Local).AddTicks(429) },
                    { 19, "Verla", "D'Amore", new DateTime(2024, 3, 9, 14, 58, 36, 727, DateTimeKind.Local).AddTicks(2539) },
                    { 20, "Enid", "Hoeger", new DateTime(2024, 2, 25, 19, 21, 9, 478, DateTimeKind.Local).AddTicks(9698) },
                    { 21, "Myah", "Walker", new DateTime(2024, 3, 16, 11, 39, 33, 582, DateTimeKind.Local).AddTicks(7954) },
                    { 22, "Clinton", "Schowalter", new DateTime(2024, 3, 6, 10, 3, 30, 395, DateTimeKind.Local).AddTicks(1542) },
                    { 23, "Garett", "Labadie", new DateTime(2024, 3, 11, 20, 39, 31, 62, DateTimeKind.Local).AddTicks(4424) },
                    { 24, "Josie", "Conn", new DateTime(2024, 3, 10, 21, 38, 30, 344, DateTimeKind.Local).AddTicks(5122) },
                    { 25, "Maximillia", "Kassulke", new DateTime(2024, 3, 1, 10, 24, 21, 343, DateTimeKind.Local).AddTicks(5895) },
                    { 26, "Billy", "Zboncak", new DateTime(2024, 3, 2, 10, 32, 30, 386, DateTimeKind.Local).AddTicks(7669) },
                    { 27, "Syble", "Towne", new DateTime(2024, 3, 7, 14, 50, 43, 3, DateTimeKind.Local).AddTicks(9609) },
                    { 28, "Tavares", "Armstrong", new DateTime(2024, 2, 23, 18, 26, 2, 989, DateTimeKind.Local).AddTicks(3382) },
                    { 29, "Dayton", "Moen", new DateTime(2024, 3, 13, 6, 28, 17, 567, DateTimeKind.Local).AddTicks(4150) },
                    { 30, "Norene", "Wolff", new DateTime(2024, 3, 22, 15, 1, 54, 932, DateTimeKind.Local).AddTicks(8625) },
                    { 31, "Mack", "Goldner", new DateTime(2024, 3, 22, 4, 27, 42, 251, DateTimeKind.Local).AddTicks(1917) },
                    { 32, "Hanna", "Howell", new DateTime(2024, 3, 1, 18, 46, 5, 638, DateTimeKind.Local).AddTicks(6993) },
                    { 33, "Rickie", "McCullough", new DateTime(2024, 3, 21, 21, 32, 59, 500, DateTimeKind.Local).AddTicks(3731) },
                    { 34, "Dedric", "Hudson", new DateTime(2024, 3, 6, 5, 33, 2, 901, DateTimeKind.Local).AddTicks(6856) },
                    { 35, "Daryl", "Balistreri", new DateTime(2024, 2, 29, 16, 1, 23, 696, DateTimeKind.Local).AddTicks(7649) },
                    { 36, "Adan", "Miller", new DateTime(2024, 2, 22, 15, 32, 0, 182, DateTimeKind.Local).AddTicks(9905) },
                    { 37, "Maxine", "Lind", new DateTime(2024, 3, 6, 10, 13, 51, 102, DateTimeKind.Local).AddTicks(2516) },
                    { 38, "Devonte", "Herzog", new DateTime(2024, 2, 26, 20, 28, 16, 40, DateTimeKind.Local).AddTicks(8039) },
                    { 39, "Domenic", "Kulas", new DateTime(2024, 2, 27, 1, 32, 39, 486, DateTimeKind.Local).AddTicks(631) },
                    { 40, "Jabari", "Jacobs", new DateTime(2024, 3, 8, 2, 1, 39, 59, DateTimeKind.Local).AddTicks(4637) },
                    { 41, "Sheila", "Will", new DateTime(2024, 3, 12, 10, 41, 56, 148, DateTimeKind.Local).AddTicks(8173) },
                    { 42, "Lydia", "Prosacco", new DateTime(2024, 3, 7, 10, 34, 1, 378, DateTimeKind.Local).AddTicks(2476) }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "FirstName", "LastName", "LastUpdated" },
                values: new object[,]
                {
                    { 43, "Etha", "Hintz", new DateTime(2024, 3, 3, 23, 30, 11, 332, DateTimeKind.Local).AddTicks(6856) },
                    { 44, "Emilia", "Macejkovic", new DateTime(2024, 3, 9, 15, 47, 37, 522, DateTimeKind.Local).AddTicks(3388) },
                    { 45, "Norris", "Cruickshank", new DateTime(2024, 3, 6, 12, 11, 36, 347, DateTimeKind.Local).AddTicks(3723) },
                    { 46, "Deanna", "D'Amore", new DateTime(2024, 3, 22, 12, 13, 45, 474, DateTimeKind.Local).AddTicks(4794) },
                    { 47, "Luther", "Frami", new DateTime(2024, 3, 21, 5, 39, 46, 354, DateTimeKind.Local).AddTicks(3783) },
                    { 48, "Carmine", "Rowe", new DateTime(2024, 3, 21, 16, 43, 6, 264, DateTimeKind.Local).AddTicks(7700) },
                    { 49, "Filiberto", "Frami", new DateTime(2024, 2, 23, 23, 29, 34, 667, DateTimeKind.Local).AddTicks(1533) },
                    { 50, "Shirley", "Abshire", new DateTime(2024, 2, 29, 14, 11, 55, 48, DateTimeKind.Local).AddTicks(8288) },
                    { 51, "Kathlyn", "Fahey", new DateTime(2024, 3, 20, 21, 48, 53, 756, DateTimeKind.Local).AddTicks(2654) },
                    { 52, "Kennedi", "Luettgen", new DateTime(2024, 3, 5, 2, 14, 23, 82, DateTimeKind.Local).AddTicks(4394) },
                    { 53, "Percival", "Murray", new DateTime(2024, 3, 6, 15, 52, 24, 154, DateTimeKind.Local).AddTicks(8694) },
                    { 54, "Deanna", "Bailey", new DateTime(2024, 3, 6, 8, 6, 13, 33, DateTimeKind.Local).AddTicks(4810) },
                    { 55, "Christina", "Leffler", new DateTime(2024, 2, 29, 20, 24, 33, 512, DateTimeKind.Local).AddTicks(5905) },
                    { 56, "Myrtis", "Shanahan", new DateTime(2024, 2, 27, 3, 6, 16, 966, DateTimeKind.Local).AddTicks(4169) },
                    { 57, "Schuyler", "Gorczany", new DateTime(2024, 3, 12, 8, 17, 2, 96, DateTimeKind.Local).AddTicks(688) },
                    { 58, "Cordie", "Schuppe", new DateTime(2024, 2, 23, 20, 12, 57, 603, DateTimeKind.Local).AddTicks(1819) },
                    { 59, "Eldred", "Gulgowski", new DateTime(2024, 3, 20, 3, 4, 38, 72, DateTimeKind.Local).AddTicks(6374) },
                    { 60, "Ofelia", "Schmidt", new DateTime(2024, 3, 14, 8, 27, 37, 21, DateTimeKind.Local).AddTicks(9052) },
                    { 61, "Ashlee", "Altenwerth", new DateTime(2024, 3, 8, 11, 47, 40, 742, DateTimeKind.Local).AddTicks(768) },
                    { 62, "Dean", "Wilderman", new DateTime(2024, 2, 28, 3, 18, 41, 901, DateTimeKind.Local).AddTicks(4557) },
                    { 63, "Erica", "Stroman", new DateTime(2024, 3, 7, 0, 27, 30, 281, DateTimeKind.Local).AddTicks(7982) },
                    { 64, "Ressie", "Hartmann", new DateTime(2024, 3, 21, 15, 48, 54, 414, DateTimeKind.Local).AddTicks(5455) },
                    { 65, "Zelda", "Haley", new DateTime(2024, 2, 23, 9, 24, 21, 984, DateTimeKind.Local).AddTicks(5538) },
                    { 66, "Darrell", "Schinner", new DateTime(2024, 2, 28, 18, 37, 23, 993, DateTimeKind.Local).AddTicks(8873) },
                    { 67, "Edmund", "Swaniawski", new DateTime(2024, 2, 21, 16, 6, 16, 373, DateTimeKind.Local).AddTicks(4366) },
                    { 68, "Demarco", "Greenfelder", new DateTime(2024, 3, 5, 6, 39, 45, 103, DateTimeKind.Local).AddTicks(2948) },
                    { 69, "Derick", "Nikolaus", new DateTime(2024, 3, 7, 12, 54, 42, 688, DateTimeKind.Local).AddTicks(7043) },
                    { 70, "Katelyn", "Lebsack", new DateTime(2024, 2, 26, 14, 8, 15, 89, DateTimeKind.Local).AddTicks(4305) },
                    { 71, "Ariel", "Leannon", new DateTime(2024, 3, 14, 18, 56, 21, 755, DateTimeKind.Local).AddTicks(6141) },
                    { 72, "Johnson", "Hoppe", new DateTime(2024, 3, 11, 13, 40, 32, 745, DateTimeKind.Local).AddTicks(7864) },
                    { 73, "Davonte", "Stark", new DateTime(2024, 2, 28, 5, 40, 45, 147, DateTimeKind.Local).AddTicks(7751) },
                    { 74, "Madonna", "Labadie", new DateTime(2024, 2, 24, 1, 52, 5, 924, DateTimeKind.Local).AddTicks(4809) },
                    { 75, "Abelardo", "Rowe", new DateTime(2024, 2, 25, 18, 1, 52, 91, DateTimeKind.Local).AddTicks(7906) },
                    { 76, "Ashley", "Mills", new DateTime(2024, 3, 7, 18, 52, 59, 885, DateTimeKind.Local).AddTicks(8885) },
                    { 77, "Llewellyn", "O'Kon", new DateTime(2024, 3, 16, 7, 33, 24, 502, DateTimeKind.Local).AddTicks(7731) },
                    { 78, "Autumn", "Kozey", new DateTime(2024, 2, 21, 18, 20, 25, 436, DateTimeKind.Local).AddTicks(1048) },
                    { 79, "Jaunita", "Vandervort", new DateTime(2024, 3, 10, 10, 51, 29, 34, DateTimeKind.Local).AddTicks(5007) },
                    { 80, "Susie", "Mante", new DateTime(2024, 3, 10, 3, 53, 32, 684, DateTimeKind.Local).AddTicks(157) },
                    { 81, "Charity", "Kiehn", new DateTime(2024, 3, 8, 21, 45, 37, 935, DateTimeKind.Local).AddTicks(8098) },
                    { 82, "Price", "Sauer", new DateTime(2024, 3, 22, 2, 29, 14, 576, DateTimeKind.Local).AddTicks(7473) },
                    { 83, "Jaime", "Kutch", new DateTime(2024, 3, 7, 3, 14, 27, 723, DateTimeKind.Local).AddTicks(8252) },
                    { 84, "Skye", "Cormier", new DateTime(2024, 3, 19, 12, 14, 56, 7, DateTimeKind.Local).AddTicks(9411) }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "FirstName", "LastName", "LastUpdated" },
                values: new object[,]
                {
                    { 85, "Darby", "Kshlerin", new DateTime(2024, 3, 11, 10, 22, 54, 332, DateTimeKind.Local).AddTicks(2720) },
                    { 86, "Else", "Hilpert", new DateTime(2024, 3, 1, 14, 47, 46, 173, DateTimeKind.Local).AddTicks(5857) },
                    { 87, "Laisha", "Dooley", new DateTime(2024, 3, 2, 7, 35, 18, 451, DateTimeKind.Local).AddTicks(5473) },
                    { 88, "Flossie", "Swift", new DateTime(2024, 2, 24, 2, 44, 6, 44, DateTimeKind.Local).AddTicks(9250) },
                    { 89, "Mariela", "Parker", new DateTime(2024, 2, 27, 8, 47, 40, 310, DateTimeKind.Local).AddTicks(457) },
                    { 90, "Kailyn", "Harvey", new DateTime(2024, 3, 14, 9, 20, 12, 995, DateTimeKind.Local).AddTicks(8832) },
                    { 91, "Golden", "Stark", new DateTime(2024, 3, 12, 7, 45, 2, 21, DateTimeKind.Local).AddTicks(7261) },
                    { 92, "Nicole", "Skiles", new DateTime(2024, 2, 26, 10, 42, 51, 561, DateTimeKind.Local).AddTicks(4743) },
                    { 93, "Amanda", "Crist", new DateTime(2024, 3, 17, 6, 32, 4, 337, DateTimeKind.Local).AddTicks(5892) },
                    { 94, "Augustus", "Krajcik", new DateTime(2024, 3, 17, 0, 56, 43, 373, DateTimeKind.Local).AddTicks(3994) },
                    { 95, "Kendall", "Leuschke", new DateTime(2024, 3, 16, 1, 41, 6, 4, DateTimeKind.Local).AddTicks(4158) },
                    { 96, "Bernhard", "Konopelski", new DateTime(2024, 2, 24, 19, 57, 34, 911, DateTimeKind.Local).AddTicks(747) },
                    { 97, "Angelina", "Grady", new DateTime(2024, 2, 27, 19, 4, 38, 818, DateTimeKind.Local).AddTicks(2902) },
                    { 98, "Sierra", "Satterfield", new DateTime(2024, 3, 1, 9, 46, 34, 382, DateTimeKind.Local).AddTicks(3543) },
                    { 99, "Marjolaine", "Roberts", new DateTime(2024, 3, 19, 19, 22, 58, 292, DateTimeKind.Local).AddTicks(4751) },
                    { 100, "Queenie", "Ferry", new DateTime(2024, 3, 11, 0, 41, 30, 621, DateTimeKind.Local).AddTicks(164) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 100);
        }
    }
}
