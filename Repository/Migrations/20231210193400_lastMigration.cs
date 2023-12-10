using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Services.Migrations
{
    /// <inheritdoc />
    public partial class lastMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df65004c-85a9-4fd4-bd9f-21b1e995ab2b", "AQAAAAIAAYagAAAAEAThoHsDez+TP1j+793wdHuYBBghNUWeR2+FNBwTDKUZVBVmeH/2fsbeO9N9XaROHA==", "79464fd8-6b7c-4949-b931-22db37dd1f9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "015c416b-ba21-4492-93ab-0b91cf9fe42a", "AQAAAAIAAYagAAAAECrSdmpvSxFv4bX8qXrnVygxoe/y1Gqun4QB8146FZjRZEFN4S12uOAJl0VdgfnJ2w==", "4ad3a1e9-365b-487c-977b-2419df0d5204" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-kk14554843d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed2c2d39-2fa8-44a6-bf2a-a6f0425b262a", "AQAAAAIAAYagAAAAEKVToLy0VajDqlYcri2ZlaDw2Sy1srshcZtfwnJhiWlqrx51a5Zq/jqqo9GWOj6PyA==", "a3612198-5a32-40ba-8d35-32e876a103c2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e1746b7-b1c7-42e8-aaf2-30d64b6759b2", "AQAAAAIAAYagAAAAEEkos6IUWftOZp0ALI7FR+STXZvxWKIcbl7C58Kqhm6fQ9NUdcz2yFlz8yYK/XYqNg==", "55804c36-3d45-4ab7-901a-a411d723669e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21aaf929-4322-446b-958c-92ef953727f4", "AQAAAAIAAYagAAAAEJ8/kPrRrDcdcJtUiecO5dqgBO4dvpKzG/6zQ7gNlwYkSr7Y4SeTcNQxtwF2p+CXAw==", "8130f10a-76f6-4ff7-bf8c-53cc58dd5db5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-kk14554843d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92503652-69dd-4eb0-a4e3-16946cb91fc1", "AQAAAAIAAYagAAAAEHFwCFpggUoszTrxuMjtp0Rxqj/NWd/g6HTzQDR8fO9EypEoWDaRPOb+xl+d5FdmHQ==", "eb67c162-055e-40e6-81a4-4bbcbf4f32b5" });
        }
    }
}
