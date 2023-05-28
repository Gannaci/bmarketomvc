using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bmarketomvc.Migrations
{
    /// <inheritdoc />
    public partial class Addedmoreproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c853e18-0400-40cb-a4e3-ad8ccce39f1f",
                column: "ConcurrencyStamp",
                value: "dc6776f0-041c-4394-ae1f-32925b09f63d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea3bc81b-067d-4116-beab-193c8e836009",
                column: "ConcurrencyStamp",
                value: "58f79d46-fb6e-4fb8-82bd-f8e3b453037f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48dd5706-f505-4a50-a123-dfb2cdf88171",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66e887a5-88f1-443d-91b9-57daca289967", "AQAAAAIAAYagAAAAEAwI+o7/18/gD0ygMFYBW2lfjZq6ggmWjR9qNNbiksV71aMBU8HEKj4+7FB/DJuTyQ==", "4aa4c9d3-6806-493f-97a3-0b0e0cd5acf0" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "images/applewatch-270-295.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "");
        }
    }
}
