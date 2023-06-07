﻿// <auto-generated />
using CRUD_Practises.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD_Practises.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20230605100938_AddSeedData")]
    partial class AddSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRUD_Practises.Models.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = "P001",
                            Category = "3C",
                            Price = 45000m,
                            ProductName = "Iphone 14",
                            Quantity = 23
                        },
                        new
                        {
                            ProductId = "P002",
                            Category = "3C",
                            Price = 23000m,
                            ProductName = "SamSung A52",
                            Quantity = 10
                        },
                        new
                        {
                            ProductId = "P003",
                            Category = "3C",
                            Price = 35200m,
                            ProductName = "SamSung S20",
                            Quantity = 15
                        },
                        new
                        {
                            ProductId = "P004",
                            Category = "飲料",
                            Price = 370m,
                            ProductName = "青森頻果原汁",
                            Quantity = 100
                        },
                        new
                        {
                            ProductId = "P005",
                            Category = "飲料",
                            Price = 25m,
                            ProductName = "綠茶(瓶裝)",
                            Quantity = 1000
                        },
                        new
                        {
                            ProductId = "P006",
                            Category = "食品",
                            Price = 50m,
                            ProductName = "辛拉麵(袋裝)",
                            Quantity = 1000
                        },
                        new
                        {
                            ProductId = "P007",
                            Category = "食品",
                            Price = 53m,
                            ProductName = "台酒麻油雞泡麵(碗裝)",
                            Quantity = 5000
                        },
                        new
                        {
                            ProductId = "P008",
                            Category = "食品",
                            Price = 53m,
                            ProductName = "台酒花雕雞泡麵(碗裝)",
                            Quantity = 10000
                        },
                        new
                        {
                            ProductId = "P009",
                            Category = "食品",
                            Price = 53m,
                            ProductName = "台酒酸菜牛肉泡麵(碗裝)",
                            Quantity = 12000
                        },
                        new
                        {
                            ProductId = "P010",
                            Category = "食品",
                            Price = 53m,
                            ProductName = "滿漢大餐珍味牛肉麵(碗裝)",
                            Quantity = 25080
                        },
                        new
                        {
                            ProductId = "P011",
                            Category = "飲料",
                            Price = 35m,
                            ProductName = "烏龍茶(瓶裝)",
                            Quantity = 10000
                        },
                        new
                        {
                            ProductId = "P012",
                            Category = "飲料",
                            Price = 20m,
                            ProductName = "錫蘭奶茶(瓶裝)",
                            Quantity = 5000
                        },
                        new
                        {
                            ProductId = "P013",
                            Category = "飲料",
                            Price = 25m,
                            ProductName = "紅茶(瓶裝)",
                            Quantity = 1230
                        },
                        new
                        {
                            ProductId = "P014",
                            Category = "食品",
                            Price = 53m,
                            ProductName = "台酒花雕雞泡麵(碗裝)",
                            Quantity = 10000
                        },
                        new
                        {
                            ProductId = "P015",
                            Category = "食品",
                            Price = 45m,
                            ProductName = "台酒花雕雞泡麵(袋裝)",
                            Quantity = 250000
                        },
                        new
                        {
                            ProductId = "P016",
                            Category = "3C",
                            Price = 53420m,
                            ProductName = "Ipad Pro",
                            Quantity = 1000
                        },
                        new
                        {
                            ProductId = "P017",
                            Category = "3C",
                            Price = 33023m,
                            ProductName = "筆記型電腦",
                            Quantity = 1235
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
