using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bmarketomvc.Migrations
{
    /// <inheritdoc />
    public partial class testingtestin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c853e18-0400-40cb-a4e3-ad8ccce39f1f",
                column: "ConcurrencyStamp",
                value: "446398d5-7225-40eb-9e4d-62826a73bc37");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea3bc81b-067d-4116-beab-193c8e836009",
                column: "ConcurrencyStamp",
                value: "6e7b66d7-b890-4d3d-9dc5-027344ce5802");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48dd5706-f505-4a50-a123-dfb2cdf88171",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f75fa612-c850-43c9-a4e8-79c3ffd2a599", "AQAAAAIAAYagAAAAEF0vnz1mKjrNHNmzrRfFv9tQ5hD5glfgzfkkWbgiynUsLUX6HqqbKueJPWmQmTLIxw==", "cc06e9cb-0a51-407a-8767-16e5103876f6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c853e18-0400-40cb-a4e3-ad8ccce39f1f",
                column: "ConcurrencyStamp",
                value: "cb202ebc-5764-4044-a5f2-57ff63671aed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea3bc81b-067d-4116-beab-193c8e836009",
                column: "ConcurrencyStamp",
                value: "6573c26a-7cab-4b8f-b553-0ce474e42588");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48dd5706-f505-4a50-a123-dfb2cdf88171",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0afce8fd-c3cc-416c-8eda-9f558cca4d96", "AQAAAAIAAYagAAAAEHVicb2OojqP0LvLRVjqQGv25BXm01HNfRG4YN4DQZffyqMiKFNgMdCBK/3bV0gcCA==", "0953ab57-c760-49b5-88b9-1812c1b45acc" });
        }
    }
}
