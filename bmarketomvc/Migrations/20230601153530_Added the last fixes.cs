using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bmarketomvc.Migrations
{
    /// <inheritdoc />
    public partial class Addedthelastfixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c853e18-0400-40cb-a4e3-ad8ccce39f1f",
                column: "ConcurrencyStamp",
                value: "2f7cb420-c78b-41f5-9f26-4fd3cb91b7e5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea3bc81b-067d-4116-beab-193c8e836009",
                column: "ConcurrencyStamp",
                value: "fd3d6900-a007-4374-af0b-04db94afc222");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48dd5706-f505-4a50-a123-dfb2cdf88171",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2894e2b1-ae8d-4482-b640-6319ca6bba70", "AQAAAAIAAYagAAAAEALxnPGA3tETAFzXbiZWOJGYju/yYbDmYgjjqUrETcRc0Ee5Kbx6kuYSlk3PtiVZTg==", "8e53231b-872b-407a-99db-a850efa43a5e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c853e18-0400-40cb-a4e3-ad8ccce39f1f",
                column: "ConcurrencyStamp",
                value: "79115713-4813-4f09-a7f0-b326d5d249f2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea3bc81b-067d-4116-beab-193c8e836009",
                column: "ConcurrencyStamp",
                value: "6ae9ba22-87fa-4ed5-8961-fb5210878244");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48dd5706-f505-4a50-a123-dfb2cdf88171",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b941ab4-cc86-41c8-934b-8e5d64143cef", "AQAAAAIAAYagAAAAELlhUf3cF9lvlOv9VGyU1xt7cDNLGu5kULZDna2rv5YYvp+LawzLTM2N5kSMhiXsFw==", "9355632e-c060-4f8b-b373-d872cdc84156" });
        }
    }
}
