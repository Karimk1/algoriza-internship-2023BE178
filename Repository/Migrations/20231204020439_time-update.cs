using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class timeupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_requests_times_timeid",
                table: "requests");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bc38a14-1c57-449d-a5be-c768abc7e919");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17ff6f2c-899b-4faa-8cf5-fb83a18fd764");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46e6e3eb-c032-48c5-8901-0ab43dcf66f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "610b9093-3a6c-4c58-bbc6-e41ba770cdc4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "911ab4d6-c3f9-4f1d-b56f-9a041d49fec9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9dd1a84a-980a-47e0-854c-52e69d776fee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf2ebd4f-1df7-46e0-99ff-7195eab027f1");

            migrationBuilder.RenameColumn(
                name: "timeid",
                table: "requests",
                newName: "timeId");

            migrationBuilder.RenameIndex(
                name: "IX_requests_timeid",
                table: "requests",
                newName: "IX_requests_timeId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_requests_times_timeId",
                table: "requests",
                column: "timeId",
                principalTable: "times",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_requests_times_timeId",
                table: "requests");

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

            migrationBuilder.RenameColumn(
                name: "timeId",
                table: "requests",
                newName: "timeid");

            migrationBuilder.RenameIndex(
                name: "IX_requests_timeId",
                table: "requests",
                newName: "IX_requests_timeid");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "dateOfBirth", "gender", "image", "role" },
                values: new object[,]
                {
                    { "0bc38a14-1c57-449d-a5be-c768abc7e919", 0, "a4c38d0e-0df2-44ec-bee6-158f3bdfb2f5", "Karimsssail.com", false, false, null, null, null, null, "012586444825", false, "d423674e-0a51-4184-bac9-abad8a42a827", false, "karimssss", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "17ff6f2c-899b-4faa-8cf5-fb83a18fd764", 0, "3a9b6e5e-091c-4cc5-9602-523db930e76d", "Karimahmed@gmail.com", false, false, null, null, null, null, "012545455825", false, "b4fd38e3-5739-45d1-953c-c997f7524240", false, "karimAhmed", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "46e6e3eb-c032-48c5-8901-0ab43dcf66f3", 0, "eafca9d6-013c-419e-b26c-864df6684626", "KarimKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "803a24a4-a78b-4305-8b5a-da4bdf48916e", false, "karimkamel", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 1 },
                    { "610b9093-3a6c-4c58-bbc6-e41ba770cdc4", 0, "9077597b-bd47-4725-9764-0c175f2800eb", "Karim@gmail.com", false, false, null, null, null, null, "012586444825", false, "a2c6bc8f-18a0-4d89-8df6-2019056125e4", false, "karim", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "911ab4d6-c3f9-4f1d-b56f-9a041d49fec9", 0, "6912ffa5-245b-460d-a524-d5c2f6a40a35", "SaraKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "57052700-bf13-434f-86d5-c9f4c91dd92f", false, "Sarakamel", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 0, null, 0 },
                    { "9dd1a84a-980a-47e0-854c-52e69d776fee", 0, "55e40dc6-a916-4092-9d20-47495f22548f", "Karimssddsail.com", false, false, null, null, null, null, "012586444825", false, "b7b20c88-1336-42e0-9dea-986fd097c175", false, "karimssdddss", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "bf2ebd4f-1df7-46e0-99ff-7195eab027f1", 0, "d822ab7e-e0de-4429-b868-a712a617a19e", "ahmedsssail.com", false, false, null, null, null, null, "012586444825", false, "79dcdb4a-aafa-4d50-8699-245739b4e8da", false, "Ahmed", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_requests_times_timeid",
                table: "requests",
                column: "timeid",
                principalTable: "times",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
