using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description of product 1", "Product 1", 960m },
                    { 73, "Description of product 73", "Product 73", 243m },
                    { 72, "Description of product 72", "Product 72", 344m },
                    { 71, "Description of product 71", "Product 71", 223m },
                    { 70, "Description of product 70", "Product 70", 871m },
                    { 69, "Description of product 69", "Product 69", 885m },
                    { 68, "Description of product 68", "Product 68", 216m },
                    { 67, "Description of product 67", "Product 67", 121m },
                    { 66, "Description of product 66", "Product 66", 686m },
                    { 65, "Description of product 65", "Product 65", 356m },
                    { 64, "Description of product 64", "Product 64", 413m },
                    { 63, "Description of product 63", "Product 63", 380m },
                    { 62, "Description of product 62", "Product 62", 630m },
                    { 61, "Description of product 61", "Product 61", 515m },
                    { 60, "Description of product 60", "Product 60", 141m },
                    { 59, "Description of product 59", "Product 59", 975m },
                    { 58, "Description of product 58", "Product 58", 520m },
                    { 57, "Description of product 57", "Product 57", 892m },
                    { 56, "Description of product 56", "Product 56", 430m },
                    { 55, "Description of product 55", "Product 55", 945m },
                    { 54, "Description of product 54", "Product 54", 376m },
                    { 53, "Description of product 53", "Product 53", 664m },
                    { 74, "Description of product 74", "Product 74", 215m },
                    { 52, "Description of product 52", "Product 52", 103m },
                    { 75, "Description of product 75", "Product 75", 268m },
                    { 77, "Description of product 77", "Product 77", 915m },
                    { 98, "Description of product 98", "Product 98", 401m },
                    { 97, "Description of product 97", "Product 97", 551m },
                    { 96, "Description of product 96", "Product 96", 115m },
                    { 95, "Description of product 95", "Product 95", 311m },
                    { 94, "Description of product 94", "Product 94", 857m },
                    { 93, "Description of product 93", "Product 93", 527m },
                    { 92, "Description of product 92", "Product 92", 409m },
                    { 91, "Description of product 91", "Product 91", 237m },
                    { 90, "Description of product 90", "Product 90", 428m },
                    { 89, "Description of product 89", "Product 89", 921m },
                    { 88, "Description of product 88", "Product 88", 606m },
                    { 87, "Description of product 87", "Product 87", 757m },
                    { 86, "Description of product 86", "Product 86", 179m },
                    { 85, "Description of product 85", "Product 85", 960m },
                    { 84, "Description of product 84", "Product 84", 718m },
                    { 83, "Description of product 83", "Product 83", 433m },
                    { 82, "Description of product 82", "Product 82", 157m },
                    { 81, "Description of product 81", "Product 81", 788m },
                    { 80, "Description of product 80", "Product 80", 619m },
                    { 79, "Description of product 79", "Product 79", 644m },
                    { 78, "Description of product 78", "Product 78", 332m },
                    { 76, "Description of product 76", "Product 76", 125m },
                    { 51, "Description of product 51", "Product 51", 737m },
                    { 50, "Description of product 50", "Product 50", 436m },
                    { 49, "Description of product 49", "Product 49", 641m },
                    { 22, "Description of product 22", "Product 22", 630m },
                    { 21, "Description of product 21", "Product 21", 857m },
                    { 20, "Description of product 20", "Product 20", 813m },
                    { 19, "Description of product 19", "Product 19", 843m },
                    { 18, "Description of product 18", "Product 18", 142m },
                    { 17, "Description of product 17", "Product 17", 746m },
                    { 16, "Description of product 16", "Product 16", 952m },
                    { 15, "Description of product 15", "Product 15", 900m },
                    { 14, "Description of product 14", "Product 14", 644m },
                    { 13, "Description of product 13", "Product 13", 983m },
                    { 12, "Description of product 12", "Product 12", 904m },
                    { 11, "Description of product 11", "Product 11", 109m },
                    { 10, "Description of product 10", "Product 10", 439m },
                    { 9, "Description of product 9", "Product 9", 110m },
                    { 8, "Description of product 8", "Product 8", 435m },
                    { 7, "Description of product 7", "Product 7", 605m },
                    { 6, "Description of product 6", "Product 6", 841m },
                    { 5, "Description of product 5", "Product 5", 631m },
                    { 4, "Description of product 4", "Product 4", 950m },
                    { 3, "Description of product 3", "Product 3", 190m },
                    { 2, "Description of product 2", "Product 2", 286m },
                    { 23, "Description of product 23", "Product 23", 393m },
                    { 24, "Description of product 24", "Product 24", 669m },
                    { 25, "Description of product 25", "Product 25", 974m },
                    { 26, "Description of product 26", "Product 26", 589m },
                    { 48, "Description of product 48", "Product 48", 367m },
                    { 47, "Description of product 47", "Product 47", 800m },
                    { 46, "Description of product 46", "Product 46", 454m },
                    { 45, "Description of product 45", "Product 45", 125m },
                    { 44, "Description of product 44", "Product 44", 161m },
                    { 43, "Description of product 43", "Product 43", 714m },
                    { 42, "Description of product 42", "Product 42", 831m },
                    { 41, "Description of product 41", "Product 41", 645m },
                    { 40, "Description of product 40", "Product 40", 727m },
                    { 39, "Description of product 39", "Product 39", 899m },
                    { 99, "Description of product 99", "Product 99", 805m },
                    { 38, "Description of product 38", "Product 38", 502m },
                    { 36, "Description of product 36", "Product 36", 129m },
                    { 35, "Description of product 35", "Product 35", 758m },
                    { 34, "Description of product 34", "Product 34", 867m },
                    { 33, "Description of product 33", "Product 33", 882m },
                    { 32, "Description of product 32", "Product 32", 422m },
                    { 31, "Description of product 31", "Product 31", 182m },
                    { 30, "Description of product 30", "Product 30", 697m },
                    { 29, "Description of product 29", "Product 29", 154m },
                    { 28, "Description of product 28", "Product 28", 975m },
                    { 27, "Description of product 27", "Product 27", 425m },
                    { 37, "Description of product 37", "Product 37", 829m },
                    { 100, "Description of product 100", "Product 100", 438m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 59 },
                    { 73, 73, 1 },
                    { 72, 72, 40 },
                    { 71, 71, 16 },
                    { 70, 70, 85 },
                    { 69, 69, 94 },
                    { 68, 68, 83 },
                    { 67, 67, 0 },
                    { 66, 66, 67 },
                    { 65, 65, 53 },
                    { 64, 64, 29 },
                    { 63, 63, 6 },
                    { 62, 62, 26 },
                    { 61, 61, 20 },
                    { 60, 60, 2 },
                    { 59, 59, 61 },
                    { 58, 58, 52 },
                    { 57, 57, 71 },
                    { 56, 56, 97 },
                    { 55, 55, 92 },
                    { 54, 54, 71 },
                    { 53, 53, 36 },
                    { 74, 74, 77 },
                    { 52, 52, 34 },
                    { 75, 75, 28 },
                    { 77, 77, 23 },
                    { 98, 98, 7 },
                    { 97, 97, 48 },
                    { 96, 96, 27 },
                    { 95, 95, 99 },
                    { 94, 94, 93 },
                    { 93, 93, 35 },
                    { 92, 92, 41 },
                    { 91, 91, 54 },
                    { 90, 90, 54 },
                    { 89, 89, 28 },
                    { 88, 88, 57 },
                    { 87, 87, 69 },
                    { 86, 86, 59 },
                    { 85, 85, 5 },
                    { 84, 84, 39 },
                    { 83, 83, 52 },
                    { 82, 82, 74 },
                    { 81, 81, 91 },
                    { 80, 80, 1 },
                    { 79, 79, 20 },
                    { 78, 78, 50 },
                    { 76, 76, 46 },
                    { 51, 51, 62 },
                    { 50, 50, 96 },
                    { 49, 49, 47 },
                    { 22, 22, 61 },
                    { 21, 21, 0 },
                    { 20, 20, 81 },
                    { 19, 19, 97 },
                    { 18, 18, 97 },
                    { 17, 17, 37 },
                    { 16, 16, 11 },
                    { 15, 15, 11 },
                    { 14, 14, 46 },
                    { 13, 13, 4 },
                    { 12, 12, 29 },
                    { 11, 11, 73 },
                    { 10, 10, 47 },
                    { 9, 9, 97 },
                    { 8, 8, 41 },
                    { 7, 7, 26 },
                    { 6, 6, 29 },
                    { 5, 5, 5 },
                    { 4, 4, 43 },
                    { 3, 3, 1 },
                    { 2, 2, 37 },
                    { 23, 23, 66 },
                    { 24, 24, 49 },
                    { 25, 25, 81 },
                    { 26, 26, 3 },
                    { 48, 48, 33 },
                    { 47, 47, 11 },
                    { 46, 46, 80 },
                    { 45, 45, 29 },
                    { 44, 44, 15 },
                    { 43, 43, 37 },
                    { 42, 42, 54 },
                    { 41, 41, 53 },
                    { 40, 40, 20 },
                    { 39, 39, 96 },
                    { 99, 99, 61 },
                    { 38, 38, 97 },
                    { 36, 36, 26 },
                    { 35, 35, 52 },
                    { 34, 34, 21 },
                    { 33, 33, 29 },
                    { 32, 32, 6 },
                    { 31, 31, 93 },
                    { 30, 30, 67 },
                    { 29, 29, 35 },
                    { 28, 28, 0 },
                    { 27, 27, 8 },
                    { 37, 37, 94 },
                    { 100, 100, 61 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
