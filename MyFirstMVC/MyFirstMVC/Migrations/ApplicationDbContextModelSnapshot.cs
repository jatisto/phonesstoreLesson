﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFirstMVC.Models;

namespace MyFirstMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyFirstMVC.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("ParentCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, Name = "iOS" },
                        new { Id = 2, Name = "Android OS" },
                        new { Id = 3, Name = "BlackBerry OS" }
                    );
                });

            modelBuilder.Entity("MyFirstMVC.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new { Id = 1, Name = "Apple" },
                        new { Id = 2, Name = "Samsung" },
                        new { Id = 3, Name = "Nokia" },
                        new { Id = 4, Name = "Xiaomi" },
                        new { Id = 5, Name = "LG" },
                        new { Id = 6, Name = "Huawei" },
                        new { Id = 7, Name = "Sony" },
                        new { Id = 8, Name = "BlackBerry" },
                        new { Id = 9, Name = "Philips" }
                    );
                });

            modelBuilder.Entity("MyFirstMVC.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Message");

                    b.Property<int>("PhoneId");

                    b.Property<int>("Rating");

                    b.HasKey("Id");

                    b.HasIndex("PhoneId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("MyFirstMVC.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Addres");

                    b.Property<string>("ContactPhone");

                    b.Property<int>("PhoneId");

                    b.Property<string>("User");

                    b.HasKey("Id");

                    b.HasIndex("PhoneId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MyFirstMVC.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AssemblyDate");

                    b.Property<int>("CategoryId");

                    b.Property<int>("CompanyId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Phones");

                    b.HasData(
                        new { Id = 1, AssemblyDate = new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), CategoryId = 1, CompanyId = 1, Name = "Apple iPhone 7 256Gb Red", Price = 7440.0 },
                        new { Id = 2, AssemblyDate = new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), CategoryId = 1, CompanyId = 1, Name = "Apple iPhone 6S (Space Grey, 32GB)", Price = 3050.0 },
                        new { Id = 3, AssemblyDate = new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), CategoryId = 1, CompanyId = 1, Name = "Apple iPhone X (Space Grey, 256GB)", Price = 9999.9 },
                        new { Id = 4, AssemblyDate = new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), CategoryId = 2, CompanyId = 2, Name = "Samsung On7 Pro (Gold)", Price = 799.0 },
                        new { Id = 5, AssemblyDate = new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), CategoryId = 2, CompanyId = 2, Name = "Samsung Galaxy On7 Prime (Gold, 4GB RAM + 64GB Memory)", Price = 1399.0 },
                        new { Id = 6, AssemblyDate = new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), CategoryId = 2, CompanyId = 4, Name = "Redmi 6 Pro (Black, 32GB)", Price = 1149.9 },
                        new { Id = 7, AssemblyDate = new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), CategoryId = 2, CompanyId = 4, Name = "Redmi Y2 (Rose Gold, 32GB)", Price = 999.9 },
                        new { Id = 8, AssemblyDate = new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), CategoryId = 2, CompanyId = 5, Name = "LG Q6 (Black, 18:9 FullVision Display)", Price = 1182.0 },
                        new { Id = 9, AssemblyDate = new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), CategoryId = 2, CompanyId = 5, Name = "LG V30+ (18:9 OLED FullVisionTM, 128GB, Black)", Price = 3496.3 },
                        new { Id = 10, AssemblyDate = new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), CategoryId = 3, CompanyId = 8, Name = "BlackBerry Passport 32GB (White)", Price = 2699.9 },
                        new { Id = 11, AssemblyDate = new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), CategoryId = 2, CompanyId = 6, Name = "Huawei P20 Pro Blue (40MP Leica Triple Camera, 6GB+128GB)", Price = 6499.9 },
                        new { Id = 12, AssemblyDate = new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), CategoryId = 2, CompanyId = 3, Name = "Nokia 6.1 (2018) (4GB + 64GB, Blue-Gold)", Price = 1595.0 },
                        new { Id = 13, AssemblyDate = new DateTime(1989, 7, 20, 17, 57, 7, 770, DateTimeKind.Unspecified), CategoryId = 2, CompanyId = 7, Name = "Sony Xperia R1 Plus Dual SIM (Black)", Price = 1189.9 }
                    );
                });

            modelBuilder.Entity("MyFirstMVC.Models.PhoneOnStock", b =>
                {
                    b.Property<int>("PhoneId");

                    b.Property<int>("StockId");

                    b.Property<int>("Quantity");

                    b.HasKey("PhoneId", "StockId");

                    b.HasIndex("StockId");

                    b.ToTable("PhonesOnStocks");
                });

            modelBuilder.Entity("MyFirstMVC.Models.Shaurma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<double>("Price");

                    b.Property<int>("ShaurmaSize");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Shaurmas");
                });

            modelBuilder.Entity("MyFirstMVC.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Stocks");

                    b.HasData(
                        new { Id = 1, Name = "Склад 1" },
                        new { Id = 2, Name = "Склад 2" },
                        new { Id = 3, Name = "Склад 3" }
                    );
                });

            modelBuilder.Entity("MyFirstMVC.Models.Category", b =>
                {
                    b.HasOne("MyFirstMVC.Models.Category", "ParentCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentCategoryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyFirstMVC.Models.Feedback", b =>
                {
                    b.HasOne("MyFirstMVC.Models.Phone", "Phone")
                        .WithMany("Feedbacks")
                        .HasForeignKey("PhoneId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyFirstMVC.Models.Order", b =>
                {
                    b.HasOne("MyFirstMVC.Models.Phone", "Phone")
                        .WithMany("Orders")
                        .HasForeignKey("PhoneId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyFirstMVC.Models.Phone", b =>
                {
                    b.HasOne("MyFirstMVC.Models.Category", "Category")
                        .WithMany("Phones")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MyFirstMVC.Models.Company", "Company")
                        .WithMany("Phones")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyFirstMVC.Models.PhoneOnStock", b =>
                {
                    b.HasOne("MyFirstMVC.Models.Phone", "Phone")
                        .WithMany("PhoneOnStocks")
                        .HasForeignKey("PhoneId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyFirstMVC.Models.Stock", "Stock")
                        .WithMany("PhoneOnStocks")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyFirstMVC.Models.Shaurma", b =>
                {
                    b.HasOne("MyFirstMVC.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
