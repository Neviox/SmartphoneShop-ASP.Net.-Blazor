﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartphoneShop.Server.Data;

#nullable disable

namespace SmartphoneShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SmartphoneShop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Izdržljiv i zapanjujući dizajn, s nehrđajućim čelikom kirurške kvalitete, keramičkim štitom i vodećom vodootpornošću IP68.",
                            ImageUrl = "https://technostore.hr/upload/products/iphone_13_pro_max_graphite_pdp_image_position_1a_wwen_4_21.jpg",
                            Name = "Iphone 13 Pro Max",
                            Price = 0m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Izdržljiv i zapanjujući dizajn, s nehrđajućim čelikom kirurške kvalitete, keramičkim štitom i vodećom vodootpornošću IP68.",
                            ImageUrl = "http://bbelektronika.hr/wp-content/uploads/2021/10/apple-iphone-13.jpg",
                            Name = "Iphone 13 Pro",
                            Price = 0m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Naš najnapredniji sustav s dvojnom kamerom. Čip brži od konkurencije. Do 2,5 sati dulje trajanje baterije.",
                            ImageUrl = "https://s3.eu-central-1.amazonaws.com/amadeus2.hr/img/7964-13_pro.png",
                            Name = "Iphone 13",
                            Price = 0m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Učinite svaki dan spektakularnim. Predstavljamo Galaxy S22 5G i S22 Plus 5G s Nightography kamerom, pohranom za Vaše snimke i s baterijom koja traje duže.",
                            ImageUrl = "https://smartlab.hr/cms/wp-content/uploads/2022/04/samsung_galaxy_s22_8gb_128gb_negro_001_l.jpg",
                            Name = "Samsung Galaxy S22",
                            Price = 0m
                        },
                        new
                        {
                            Id = 5,
                            Description = "Stavljajući velike zaslone i bateriju u kompaktno kućište, Huawei P50 Pro je lakši od prethodne generacije i bolje leži u ruci.",
                            ImageUrl = "https://bazzar.hr/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBMjNiNUE9PSIsImV4cCI6bnVsbCwicHVyIjoiYmxvYl9pZCJ9fQ==--130f390e170100dd7f0cc1c9022050a6bc3b98bb/mobitel-huawei-p50-pro-66-8gb-256gb-crni-65715_3.jpg",
                            Name = "Huawei P50 Pro",
                            Price = 0m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
