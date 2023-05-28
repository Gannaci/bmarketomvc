using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bmarketomvc.Migrations
{
    /// <inheritdoc />
    public partial class Reneweddb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c853e18-0400-40cb-a4e3-ad8ccce39f1f",
                column: "ConcurrencyStamp",
                value: "9a274e51-3804-4eff-ad15-58032b080e1a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea3bc81b-067d-4116-beab-193c8e836009",
                column: "ConcurrencyStamp",
                value: "f0245b46-7b65-4b00-a85a-b7788f488f9c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48dd5706-f505-4a50-a123-dfb2cdf88171",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6792b25d-5f56-4fb0-b761-07dd6fdea30e", "AQAAAAIAAYagAAAAEIfTwt2SASBqTMnxGxUNgMLq6kYSy+avF8oX9oCaG22VK/SPF9nI+vKZfgLo/0e80w==", "38e760bd-3c70-467f-a88b-af2b049b52ad" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c853e18-0400-40cb-a4e3-ad8ccce39f1f",
                column: "ConcurrencyStamp",
                value: "edb22a4d-1aad-4338-a44a-9b64348e6503");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea3bc81b-067d-4116-beab-193c8e836009",
                column: "ConcurrencyStamp",
                value: "d8b56cbe-a26f-4909-9655-ba29584bc042");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48dd5706-f505-4a50-a123-dfb2cdf88171",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7618b4ff-bdb6-4854-8273-ad8c68358ea3", "AQAAAAIAAYagAAAAEAaZGWghQ+1avHRgDRDnbuMfLBU6//uGhGjbAu9/5XBzpivj3qY0Kq4FesrydmjH8g==", "933d6f7f-9c4a-4f63-a249-d464d6d6b4d8" });
        }
    }
}
