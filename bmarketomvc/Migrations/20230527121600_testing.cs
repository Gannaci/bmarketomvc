using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bmarketomvc.Migrations
{
    /// <inheritdoc />
    public partial class testing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { null, "images/applewatch-270-295.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { null, "", 30m, "Table Lamp" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 3, null, "", 30m, "Laptop" },
                    { 4, null, "", 30m, "Mirror" },
                    { 5, null, "", 30m, "Rice cooker" },
                    { 6, null, "", 30m, "Pizza slice" },
                    { 7, null, "", 30m, "Sunglasses" },
                    { 8, null, "", 30m, "Watter bottle" },
                    { 9, null, "", 30m, "Lamp" },
                    { 10, null, "", 30m, "Lamp" },
                    { 11, null, "", 100m, "Fotball" },
                    { 12, null, "", 30m, "Coffe" },
                    { 13, null, "", 120m, "Dress" },
                    { 14, null, "", 120m, "Dress" },
                    { 15, null, "", 500m, "Iphone" },
                    { 16, null, "", 200m, "Shoes" },
                    { 17, null, "", 30m, "Lamp" },
                    { 18, null, "", 30m, "Lamp" },
                    { 19, null, "", 30m, "Lamp" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Mjuk och följsam. Design som tänjer gränser. Apple Watch Series 8 har en stor, kristallklar skärm som alltid är på. Skärmen sträcker sig hela vägen ut till kanterna och smälter elegant ihop med boettens kurvor.", "https://www.jumpplus.com/web/image/product.product/29365/image_1024/%5BMNP73VC-A%5D%20Apple%20Watch%20Series%208%20%20%28PRODUCT%29RED%20Aluminium%20Case%20with%20%28PRODUCT%29RED%20Sport%20Band%20%2841mm%2C%20GPS%29?unique=8c04e56" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Mjuk och följsam. Design som tänjer gränser. Apple Watch Series 8 har en stor, kristallklar skärm som alltid är på. Skärmen sträcker sig hela vägen ut till kanterna och smälter elegant ihop med boettens kurvor.", "https://www.jumpplus.com/web/image/product.product/29365/image_1024/%5BMNP73VC-A%5D%20Apple%20Watch%20Series%208%20%20%28PRODUCT%29RED%20Aluminium%20Case%20with%20%28PRODUCT%29RED%20Sport%20Band%20%2841mm%2C%20GPS%29?unique=8c04e56", 310m, "Iphone" });
        }
    }
}
