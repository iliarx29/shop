// <auto-generated />
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220404085109_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductBrandId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductBrandId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Apple iOS, 6.1 IPS screen (828x1792), Apple A13 Bionic, 4 GB RAM, 64 GB flash memory, 12 MP camera, 1 SIM",
                            Name = "Apple iPhone 11",
                            PictureUrl = "images/products/iphone11.jpeg",
                            Price = 600m,
                            ProductBrandId = 1,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Apple iOS, 6.7 OLED screen (1284x2778), Apple A15 Bionic, 6 GB RAM, 1 TB flash, 12 MP camera, 1 SIM",
                            Name = "Apple iPhone 13 Pro Max",
                            PictureUrl = "images/products/iphone13promax.jpg",
                            Price = 1500m,
                            ProductBrandId = 1,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Android, unshelled, 6.4 AMOLED screen (1080x2400), Google Tensor, 8 GB RAM, 128 GB flash memory, 50 MP camera, 4614 mAh battery, 2 SIM",
                            Name = "Google Pixel 6",
                            PictureUrl = "images/products/Pixel6.jpg",
                            Price = 800m,
                            ProductBrandId = 2,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "Android, 6.34 OLED screen (1080x2400), Qualcomm Snapdragon 765G, 6 GB RAM, 128 GB flash memory, 12.2 MP camera, 4680 mAh battery, 1 SIM",
                            Name = "Google Pixel 5a 5G",
                            PictureUrl = "images/products/pixel5a5G.jpg",
                            Price = 550m,
                            ProductBrandId = 2,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "Android, screen 6.7 AMOLED (1080x2640), Qualcomm Snapdragon 888, 8 GB RAM, 256 GB flash memory, 12 MP camera, 3300 mAh battery, 1 SIM",
                            Name = "Samsung Galaxy Z Flip3 5G",
                            PictureUrl = "images/products/galaxy-z-flip-5g.jpg",
                            Price = 1100m,
                            ProductBrandId = 4,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 6,
                            Description = "Android, screen 6.5 AMOLED (1080x2400), Qualcomm Snapdragon 720G, 8 GB RAM, 256 GB flash memory, memory cards, 64 MP camera, 4500 mAh battery, 2 SIM",
                            Name = "Samsung Galaxy A52",
                            PictureUrl = "images/products/galaxyA52.jpg",
                            Price = 400m,
                            ProductBrandId = 4,
                            ProductTypeId = 1
                        },
                        new
                        {
                            Id = 7,
                            Description = "15.6 1920 x 1080 OLED, 60 Hz, non-touch, Intel Core i5 1135G7 2400 MHz, 16 GB DDR4, SSD 512 GB, integrated graphics, no OS, cover color black",
                            Name = "ASUS VivoBook 15",
                            PictureUrl = "images/products/vivobook15.jpg",
                            Price = 1000m,
                            ProductBrandId = 5,
                            ProductTypeId = 2
                        },
                        new
                        {
                            Id = 8,
                            Description = "15.6 1920 x 1080 IPS, 144Hz, Non-Touch, AMD Ryzen 7 4800H 2900MHz, 16GB DDR4, 512GB SSD, NVIDIA GeForce GTX 1650 4GB GDDR6, No OS, Dark Gray Lid",
                            Name = "ASUS ROG Strix G15",
                            PictureUrl = "images/products/rogStrixG15.jpg",
                            Price = 1500m,
                            ProductBrandId = 5,
                            ProductTypeId = 2
                        },
                        new
                        {
                            Id = 9,
                            Description = "16.1 1920 x 1080 IPS, 60 Hz, non-touch, AMD Ryzen 5 4500U 2300 MHz, 16 GB DDR4, SSD 512 GB, integrated graphics card, cover color dark gray",
                            Name = "Xiaomi RedmiBook 16",
                            PictureUrl = "images/products/xiaomi-redmibook-16.jpg",
                            Price = 1000m,
                            ProductBrandId = 6,
                            ProductTypeId = 2
                        },
                        new
                        {
                            Id = 10,
                            Description = "compact camera, matrix 1 20.1 MP, F1.8-2.8 24-70 mm, Wi-Fi",
                            Name = "Sony ZV-1",
                            PictureUrl = "images/products/sonyZV-1.jpg",
                            Price = 850m,
                            ProductBrandId = 3,
                            ProductTypeId = 4
                        },
                        new
                        {
                            Id = 11,
                            Description = "mirrorless camera, Sony A mount, Full frame sensor (full frame) 24.3 MP, without lens (body), Wi-Fi",
                            Name = "Sony Alpha a7 II Body",
                            PictureUrl = "images/products/sony_a7_ii_body.jpg",
                            Price = 1500m,
                            ProductBrandId = 3,
                            ProductTypeId = 4
                        },
                        new
                        {
                            Id = 12,
                            Description = "13.3, 1920 x 1080 IPS, 60Hz, non-touch, Intel Core i5 10210U 1600MHz, 8GB DDR4, 256GB SSD, integrated graphics, Windows 10, cover color silver",
                            Name = "Samsung Galaxy Book Ion 13",
                            PictureUrl = "images/products/Samsung_Galaxy_Book_Ion_13_3.jpg",
                            Price = 1000m,
                            ProductBrandId = 4,
                            ProductTypeId = 2
                        },
                        new
                        {
                            Id = 13,
                            Description = "31.5, 16:9, 2560x1440, VA, Curved (1000R), 240Hz, AMD FreeSync Premium Pro/NVIDIA G-Sync Compatible, HDMI+DisplayPort, Height Adjust, Portrait Mode",
                            Name = "Samsung Odyssey G7",
                            PictureUrl = "images/products/samsung-odyssey-g7.jpg",
                            Price = 870m,
                            ProductBrandId = 4,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 14,
                            Description = "34, 21:9, 3440x1440, VA, Curved (1500R), 144Hz, AMD FreeSync Premium, HDMI+DisplayPort, Height Adjustable",
                            Name = "Xiaomi Mi Curved Gaming Monitor 34",
                            PictureUrl = "images/products/xiaomi_mi_curved_gaming_monitor_34.jpg",
                            Price = 600m,
                            ProductBrandId = 6,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 15,
                            Description = "27, 16:9, 2560x1440, IPS, 165Hz, AMD FreeSync, HDMI+DisplayPort interfaces, portrait mode",
                            Name = "Xiaomi Mi 2K Gaming Monitor 27",
                            PictureUrl = "images/products/xiaomi_mi_gaming_display27.jpg",
                            Price = 720m,
                            ProductBrandId = 6,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 16,
                            Description = "23.8, 16:9, 1920x1080, IPS, 144Hz, AMD FreeSync Premium/NVIDIA G-Sync compatible, HDMI+DisplayPor interfaces",
                            Name = "LG UltraGear",
                            PictureUrl = "images/products/LGUltraGear.jpg",
                            Price = 350m,
                            ProductBrandId = 7,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 17,
                            Description = "27, 16:9, 3840x2160, IPS, 60Hz, AMD FreeSync, HDMI+DisplayPort interfaces",
                            Name = "LG 27UL500-W",
                            PictureUrl = "images/products/Lg27UL500-w.jpg",
                            Price = 400m,
                            ProductBrandId = 7,
                            ProductTypeId = 3
                        },
                        new
                        {
                            Id = 18,
                            Description = "35, 21:9, 3440x1440, VA, Curved (1800R), 100Hz, AMD FreeSync, Speakers, HDMI+DisplayPort+USB Type-C, Height Adjustable",
                            Name = "LG 35WN75C-B",
                            PictureUrl = "images/products/Lg35WN75C-B.jpg",
                            Price = 550m,
                            ProductBrandId = 7,
                            ProductTypeId = 3
                        });
                });

            modelBuilder.Entity("Core.Entities.ProductBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProductBrands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Google"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sony"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Samsung"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Asus"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Xiaomi"
                        },
                        new
                        {
                            Id = 7,
                            Name = "LG"
                        });
                });

            modelBuilder.Entity("Core.Entities.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Smartphones"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Notebooks"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Monitors"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Cameras"
                        });
                });

            modelBuilder.Entity("Core.Entities.Product", b =>
                {
                    b.HasOne("Core.Entities.ProductBrand", "ProductBrand")
                        .WithMany()
                        .HasForeignKey("ProductBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductBrand");

                    b.Navigation("ProductType");
                });
#pragma warning restore 612, 618
        }
    }
}
