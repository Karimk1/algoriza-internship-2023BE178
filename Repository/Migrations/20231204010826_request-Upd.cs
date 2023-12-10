using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class requestUpd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_requests_coupons_couponid",
                table: "requests");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e03e343-6b94-4e95-a5c0-8a517a89eb2a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66cc0253-27d4-4b2e-a1b4-66c0a117bdf5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b650201-2bc9-4695-a272-33e7a8674b9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ea68f3e-d1b6-4160-b41c-04bed45521a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e255df8e-711c-4e91-99ed-689eaad7b653");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f73557c5-3f85-4deb-9471-1675afa30cd6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fcd3c9e0-84f6-4364-9725-a4b41c28b48e");

            migrationBuilder.RenameColumn(
                name: "couponid",
                table: "requests",
                newName: "couponId");

            migrationBuilder.RenameIndex(
                name: "IX_requests_couponid",
                table: "requests",
                newName: "IX_requests_couponId");

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
                name: "FK_requests_coupons_couponId",
                table: "requests",
                column: "couponId",
                principalTable: "coupons",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_requests_coupons_couponId",
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
                name: "couponId",
                table: "requests",
                newName: "couponid");

            migrationBuilder.RenameIndex(
                name: "IX_requests_couponId",
                table: "requests",
                newName: "IX_requests_couponid");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "dateOfBirth", "gender", "image", "role" },
                values: new object[,]
                {
                    { "1e03e343-6b94-4e95-a5c0-8a517a89eb2a", 0, "39b09c31-9118-44a8-b748-a042554a5af3", "Karimssddsail.com", false, false, null, null, null, null, "012586444825", false, "9fe61938-ffb7-41d5-8097-29b326bb9b47", false, "karimssdddss", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "66cc0253-27d4-4b2e-a1b4-66c0a117bdf5", 0, "5803a0dc-ae61-4c13-9e19-f0537c93b9d1", "Karimsssail.com", false, false, null, null, null, null, "012586444825", false, "065599ae-1f98-48bb-b3ff-ea7b0f7feb13", false, "karimssss", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "7b650201-2bc9-4695-a272-33e7a8674b9b", 0, "b769c537-d8f8-4670-8a5b-6997cd58c6db", "Karimahmed@gmail.com", false, false, null, null, null, null, "012545455825", false, "4e151649-dbf8-4860-9fe4-ce69195d3bc4", false, "karimAhmed", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "9ea68f3e-d1b6-4160-b41c-04bed45521a4", 0, "59295794-cf2f-4d35-af90-3634164e268c", "SaraKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "c5ec5ba7-368c-4723-9349-c95cf219bda0", false, "Sarakamel", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 0, null, 0 },
                    { "e255df8e-711c-4e91-99ed-689eaad7b653", 0, "131fa2bb-eb24-4d03-9352-c4f4caf0b65e", "ahmedsssail.com", false, false, null, null, null, null, "012586444825", false, "3dbd9ffa-3417-4f9b-a454-52e8283362c9", false, "Ahmed", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 0 },
                    { "f73557c5-3f85-4deb-9471-1675afa30cd6", 0, "d20b4d6e-5610-4935-9fb0-57134f690d15", "Karim@gmail.com", false, false, null, null, null, null, "012586444825", false, "f264f9db-20d0-45d4-a987-3922232df113", false, "karim", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 2 },
                    { "fcd3c9e0-84f6-4364-9725-a4b41c28b48e", 0, "f169f20c-c843-45a4-b5b1-ed8519ce7ac0", "KarimKamel@gmail.com", false, false, null, null, null, null, "012586444825", false, "125366b9-3a39-472d-8fc8-f671037334ae", false, "karimkamel", new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Local), 1, null, 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_requests_coupons_couponid",
                table: "requests",
                column: "couponid",
                principalTable: "coupons",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
