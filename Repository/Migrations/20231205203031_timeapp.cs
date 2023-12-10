using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class timeapp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31c5a935-c2b7-4b63-b215-089c21b40c7b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b81df5a-84b5-4fcb-9338-0322d24a0b59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b04926fa-d1c8-42f4-a7e2-33ba474ccc28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d055ccae-5593-431b-a24a-2e5bacf0a4f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1caada1-8b8b-4d26-bb67-d4d799372dd1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f77e1d6e-5bf1-407b-96cc-15c2ecd618c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9d3df54-7804-424a-81fa-e4715f85b7bb");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "dateOfBirth", "gender", "image", "role" },
                values: new object[,]
                {
                    { "120e48a2-da84-4a5d-955b-6d91fd3d3820", 0, "05261203-9a35-450c-8d00-1527326033fd", "Karim@gmail.com", false, false, null, null, null, null, "012586444825", false, "3d14bf3a-4630-4b46-bc68-ad4218e089ba", false, "karim", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "15f7a60b-5591-4ee0-a7db-aae178e5ca4f", 0, "4b031f4a-df34-4e01-80ec-ffd992ac3ddc", "Karimsssail.com", false, false, null, null, null, null, "012586444825", false, "8f51c1f3-fae0-40f7-92e9-6e7825cfd11d", false, "karimssss", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "29c0207e-4144-4c4b-9412-7d6b3c5a91e4", 0, "b8d205b4-9cd2-4029-9258-b0b85ad73839", "ahmedsssail.com", false, false, null, null, null, null, "012586444825", false, "47847ba6-cc16-4734-bff7-716bba465f84", false, "Ahmed", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "3ecfc360-3cfb-4147-8a39-3eb7e43a7044", 0, "b5beddd5-2e07-499b-900e-a6896011d7e4", "Karimahmed@gmail.com", false, false, null, null, null, null, "012545455825", false, "b9394229-0f9c-47b6-9e87-9f3470724fd8", false, "karimAhmed", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "87402b3d-1f3a-4327-958c-f76e9949d1b6", 0, "859d7616-b7af-40f9-b3c3-322832bc69c7", "Karimssddsail.com", false, false, null, null, null, null, "012586444825", false, "9f4e9391-0c31-4abd-8655-7ad0bec0df50", false, "karimssdddss", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "96a444ab-2651-4472-9e84-a1d2f7f36012", 0, "952cff58-f866-4c88-a43a-d3cff754a418", "KarimKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "09f8fe0b-055b-48dd-a73b-dd89e457e441", false, "karimkamel", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 1 },
                    { "dd6e57f0-20f1-448d-bce3-e2e823383e67", 0, "f2e1fb83-3ea0-4b2c-bf5e-9412a6547035", "SaraKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "df65b9ab-2ba8-4da5-a31d-320a279fd8ee", false, "Sarakamel", new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Local), 0, null, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120e48a2-da84-4a5d-955b-6d91fd3d3820");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15f7a60b-5591-4ee0-a7db-aae178e5ca4f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29c0207e-4144-4c4b-9412-7d6b3c5a91e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ecfc360-3cfb-4147-8a39-3eb7e43a7044");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87402b3d-1f3a-4327-958c-f76e9949d1b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96a444ab-2651-4472-9e84-a1d2f7f36012");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd6e57f0-20f1-448d-bce3-e2e823383e67");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "dateOfBirth", "gender", "image", "role" },
                values: new object[,]
                {
                    { "31c5a935-c2b7-4b63-b215-089c21b40c7b", 0, "c884ab99-45ef-4323-829f-abfa58aa66d0", "Karimahmed@gmail.com", false, false, null, null, null, null, "012545455825", false, "e0091e78-9ea7-4e7f-8c0d-85970f9b208b", false, "karimAhmed", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "7b81df5a-84b5-4fcb-9338-0322d24a0b59", 0, "64cb0768-2466-48cc-ab2b-8c67201e3329", "SaraKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "39c43574-c0ec-4799-9411-d7c8f6668138", false, "Sarakamel", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 0, null, 0 },
                    { "b04926fa-d1c8-42f4-a7e2-33ba474ccc28", 0, "23029198-dbf0-4ba9-9d02-6f537b3a1bf1", "Karimssddsail.com", false, false, null, null, null, null, "012586444825", false, "1ac610eb-9eb6-479d-8273-5dd49314bc11", false, "karimssdddss", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "d055ccae-5593-431b-a24a-2e5bacf0a4f6", 0, "64a61d79-efb9-4b89-99bf-9c30647bb952", "Karim@gmail.com", false, false, null, null, null, null, "012586444825", false, "c7b70c55-89c9-4551-9ac3-4d3f29a63a6d", false, "karim", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "e1caada1-8b8b-4d26-bb67-d4d799372dd1", 0, "2f0a277d-360e-4613-874e-5cb896b89d3f", "KarimKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "a0b16e69-d072-43f5-95d1-2f7ba9b4c308", false, "karimkamel", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 1 },
                    { "f77e1d6e-5bf1-407b-96cc-15c2ecd618c4", 0, "1d759c35-015a-49a3-9969-360c897c93b4", "ahmedsssail.com", false, false, null, null, null, null, "012586444825", false, "020422ba-73a2-4beb-95ed-df420925f883", false, "Ahmed", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "f9d3df54-7804-424a-81fa-e4715f85b7bb", 0, "9f1fe4cf-6e0a-46fe-a9ea-de5b4b0da7d9", "Karimsssail.com", false, false, null, null, null, null, "012586444825", false, "386261bb-dd94-4044-8e1e-74fa0e41c4b5", false, "karimssss", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 }
                });
        }
    }
}
