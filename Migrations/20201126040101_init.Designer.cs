﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PointFood.Persistence;

namespace PointFood.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201126040101_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PointFood.Model.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("varchar(16)")
                        .HasMaxLength(16);

                    b.HasKey("CardId");

                    b.HasIndex("ClientId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("PointFood.Model.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Alitas"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Árabe"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Asiática"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Café"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Carnes"
                        },
                        new
                        {
                            CategoryId = 6,
                            Name = "Chifa"
                        },
                        new
                        {
                            CategoryId = 7,
                            Name = "Criolla"
                        },
                        new
                        {
                            CategoryId = 8,
                            Name = "Desayunos"
                        },
                        new
                        {
                            CategoryId = 9,
                            Name = "Hamburguesas"
                        },
                        new
                        {
                            CategoryId = 10,
                            Name = "Helados"
                        },
                        new
                        {
                            CategoryId = 11,
                            Name = "Internacional"
                        },
                        new
                        {
                            CategoryId = 12,
                            Name = "Jugos y Batidos"
                        },
                        new
                        {
                            CategoryId = 13,
                            Name = "Mexicana"
                        },
                        new
                        {
                            CategoryId = 14,
                            Name = "Panadería"
                        },
                        new
                        {
                            CategoryId = 15,
                            Name = "Pastas"
                        },
                        new
                        {
                            CategoryId = 16,
                            Name = "Pescados y Mariscos"
                        },
                        new
                        {
                            CategoryId = 17,
                            Name = "Pizzas"
                        },
                        new
                        {
                            CategoryId = 18,
                            Name = "Poke"
                        },
                        new
                        {
                            CategoryId = 19,
                            Name = "Pollería"
                        },
                        new
                        {
                            CategoryId = 20,
                            Name = "Postres"
                        },
                        new
                        {
                            CategoryId = 21,
                            Name = "Salchipapas"
                        },
                        new
                        {
                            CategoryId = 22,
                            Name = "Saludable"
                        },
                        new
                        {
                            CategoryId = 23,
                            Name = "Sándwiches"
                        },
                        new
                        {
                            CategoryId = 24,
                            Name = "Sopas y Cremas"
                        },
                        new
                        {
                            CategoryId = 25,
                            Name = "Sushi"
                        },
                        new
                        {
                            CategoryId = 26,
                            Name = "Vegetariana"
                        });
                });

            modelBuilder.Entity("PointFood.Model.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(9)")
                        .HasMaxLength(9);

                    b.Property<DateTime>("SignedUpAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("PointFood.Model.Extra", b =>
                {
                    b.Property<int>("ExtraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("ExtraId");

                    b.ToTable("Extras");
                });

            modelBuilder.Entity("PointFood.Model.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("MenuId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("PointFood.Model.MenuProduct", b =>
                {
                    b.Property<int>("MenuProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("MenuProductId");

                    b.HasIndex("MenuId");

                    b.HasIndex("ProductId");

                    b.ToTable("MenuProduct");
                });

            modelBuilder.Entity("PointFood.Model.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeliveredAt")
                        .HasColumnType("datetime");

                    b.Property<bool>("Delivery")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("datetime");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("OrderId");

                    b.HasIndex("ClientId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("StateId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PointFood.Model.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("PointFood.Model.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("PointFood.Model.ProductDetail", b =>
                {
                    b.Property<int>("ProductDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ExtraId")
                        .HasColumnType("int");

                    b.Property<int>("OrderDetailId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("ProductDetailId");

                    b.HasIndex("ExtraId");

                    b.HasIndex("OrderDetailId");

                    b.ToTable("ProductDetail");
                });

            modelBuilder.Entity("PointFood.Model.ProductExtra", b =>
                {
                    b.Property<int>("ProductExtraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ExtraId")
                        .HasColumnType("int");

                    b.Property<int>("MenuProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductExtraId");

                    b.HasIndex("ExtraId");

                    b.HasIndex("MenuProductId");

                    b.ToTable("ProductExtra");
                });

            modelBuilder.Entity("PointFood.Model.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(9)")
                        .HasMaxLength(9);

                    b.Property<int>("RestauranteOwnerId")
                        .HasColumnType("int");

                    b.HasKey("RestaurantId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("RestauranteOwnerId")
                        .IsUnique();

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("PointFood.Model.RestaurantOwner", b =>
                {
                    b.Property<int>("RestaurantOwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Dni")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("RestaurantOwnerId");

                    b.ToTable("RestaurantOwners");

                    b.HasData(
                        new
                        {
                            RestaurantOwnerId = 1,
                            Dni = "10000000",
                            Email = "Maria.Gonzales@hotmail.com",
                            LastName = "Gonzales",
                            Name = "Maria",
                            Password = "admin",
                            Username = "10000000"
                        },
                        new
                        {
                            RestaurantOwnerId = 2,
                            Dni = "10000001",
                            Email = "Joseph.Gonzalez@hotmail.com",
                            LastName = "Gonzalez",
                            Name = "Joseph",
                            Password = "admin",
                            Username = "10000001"
                        },
                        new
                        {
                            RestaurantOwnerId = 3,
                            Dni = "10000002",
                            Email = "Autumn.Hughes@hotmail.com",
                            LastName = "Hughes",
                            Name = "Autumn",
                            Password = "admin",
                            Username = "10000002"
                        },
                        new
                        {
                            RestaurantOwnerId = 4,
                            Dni = "10000003",
                            Email = "Stephanie.Martinez@hotmail.com",
                            LastName = "Martinez",
                            Name = "Stephanie",
                            Password = "admin",
                            Username = "10000003"
                        },
                        new
                        {
                            RestaurantOwnerId = 5,
                            Dni = "10000004",
                            Email = "Colby.Young@hotmail.com",
                            LastName = "Young",
                            Name = "Colby",
                            Password = "admin",
                            Username = "10000004"
                        });
                });

            modelBuilder.Entity("PointFood.Model.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("StateId");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            StateId = 1,
                            Name = "Pendiente"
                        },
                        new
                        {
                            StateId = 2,
                            Name = "Entregado"
                        },
                        new
                        {
                            StateId = 3,
                            Name = "Cancelado"
                        });
                });

            modelBuilder.Entity("PointFood.Model.Card", b =>
                {
                    b.HasOne("PointFood.Model.Client", "Client")
                        .WithMany("Cards")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PointFood.Model.Menu", b =>
                {
                    b.HasOne("PointFood.Model.Restaurant", "Restaurant")
                        .WithMany("Menus")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PointFood.Model.MenuProduct", b =>
                {
                    b.HasOne("PointFood.Model.Menu", "Menu")
                        .WithMany("Products")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PointFood.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PointFood.Model.Order", b =>
                {
                    b.HasOne("PointFood.Model.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PointFood.Model.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PointFood.Model.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PointFood.Model.OrderDetail", b =>
                {
                    b.HasOne("PointFood.Model.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PointFood.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PointFood.Model.ProductDetail", b =>
                {
                    b.HasOne("PointFood.Model.Extra", "Extra")
                        .WithMany()
                        .HasForeignKey("ExtraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PointFood.Model.OrderDetail", "OrderDetail")
                        .WithMany("Extras")
                        .HasForeignKey("OrderDetailId");
                });

            modelBuilder.Entity("PointFood.Model.ProductExtra", b =>
                {
                    b.HasOne("PointFood.Model.Extra", "Extra")
                        .WithMany()
                        .HasForeignKey("ExtraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PointFood.Model.MenuProduct", "MenuProduct")
                        .WithMany("Extras")
                        .HasForeignKey("MenuProductId");
                });

            modelBuilder.Entity("PointFood.Model.Restaurant", b =>
                {
                    b.HasOne("PointFood.Model.Category", "Category")
                        .WithMany("Restaurants")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PointFood.Model.RestaurantOwner", "RestaurantOwner")
                        .WithOne("Restaurant")
                        .HasForeignKey("PointFood.Model.Restaurant", "RestauranteOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
