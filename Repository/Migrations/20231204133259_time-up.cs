using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class timeup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "517f796c-22de-4c39-887e-53b0399889ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5eda9865-f51a-49a9-bcca-229cc61f2f0a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8216190a-3f74-4961-9a93-a51318ef1ab5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9462da8b-8594-4bca-a1e9-39aabb1176d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b845f774-b9fa-48dd-a384-55b102af9a2a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c57426fa-8589-493e-a8ae-9203c38039cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e96d2348-c7e6-4ad4-a3bb-e730358d8736");

            migrationBuilder.AlterColumn<bool>(
                name: "status",
                table: "times",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "status",
                table: "times",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "dateOfBirth", "gender", "image", "role" },
                values: new object[,]
                {
                    { "517f796c-22de-4c39-887e-53b0399889ff", 0, "394a3ad0-8f1a-4e6d-ab52-e802ae68b362", "Karimahmed@gmail.com", false, false, null, null, null, null, "012545455825", false, "78a8e84d-f772-4aaf-bd4a-d4162f8aa1c3", false, "karimAhmed", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "5eda9865-f51a-49a9-bcca-229cc61f2f0a", 0, "d791ceae-c4f0-44a8-8dd1-2c128242299c", "Karim@gmail.com", false, false, null, null, null, null, "012586444825", false, "f8120a4c-7373-44db-90e7-a15d060cfc79", false, "karim", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "8216190a-3f74-4961-9a93-a51318ef1ab5", 0, "68368e69-1680-44cb-b7f8-75580c2f2b3c", "Karimssddsail.com", false, false, null, null, null, null, "012586444825", false, "4744477c-f8f5-4052-861b-6b9605a50aa9", false, "karimssdddss", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "9462da8b-8594-4bca-a1e9-39aabb1176d7", 0, "68b13796-d57e-48d8-88df-8a4d779280b5", "ahmedsssail.com", false, false, null, null, null, null, "012586444825", false, "64ab4a8d-f48e-4175-8b13-6fb63714a3bf", false, "Ahmed", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "b845f774-b9fa-48dd-a384-55b102af9a2a", 0, "f66a34e1-3427-4fec-8c87-b168997fa78e", "SaraKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "1e807462-9ed7-41d6-af2c-ea8e6667c53e", false, "Sarakamel", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 0, null, 0 },
                    { "c57426fa-8589-493e-a8ae-9203c38039cd", 0, "77d342fe-1c83-425f-91f0-d192c08290f3", "KarimKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "b24160ca-f881-494c-8376-dd9d7bad1c14", false, "karimkamel", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 1 },
                    { "e96d2348-c7e6-4ad4-a3bb-e730358d8736", 0, "c9e7a514-8ca7-4c12-bd77-f7be0b068636", "Karimsssail.com", false, false, null, null, null, null, "012586444825", false, "2832330a-7769-4eac-9728-3bd9ff16e39a", false, "karimssss", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 }
                });
        }
    }
}
