using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bmarketomvc.Migrations
{
    /// <inheritdoc />
    public partial class Updateddesigninformparts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c853e18-0400-40cb-a4e3-ad8ccce39f1f",
                column: "ConcurrencyStamp",
                value: "1ac28502-f82b-4e21-9fad-6fa88a9ed626");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea3bc81b-067d-4116-beab-193c8e836009",
                column: "ConcurrencyStamp",
                value: "912e2d8c-26ad-4321-b71a-74c4e7049424");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48dd5706-f505-4a50-a123-dfb2cdf88171",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e427ce1-935d-46e8-9ea4-86f1470ea6bd", "AQAAAAIAAYagAAAAEIE4pG3Rr3t0W5Ob45uz4qrwAYNCGn6l3aMEE/a3zQ9RaO/+7VN1emkFADO/ZNk3Hg==", "70f13f09-798d-4883-9d4c-aa52a789d518" });
        }
    }
}
