﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bmarketomvc.Contexts;

#nullable disable

namespace bmarketomvc.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ea3bc81b-067d-4116-beab-193c8e836009",
                            ConcurrencyStamp = "912e2d8c-26ad-4321-b71a-74c4e7049424",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "0c853e18-0400-40cb-a4e3-ad8ccce39f1f",
                            ConcurrencyStamp = "1ac28502-f82b-4e21-9fad-6fa88a9ed626",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "48dd5706-f505-4a50-a123-dfb2cdf88171",
                            RoleId = "ea3bc81b-067d-4116-beab-193c8e836009"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("bmarketomvc.Models.Entities.AddressEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Streetname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("bmarketomvc.Models.Entities.ContactFormEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactForms");
                });

            modelBuilder.Entity("bmarketomvc.Models.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "/images/applewatch-270-295.jpg",
                            Price = "$30",
                            Title = "Apple watch series"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "/images/lamp-270-295.jpg",
                            Price = "$30",
                            Title = "Table Lamp"
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "/images/laptop-270-295.jpg",
                            Price = "$30",
                            Title = "Laptop"
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "/images/mirror-270-295.jpg",
                            Price = "$30",
                            Title = "Mirror"
                        },
                        new
                        {
                            Id = 5,
                            ImageUrl = "/images/rice-270-295.jpg",
                            Price = "$30",
                            Title = "Rice cooker"
                        },
                        new
                        {
                            Id = 6,
                            ImageUrl = "/images/pizza-270-295.jpg",
                            Price = "$30",
                            Title = "Pizza slice"
                        },
                        new
                        {
                            Id = 7,
                            ImageUrl = "/images/sunglasses-270-295.jpg",
                            Price = "$30",
                            Title = "Sunglasses"
                        },
                        new
                        {
                            Id = 8,
                            ImageUrl = "/images/watterbottle-270-295.jpg",
                            Price = "$30",
                            Title = "Watter bottle"
                        },
                        new
                        {
                            Id = 9,
                            ImageUrl = "/images/lamp-369-310.jpg",
                            Price = "$30",
                            Title = "Lamp"
                        },
                        new
                        {
                            Id = 10,
                            ImageUrl = "/images/lamp-1-369-310.jpg",
                            Price = "$30",
                            Title = "Lamp"
                        },
                        new
                        {
                            Id = 11,
                            ImageUrl = "/images/fotball-270-295.jpg",
                            Price = "$100",
                            Title = "Fotball"
                        },
                        new
                        {
                            Id = 12,
                            ImageUrl = "/images/coffe-270-295.jpg",
                            Price = "$100",
                            Title = "Coffe"
                        },
                        new
                        {
                            Id = 13,
                            ImageUrl = "/images/dress-270-295.jpg",
                            Price = "$120",
                            Title = "Dress"
                        },
                        new
                        {
                            Id = 14,
                            ImageUrl = "/images/dress-2-270-295.jpg",
                            Price = "$120",
                            Title = "Dress"
                        },
                        new
                        {
                            Id = 15,
                            ImageUrl = "/images/iphone-270-295.jpg",
                            Price = "$500",
                            Title = "Iphone"
                        },
                        new
                        {
                            Id = 16,
                            ImageUrl = "/images/shoes-270-295.jpg",
                            Price = "$200",
                            Title = "Shoes"
                        },
                        new
                        {
                            Id = 17,
                            ImageUrl = "/images/lamp-369-295.jpg",
                            Price = "$700",
                            Title = "Lamp"
                        },
                        new
                        {
                            Id = 18,
                            ImageUrl = "/images/lamp-1-369-295.jpg",
                            Price = "$700",
                            Title = "Lamp"
                        },
                        new
                        {
                            Id = 19,
                            ImageUrl = "/images/lamp-2-369-295.jpg",
                            Price = "$700",
                            Title = "Lamp"
                        });
                });

            modelBuilder.Entity("bmarketomvc.Models.Entities.ProductTagEntity", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("ProductTags");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 2,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 3,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 4,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 5,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 6,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 7,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 8,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 9,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 10,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 11,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 12,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 13,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 14,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 15,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 16,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 17,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 18,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 19,
                            TagId = 2
                        },
                        new
                        {
                            ProductId = 1,
                            TagId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            TagId = 1
                        },
                        new
                        {
                            ProductId = 3,
                            TagId = 1
                        },
                        new
                        {
                            ProductId = 4,
                            TagId = 1
                        },
                        new
                        {
                            ProductId = 5,
                            TagId = 1
                        },
                        new
                        {
                            ProductId = 6,
                            TagId = 1
                        },
                        new
                        {
                            ProductId = 7,
                            TagId = 1
                        },
                        new
                        {
                            ProductId = 8,
                            TagId = 1
                        },
                        new
                        {
                            ProductId = 11,
                            TagId = 3
                        },
                        new
                        {
                            ProductId = 12,
                            TagId = 3
                        },
                        new
                        {
                            ProductId = 13,
                            TagId = 3
                        },
                        new
                        {
                            ProductId = 14,
                            TagId = 3
                        },
                        new
                        {
                            ProductId = 15,
                            TagId = 3
                        },
                        new
                        {
                            ProductId = 16,
                            TagId = 3
                        });
                });

            modelBuilder.Entity("bmarketomvc.Models.Entities.TagEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TagName = "new"
                        },
                        new
                        {
                            Id = 2,
                            TagName = "featured"
                        },
                        new
                        {
                            Id = 3,
                            TagName = "popular"
                        });
                });

            modelBuilder.Entity("bmarketomvc.Models.Entities.UserAddressEntity", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "AddressId");

                    b.HasIndex("AddressId");

                    b.ToTable("UserAddresses");
                });

            modelBuilder.Entity("bmarketomvc.Models.Entities.UserEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("AddressEntityId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("AddressEntityId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "48dd5706-f505-4a50-a123-dfb2cdf88171",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4e427ce1-935d-46e8-9ea4-86f1470ea6bd",
                            Email = "admin@bmarketo.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@BMARKETO.COM",
                            NormalizedUserName = "ADMIN@BMARKETO.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEIE4pG3Rr3t0W5Ob45uz4qrwAYNCGn6l3aMEE/a3zQ9RaO/+7VN1emkFADO/ZNk3Hg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "70f13f09-798d-4883-9d4c-aa52a789d518",
                            TwoFactorEnabled = false,
                            UserName = "admin@bmarketo.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("bmarketomvc.Models.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("bmarketomvc.Models.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bmarketomvc.Models.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("bmarketomvc.Models.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("bmarketomvc.Models.Entities.ProductTagEntity", b =>
                {
                    b.HasOne("bmarketomvc.Models.Entities.ProductEntity", "Product")
                        .WithMany("Products")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bmarketomvc.Models.Entities.TagEntity", "Tag")
                        .WithMany("Products")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("bmarketomvc.Models.Entities.UserAddressEntity", b =>
                {
                    b.HasOne("bmarketomvc.Models.Entities.AddressEntity", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bmarketomvc.Models.Entities.UserEntity", "User")
                        .WithMany("UserAddresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("bmarketomvc.Models.Entities.UserEntity", b =>
                {
                    b.HasOne("bmarketomvc.Models.Entities.AddressEntity", null)
                        .WithMany("Users")
                        .HasForeignKey("AddressEntityId");
                });

            modelBuilder.Entity("bmarketomvc.Models.Entities.AddressEntity", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("bmarketomvc.Models.Entities.ProductEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("bmarketomvc.Models.Entities.TagEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("bmarketomvc.Models.Entities.UserEntity", b =>
                {
                    b.Navigation("UserAddresses");
                });
#pragma warning restore 612, 618
        }
    }
}
