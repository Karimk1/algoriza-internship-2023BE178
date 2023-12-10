using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class coupon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c31bca4-dbee-404d-965a-0f24346c81e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6642745d-fac0-4867-b633-5f8a37006e56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70e7d6c4-239b-4e0a-86e7-e6159ed69c37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e5c0701-9499-4e91-9f11-06d504b300ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc2c553a-5f36-47fe-9697-87684dfea92b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd910932-480c-4d38-931a-15fc7a048954");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9c13f46-2340-4297-8de7-8349312c9399");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "dateOfBirth", "gender", "image", "role" },
                values: new object[,]
                {
                    { "1875501e-ffe8-4958-a9e6-7de2eb948597", 0, "b7748a9b-9af4-40ed-a91e-9a97d2fa2fab", "ahmedsssail.com", false, false, null, null, null, null, "012586444825", false, "86923650-c10b-4e7c-8224-0f7603e575f2", false, "Ahmed", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "3bfe0791-7bea-4810-9829-73f423547924", 0, "79fda904-a460-4da0-aae4-ced2818ef75d", "Karim@gmail.com", false, false, null, null, null, null, "012586444825", false, "74a2ee74-1a35-4816-9d96-d5336bb5ac79", false, "karim", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "6b42ee4c-f620-43bd-bb3b-a5c9455f197d", 0, "5034dad3-11a2-4ed0-a970-b6698653119d", "SaraKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "293279ca-17ed-4b58-a346-53032d3bf5a1", false, "Sarakamel", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 0, null, 0 },
                    { "86103773-f690-44ed-96dc-40babe117fd7", 0, "eed10473-8fcb-4819-8efb-be3f25cdbc9c", "KarimKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "699d06ab-b0c7-4451-8597-373c0afca8b5", false, "karimkamel", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 1 },
                    { "93e71e68-8483-4354-ac6b-a74377dc7f6f", 0, "97d80569-86ef-47f8-82bd-8a64b057e7b3", "Karimssddsail.com", false, false, null, null, null, null, "012586444825", false, "b1391668-9404-4619-9d16-6088003733d9", false, "karimssdddss", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "d6241ef3-d60f-4641-b440-ef7a28b54133", 0, "194247a7-fb00-4837-8e57-225a674d8169", "Karimsssail.com", false, false, null, null, null, null, "012586444825", false, "3e6313e0-f178-4120-8b4a-1bc8ae7b1950", false, "karimssss", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "edb26b60-a909-4f1b-bc30-b36e9a2d6a95", 0, "b47f9eea-bc31-4406-b273-820adad7a06e", "Karimahmed@gmail.com", false, false, null, null, null, null, "012545455825", false, "c14b6b97-f3ff-4e35-8a26-02948d21e4c5", false, "karimAhmed", new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1875501e-ffe8-4958-a9e6-7de2eb948597");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bfe0791-7bea-4810-9829-73f423547924");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b42ee4c-f620-43bd-bb3b-a5c9455f197d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86103773-f690-44ed-96dc-40babe117fd7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93e71e68-8483-4354-ac6b-a74377dc7f6f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6241ef3-d60f-4641-b440-ef7a28b54133");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edb26b60-a909-4f1b-bc30-b36e9a2d6a95");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "dateOfBirth", "gender", "image", "role" },
                values: new object[,]
                {
                    { "2c31bca4-dbee-404d-965a-0f24346c81e9", 0, "4a170c4d-3660-435a-9cd3-36b70e0172c4", "Karim@gmail.com", false, false, null, null, null, null, "012586444825", false, "76405abf-e5ba-4c43-93ee-b9ad26648ba2", false, "karim", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "6642745d-fac0-4867-b633-5f8a37006e56", 0, "ae416092-b3ce-4d1b-a8e6-9deb4c20ec69", "Karimssddsail.com", false, false, null, null, null, null, "012586444825", false, "3c2a12e4-3deb-4f44-9285-18bcff7e9075", false, "karimssdddss", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "70e7d6c4-239b-4e0a-86e7-e6159ed69c37", 0, "99097a24-9c36-4df1-846e-52b97da61197", "KarimKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "21d7e9f5-3047-4cba-89b9-f2ba7dac6074", false, "karimkamel", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 1 },
                    { "8e5c0701-9499-4e91-9f11-06d504b300ca", 0, "a1bf0fe3-780a-478b-ab73-99199288f4cc", "Karimsssail.com", false, false, null, null, null, null, "012586444825", false, "3e57986d-aaf2-4d31-8071-cb03a4fb421d", false, "karimssss", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "bc2c553a-5f36-47fe-9697-87684dfea92b", 0, "989895e5-b064-40c1-a790-01c9d8b44e2c", "ahmedsssail.com", false, false, null, null, null, null, "012586444825", false, "7bbb924b-5923-4b93-8270-c93370622011", false, "Ahmed", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "dd910932-480c-4d38-931a-15fc7a048954", 0, "c0f79045-a004-4612-9541-8c4f8e15e4b0", "SaraKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "1f2ab0ec-4fcf-48d5-ac99-b98129e51680", false, "Sarakamel", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), 0, null, 0 },
                    { "e9c13f46-2340-4297-8de7-8349312c9399", 0, "e601f0bf-1cba-4373-a586-aa871eab8687", "Karimahmed@gmail.com", false, false, null, null, null, null, "012545455825", false, "d0bf1374-6d64-4859-ae12-76ea5b0693f9", false, "karimAhmed", new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 }
                });
        }
    }
}
