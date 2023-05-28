using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bmarketomvc.Migrations
{
    /// <inheritdoc />
    public partial class Productss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/applewatch-270-295.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c853e18-0400-40cb-a4e3-ad8ccce39f1f",
                column: "ConcurrencyStamp",
                value: "4aba7930-95f0-4e6d-a278-887232f7e5b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea3bc81b-067d-4116-beab-193c8e836009",
                column: "ConcurrencyStamp",
                value: "83190531-9d89-47cc-8b32-34ca264561e7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48dd5706-f505-4a50-a123-dfb2cdf88171",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33ca0ed0-50e0-4a2e-b296-33f92edb98c1", "AQAAAAIAAYagAAAAECtuYSoFJoe4rKTnAL/EXWx/D8E4SeHe69TPZc/oh+gXaJdOto5/0MayeUEty1PNQQ==", "effcb26f-69c0-4ef7-a7d1-2de632849352" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "wwwroot/images/applewatch-270-295.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "C:\\Users\\Sebastian\\Desktop\\Skola\\Bmarketo_mvc\\bmarketomvc\\bmarketomvc\\wwwroot\\images\\coffe-270-295.jpg");
        }
    }
}
