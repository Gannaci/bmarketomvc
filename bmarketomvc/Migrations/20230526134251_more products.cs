using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bmarketomvc.Migrations
{
    /// <inheritdoc />
    public partial class moreproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Addresses_AddressEnitityId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "AddressEnitityId",
                table: "AspNetUsers",
                newName: "AddressEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_AddressEnitityId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_AddressEntityId");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "ContactForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c853e18-0400-40cb-a4e3-ad8ccce39f1f",
                column: "ConcurrencyStamp",
                value: "e5c72b9b-8501-42a6-a434-fcd1840c8d5e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea3bc81b-067d-4116-beab-193c8e836009",
                column: "ConcurrencyStamp",
                value: "49d37a6b-636b-478a-bc55-b4a305c8cfb7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48dd5706-f505-4a50-a123-dfb2cdf88171",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77182ea0-ad5c-48e5-b1e9-0b2ed48ccf2f", "AQAAAAIAAYagAAAAENrsUARQjYHfRn4g+H4KYRqEkFha1OnT14ClFRM3UKnBcn2AirXBccV982PKNGxMLA==", "692ef02a-4681-45ad-8611-08ae5f6d2c5a" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Mjuk och följsam. Design som tänjer gränser. Apple Watch Series 8 har en stor, kristallklar skärm som alltid är på. Skärmen sträcker sig hela vägen ut till kanterna och smälter elegant ihop med boettens kurvor.", "https://www.jumpplus.com/web/image/product.product/29365/image_1024/%5BMNP73VC-A%5D%20Apple%20Watch%20Series%208%20%20%28PRODUCT%29RED%20Aluminium%20Case%20with%20%28PRODUCT%29RED%20Sport%20Band%20%2841mm%2C%20GPS%29?unique=8c04e56", 310m, "Iphone" });

            migrationBuilder.InsertData(
                table: "ProductTags",
                columns: new[] { "ProductId", "TagId" },
                values: new object[] { 2, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Addresses_AddressEntityId",
                table: "AspNetUsers",
                column: "AddressEntityId",
                principalTable: "Addresses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Addresses_AddressEntityId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "ContactForms");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "AddressEntityId",
                table: "AspNetUsers",
                newName: "AddressEnitityId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_AddressEntityId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_AddressEnitityId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c853e18-0400-40cb-a4e3-ad8ccce39f1f",
                column: "ConcurrencyStamp",
                value: "6a384cc4-8e72-42d7-8cfc-64ec0ccada6b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea3bc81b-067d-4116-beab-193c8e836009",
                column: "ConcurrencyStamp",
                value: "062d3328-3293-4427-bb42-12515d7408ca");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48dd5706-f505-4a50-a123-dfb2cdf88171",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a4fc051-51dd-406a-a584-9de85a3c83dd", "AQAAAAIAAYagAAAAEBfwJ6ohYIrGbyxxMmyVN0wMKWnfcQyrU9rYGvr/DESIZaX+OYlFnH0S3wQDJjTwTg==", "64bc0945-ed9c-479b-8fc5-f41199d95a5a" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Addresses_AddressEnitityId",
                table: "AspNetUsers",
                column: "AddressEnitityId",
                principalTable: "Addresses",
                principalColumn: "Id");
        }
    }
}
