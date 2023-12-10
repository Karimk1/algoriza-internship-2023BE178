using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class addUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a98616b-93d3-4394-86b7-31154053c707");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3dee981e-5e14-44ba-a2d2-72175048bbe5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80e2cfe4-985e-4059-918c-be657a3fc5e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ff93d65-666a-47bf-b996-bd106ba1cbd1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1b1f790-ea6f-4ee2-b81b-00779ebfff0a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed4b65b8-5aab-401f-b9fb-960a878fbcfc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4d6ea2b-b0b9-4abc-9795-ce90f533a95d");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "0a98616b-93d3-4394-86b7-31154053c707", 0, "8456c57b-e933-4ae4-8412-7e08de918a8c", "SaraKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "82847aab-11a2-4fac-966f-a7318c478217", false, "Sarakamel", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 0, null, 0 },
                    { "3dee981e-5e14-44ba-a2d2-72175048bbe5", 0, "f0291501-cfcb-45c4-8059-68438affa800", "Karimssddsail.com", false, false, null, null, null, null, "012586444825", false, "4805bfed-a42f-4f0d-940c-f678422d783b", false, "karimssdddss", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "80e2cfe4-985e-4059-918c-be657a3fc5e1", 0, "a9e9990b-e047-4a41-9b80-6bf350ddbf9c", "Karim@gmail.com", false, false, null, null, null, null, "012586444825", false, "c9ad0b91-18bb-42dc-932e-0aa5851d3f92", false, "karim", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "8ff93d65-666a-47bf-b996-bd106ba1cbd1", 0, "6fc954fe-f695-4328-b574-4632a7e4d3a6", "ahmedsssail.com", false, false, null, null, null, null, "012586444825", false, "7825b467-15b5-405a-aaac-8cb1e68d673f", false, "Ahmed", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "c1b1f790-ea6f-4ee2-b81b-00779ebfff0a", 0, "24c1c72e-da73-4817-ba3d-fe77e955f414", "Karimahmed@gmail.com", false, false, null, null, null, null, "012545455825", false, "b3acc3b2-2df2-4d02-b274-569be2fb5f98", false, "karimAhmed", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "ed4b65b8-5aab-401f-b9fb-960a878fbcfc", 0, "80210a66-5866-49a4-9cc8-68d270ff7790", "Karimsssail.com", false, false, null, null, null, null, "012586444825", false, "6a9b3174-2d0d-47a1-90b4-818fca7d237d", false, "karimssss", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "f4d6ea2b-b0b9-4abc-9795-ce90f533a95d", 0, "fe19340f-3fc0-45b7-884d-57538b298e80", "KarimKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "e340fede-5422-49cb-97d1-1be21ff7c7ad", false, "karimkamel", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 1 }
                });
        }
    }
}
