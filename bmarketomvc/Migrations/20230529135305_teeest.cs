using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bmarketomvc.Migrations
{
    /// <inheritdoc />
    public partial class teeest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c853e18-0400-40cb-a4e3-ad8ccce39f1f",
                column: "ConcurrencyStamp",
                value: "f823d7a6-5786-4ee3-831b-1e8a69649595");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea3bc81b-067d-4116-beab-193c8e836009",
                column: "ConcurrencyStamp",
                value: "c6297d84-dcd8-45ee-a6fc-aedb89b8de3f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48dd5706-f505-4a50-a123-dfb2cdf88171",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26efcb54-8aca-4316-937c-205b040855a1", "AQAAAAIAAYagAAAAEDr9x17OTcudBWUKtnnNzFvL6SDnQ4xkl31otcSYup/E1A41GE94rPgTcib+BXniAA==", "7592bb05-d347-49c2-99d8-81f489cee0f8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c853e18-0400-40cb-a4e3-ad8ccce39f1f",
                column: "ConcurrencyStamp",
                value: "28b7791a-b080-45da-b813-4db13cd6e16e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea3bc81b-067d-4116-beab-193c8e836009",
                column: "ConcurrencyStamp",
                value: "ee8dd81f-d7e1-49ab-a2a6-25d933529bfb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48dd5706-f505-4a50-a123-dfb2cdf88171",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04836271-962d-4f49-baed-58b83c8a9c6a", "AQAAAAIAAYagAAAAED9UN4G3tnzTVKrd0Xo8fUbjAl21IlepEPiUIUnB97K3ibT6BH2JlcbchPdYw93RaQ==", "b19e0c42-0990-4e51-93cf-7632c0c13e03" });
        }
    }
}
