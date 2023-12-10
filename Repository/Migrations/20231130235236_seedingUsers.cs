using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class seedingUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
