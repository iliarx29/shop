using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PictureUrl = table.Column<string>(type: "TEXT", nullable: true),
                    ProductTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductBrandId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductBrands_ProductBrandId",
                        column: x => x.ProductBrandId,
                        principalTable: "ProductBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductBrands",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Apple" });

            migrationBuilder.InsertData(
                table: "ProductBrands",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Google" });

            migrationBuilder.InsertData(
                table: "ProductBrands",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Sony" });

            migrationBuilder.InsertData(
                table: "ProductBrands",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Samsung" });

            migrationBuilder.InsertData(
                table: "ProductBrands",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Asus" });

            migrationBuilder.InsertData(
                table: "ProductBrands",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Xiaomi" });

            migrationBuilder.InsertData(
                table: "ProductBrands",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "LG" });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Smartphones" });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Notebooks" });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Monitors" });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Cameras" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[] { 1, "Apple iOS, 6.1 IPS screen (828x1792), Apple A13 Bionic, 4 GB RAM, 64 GB flash memory, 12 MP camera, 1 SIM", "Apple iPhone 11", "images/products/iphone11.jpeg", 600m, 1, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[] { 2, "Apple iOS, 6.7 OLED screen (1284x2778), Apple A15 Bionic, 6 GB RAM, 1 TB flash, 12 MP camera, 1 SIM", "Apple iPhone 13 Pro Max", "images/products/iphone13promax.jpg", 1500m, 1, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[] { 3, "Android, unshelled, 6.4 AMOLED screen (1080x2400), Google Tensor, 8 GB RAM, 128 GB flash memory, 50 MP camera, 4614 mAh battery, 2 SIM", "Google Pixel 6", "images/products/Pixel6.jpg", 800m, 2, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[] { 4, "Android, 6.34 OLED screen (1080x2400), Qualcomm Snapdragon 765G, 6 GB RAM, 128 GB flash memory, 12.2 MP camera, 4680 mAh battery, 1 SIM", "Google Pixel 5a 5G", "images/products/pixel5a5G.jpg", 550m, 2, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[] { 5, "Android, screen 6.7 AMOLED (1080x2640), Qualcomm Snapdragon 888, 8 GB RAM, 256 GB flash memory, 12 MP camera, 3300 mAh battery, 1 SIM", "Samsung Galaxy Z Flip3 5G", "images/products/galaxy-z-flip-5g.jpg", 1100m, 4, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[] { 6, "Android, screen 6.5 AMOLED (1080x2400), Qualcomm Snapdragon 720G, 8 GB RAM, 256 GB flash memory, memory cards, 64 MP camera, 4500 mAh battery, 2 SIM", "Samsung Galaxy A52", "images/products/galaxyA52.jpg", 400m, 4, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[] { 7, "15.6 1920 x 1080 OLED, 60 Hz, non-touch, Intel Core i5 1135G7 2400 MHz, 16 GB DDR4, SSD 512 GB, integrated graphics, no OS, cover color black", "ASUS VivoBook 15", "images/products/vivobook15.jpg", 1000m, 5, 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[] { 8, "15.6 1920 x 1080 IPS, 144Hz, Non-Touch, AMD Ryzen 7 4800H 2900MHz, 16GB DDR4, 512GB SSD, NVIDIA GeForce GTX 1650 4GB GDDR6, No OS, Dark Gray Lid", "ASUS ROG Strix G15", "images/products/rogStrixG15.jpg", 1500m, 5, 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[] { 9, "16.1 1920 x 1080 IPS, 60 Hz, non-touch, AMD Ryzen 5 4500U 2300 MHz, 16 GB DDR4, SSD 512 GB, integrated graphics card, cover color dark gray", "Xiaomi RedmiBook 16", "images/products/xiaomi-redmibook-16.jpg", 1000m, 6, 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[] { 10, "compact camera, matrix 1 20.1 MP, F1.8-2.8 24-70 mm, Wi-Fi", "Sony ZV-1", "images/products/sonyZV-1.jpg", 850m, 3, 4 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[] { 11, "mirrorless camera, Sony A mount, Full frame sensor (full frame) 24.3 MP, without lens (body), Wi-Fi", "Sony Alpha a7 II Body", "images/products/sony_a7_ii_body.jpg", 1500m, 3, 4 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[] { 12, "13.3, 1920 x 1080 IPS, 60Hz, non-touch, Intel Core i5 10210U 1600MHz, 8GB DDR4, 256GB SSD, integrated graphics, Windows 10, cover color silver", "Samsung Galaxy Book Ion 13", "images/products/Samsung_Galaxy_Book_Ion_13_3.jpg", 1000m, 4, 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[] { 13, "31.5, 16:9, 2560x1440, VA, Curved (1000R), 240Hz, AMD FreeSync Premium Pro/NVIDIA G-Sync Compatible, HDMI+DisplayPort, Height Adjust, Portrait Mode", "Samsung Odyssey G7", "images/products/samsung-odyssey-g7.jpg", 870m, 4, 3 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[] { 14, "34, 21:9, 3440x1440, VA, Curved (1500R), 144Hz, AMD FreeSync Premium, HDMI+DisplayPort, Height Adjustable", "Xiaomi Mi Curved Gaming Monitor 34", "images/products/xiaomi_mi_curved_gaming_monitor_34.jpg", 600m, 6, 3 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[] { 15, "27, 16:9, 2560x1440, IPS, 165Hz, AMD FreeSync, HDMI+DisplayPort interfaces, portrait mode", "Xiaomi Mi 2K Gaming Monitor 27", "images/products/xiaomi_mi_gaming_display27.jpg", 720m, 6, 3 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[] { 16, "23.8, 16:9, 1920x1080, IPS, 144Hz, AMD FreeSync Premium/NVIDIA G-Sync compatible, HDMI+DisplayPor interfaces", "LG UltraGear", "images/products/LGUltraGear.jpg", 350m, 7, 3 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[] { 17, "27, 16:9, 3840x2160, IPS, 60Hz, AMD FreeSync, HDMI+DisplayPort interfaces", "LG 27UL500-W", "images/products/Lg27UL500-w.jpg", 400m, 7, 3 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[] { 18, "35, 21:9, 3440x1440, VA, Curved (1800R), 100Hz, AMD FreeSync, Speakers, HDMI+DisplayPort+USB Type-C, Height Adjustable", "LG 35WN75C-B", "images/products/Lg35WN75C-B.jpg", 550m, 7, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductBrandId",
                table: "Products",
                column: "ProductBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductBrands");

            migrationBuilder.DropTable(
                name: "ProductTypes");
        }
    }
}
