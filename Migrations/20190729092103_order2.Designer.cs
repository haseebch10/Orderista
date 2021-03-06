﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Orderista.Models;

namespace Orderista.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190729092103_order2")]
    partial class order2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Orderista.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<int?>("Hostel");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int>("RollNo");

                    b.Property<int>("Room");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Orderista.Models.Cart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemMId");

                    b.Property<int?>("OrderId");

                    b.Property<int>("Quantity");

                    b.Property<string>("UserId");

                    b.HasKey("id");

                    b.HasIndex("ItemMId");

                    b.HasIndex("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("carts");

                    b.HasData(
                        new
                        {
                            id = 1,
                            ItemMId = 0,
                            Quantity = 0
                        });
                });

            modelBuilder.Entity("Orderista.Models.Customer", b =>
                {
                    b.Property<int>("CuId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int?>("Hostel");

                    b.Property<string>("Name");

                    b.Property<int>("Phone")
                        .HasMaxLength(11);

                    b.Property<int>("Room")
                        .HasMaxLength(3);

                    b.HasKey("CuId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Orderista.Models.MenuItem", b =>
                {
                    b.Property<int>("MId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<string>("ItemName");

                    b.Property<string>("Photopath");

                    b.Property<int>("Price");

                    b.Property<int>("RestaurantRuId");

                    b.HasKey("MId");

                    b.HasIndex("RestaurantRuId");

                    b.ToTable("Menu");

                    b.HasData(
                        new
                        {
                            MId = 1,
                            Category = "Soup",
                            ItemName = "Hot & Sour Soup",
                            Price = 150,
                            RestaurantRuId = 4
                        },
                        new
                        {
                            MId = 2,
                            Category = "Soup",
                            ItemName = "Thai Soup",
                            Price = 150,
                            RestaurantRuId = 4
                        },
                        new
                        {
                            MId = 3,
                            Category = "Soup",
                            ItemName = "Chicken Corn Soup",
                            Price = 150,
                            RestaurantRuId = 4
                        },
                        new
                        {
                            MId = 4,
                            Category = "Specials",
                            ItemName = "Chicken Chilli Dry",
                            Price = 290,
                            RestaurantRuId = 4
                        },
                        new
                        {
                            MId = 5,
                            Category = "Specials",
                            ItemName = "Fish Chilli Dry",
                            Price = 390,
                            RestaurantRuId = 4
                        },
                        new
                        {
                            MId = 6,
                            Category = "Specials",
                            ItemName = "Beef Chilli Dry",
                            Price = 390,
                            RestaurantRuId = 4
                        },
                        new
                        {
                            MId = 7,
                            Category = "Specials",
                            ItemName = "Crispy Honey Beef",
                            Price = 350,
                            RestaurantRuId = 4
                        },
                        new
                        {
                            MId = 8,
                            Category = "Noodles",
                            ItemName = "Chicken Chowmein",
                            Price = 290,
                            RestaurantRuId = 4
                        },
                        new
                        {
                            MId = 9,
                            Category = "Noodles",
                            ItemName = "American Choupsuey",
                            Price = 290,
                            RestaurantRuId = 4
                        },
                        new
                        {
                            MId = 10,
                            Category = "Starters",
                            ItemName = "Honey Wings",
                            Price = 220,
                            RestaurantRuId = 4
                        },
                        new
                        {
                            MId = 11,
                            Category = "Starters",
                            ItemName = "Drum Sticks",
                            Price = 260,
                            RestaurantRuId = 4
                        },
                        new
                        {
                            MId = 12,
                            Category = "Starters",
                            ItemName = "Spring Rolls",
                            Price = 190,
                            RestaurantRuId = 4
                        },
                        new
                        {
                            MId = 13,
                            Category = "Chicken",
                            ItemName = "Hot Garlic",
                            Price = 290,
                            RestaurantRuId = 4
                        },
                        new
                        {
                            MId = 14,
                            Category = "Chicken",
                            ItemName = "Szechuan",
                            Price = 290,
                            RestaurantRuId = 4
                        },
                        new
                        {
                            MId = 15,
                            Category = "Chicken",
                            ItemName = "Kung Pao",
                            Price = 290,
                            RestaurantRuId = 4
                        },
                        new
                        {
                            MId = 16,
                            Category = "Chicken",
                            ItemName = "Manchurian",
                            Price = 290,
                            RestaurantRuId = 4
                        },
                        new
                        {
                            MId = 17,
                            Category = "Chicken",
                            ItemName = "Black Pepper",
                            Price = 290,
                            RestaurantRuId = 4
                        });
                });

            modelBuilder.Entity("Orderista.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("Orderista.Models.Restaurant", b =>
                {
                    b.Property<int>("RuId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("Phone");

                    b.HasKey("RuId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            RuId = 1,
                            Name = "Jammin Java",
                            Phone = 0
                        },
                        new
                        {
                            RuId = 2,
                            Name = "Subway",
                            Phone = 0
                        },
                        new
                        {
                            RuId = 3,
                            Name = "Zakir Tikka",
                            Phone = 0
                        },
                        new
                        {
                            RuId = 4,
                            Name = "Chop Chop",
                            Phone = 0
                        },
                        new
                        {
                            RuId = 5,
                            Name = "Bombay Chowpatty",
                            Phone = 0
                        },
                        new
                        {
                            RuId = 6,
                            Name = "Juice Zone",
                            Phone = 0
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Orderista.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Orderista.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Orderista.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Orderista.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Orderista.Models.Cart", b =>
                {
                    b.HasOne("Orderista.Models.MenuItem", "Item")
                        .WithMany()
                        .HasForeignKey("ItemMId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Orderista.Models.Order")
                        .WithMany("Cartitems")
                        .HasForeignKey("OrderId");

                    b.HasOne("Orderista.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Orderista.Models.MenuItem", b =>
                {
                    b.HasOne("Orderista.Models.Restaurant")
                        .WithMany("Menu")
                        .HasForeignKey("RestaurantRuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
