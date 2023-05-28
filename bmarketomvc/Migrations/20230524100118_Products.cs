using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bmarketomvc.Migrations
{
    /// <inheritdoc />
    public partial class Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTags",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTags", x => new { x.ProductId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ProductTags_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c853e18-0400-40cb-a4e3-ad8ccce39f1f",
                column: "ConcurrencyStamp",
                value: "b9e4be5a-5c51-4d06-8ac6-4694dafc7be8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea3bc81b-067d-4116-beab-193c8e836009",
                column: "ConcurrencyStamp",
                value: "a85bd63a-ca66-4bcf-8caf-10845d504cf2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48dd5706-f505-4a50-a123-dfb2cdf88171",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39c10569-46a6-4ae9-b067-8fea8cf90b21", "AQAAAAIAAYagAAAAEE3vVxh9Kdo3gQtq9GsJa174b6gXAeTDU9SGw+pByetsm0zfFC6vy4zIRAW9TJyhHw==", "b2473b08-4907-4f08-8f6d-c3ed35be1bf1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Mjuk och följsam. Design som tänjer gränser. Apple Watch Series 8 har en stor, kristallklar skärm som alltid är på. Skärmen sträcker sig hela vägen ut till kanterna och smälter elegant ihop med boettens kurvor.", "https://www.jumpplus.com/web/image/product.product/29365/image_1024/%5BMNP73VC-A%5D%20Apple%20Watch%20Series%208%20%20%28PRODUCT%29RED%20Aluminium%20Case%20with%20%28PRODUCT%29RED%20Sport%20Band%20%2841mm%2C%20GPS%29?unique=8c04e56", 30m, "Apple watch series" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "TagName" },
                values: new object[,]
                {
                    { 1, "new" },
                    { 2, "featured" },
                    { 3, "popular" }
                });

            migrationBuilder.InsertData(
                table: "ProductTags",
                columns: new[] { "ProductId", "TagId" },
                values: new object[] { 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_TagId",
                table: "ProductTags",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTags");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c853e18-0400-40cb-a4e3-ad8ccce39f1f",
                column: "ConcurrencyStamp",
                value: "e1db3a73-91de-4ab0-9572-de14dceeed6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea3bc81b-067d-4116-beab-193c8e836009",
                column: "ConcurrencyStamp",
                value: "46d82c48-a374-4ccd-8de1-318e5383e5e1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48dd5706-f505-4a50-a123-dfb2cdf88171",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "342008ee-943c-4a7a-b8d2-c034d2cebd6e", "AQAAAAIAAYagAAAAENq4YhOsACDII77n5p1EhPpnLkDX7DXjhqQoqASVmhNxrWNW97HhGcgYa+/WAyKYsw==", "e4323af3-984f-430e-ab12-dc81b2717b8c" });
        }
    }
}
