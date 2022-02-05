﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models.Database.Context;

namespace Models.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220204091512_initialize")]
    partial class initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Database.Entities.Categories", b =>
                {
                    b.Property<long>("catId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("catName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("catId");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Models.Database.Entities.OrderDetails", b =>
                {
                    b.Property<long>("orderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("orderID")
                        .HasColumnType("bigint");

                    b.Property<long>("productID")
                        .HasColumnType("bigint");

                    b.Property<long>("qty")
                        .HasColumnType("bigint");

                    b.HasKey("orderDetailID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Models.Database.Entities.Orders", b =>
                {
                    b.Property<long>("orderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("createdBy")
                        .HasColumnType("bigint");

                    b.HasKey("orderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Models.Database.Entities.ProductCart", b =>
                {
                    b.Property<long>("cartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.Property<long>("productID")
                        .HasColumnType("bigint");

                    b.Property<int>("qty")
                        .HasColumnType("int");

                    b.HasKey("cartID");

                    b.ToTable("ProductCart");
                });

            modelBuilder.Entity("Models.Database.Entities.Products", b =>
                {
                    b.Property<long>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("catId")
                        .HasColumnType("bigint");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("productName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("productId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("Models.Database.Entities.Roles", b =>
                {
                    b.Property<long>("roleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("roleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("roleId");

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            roleId = 1L,
                            roleName = "ADMIN"
                        },
                        new
                        {
                            roleId = 2L,
                            roleName = "USER"
                        });
                });

            modelBuilder.Entity("Models.Database.Entities.UserCard", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cvc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("expMonth")
                        .HasColumnType("bigint");

                    b.Property<long>("expYear")
                        .HasColumnType("bigint");

                    b.Property<long>("userId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("userCards");
                });

            modelBuilder.Entity("Models.Database.Entities.UserRoles", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("roleId")
                        .HasColumnType("bigint");

                    b.Property<long>("userId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("userRoles");

                    b.HasData(
                        new
                        {
                            id = 1L,
                            roleId = 1L,
                            userId = 1L
                        });
                });

            modelBuilder.Entity("Models.Database.Entities.Users", b =>
                {
                    b.Property<long>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            userId = 1L,
                            email = "admin@gmail.com",
                            name = "Admin",
                            password = "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
