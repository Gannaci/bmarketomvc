using bmarketomvc.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace bmarketomvc.Contexts;

public class DataContext : IdentityDbContext<UserEntity>
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<AddressEntity> Addresses { get; set; }
    public DbSet<UserAddressEntity> UserAddresses { get; set; }

    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<TagEntity> Tags { get; set; }
    public DbSet<ProductTagEntity> ProductTags { get; set; }

    public DbSet<ContactFormEntity> ContactForms { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = "ea3bc81b-067d-4116-beab-193c8e836009",
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            },
            new IdentityRole
            {
                Id = "0c853e18-0400-40cb-a4e3-ad8ccce39f1f",
                Name = "User",
                NormalizedName = "USER",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            });

        var passwordHasher = new PasswordHasher<UserEntity>();
        var userEntity = new UserEntity
        {
            Id = "48dd5706-f505-4a50-a123-dfb2cdf88171",
            UserName = "admin@bmarketo.com",
            NormalizedUserName = "ADMIN@BMARKETO.COM",
            Email = "admin@bmarketo.com",
            NormalizedEmail = "ADMIN@BMARKETO.COM",
            ConcurrencyStamp = Guid.NewGuid().ToString(),
        };
        userEntity.PasswordHash = passwordHasher.HashPassword(userEntity, "Bytmig123!");
        builder.Entity<UserEntity>().HasData(userEntity);


        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            UserId = userEntity.Id,
            RoleId = "ea3bc81b-067d-4116-beab-193c8e836009"
        });


        builder.Entity<TagEntity>().HasData(
            new TagEntity { Id = 1, TagName = "new" },
            new TagEntity { Id = 2, TagName = "featured" },
            new TagEntity { Id = 3, TagName = "popular" }
        );
        builder.Entity<ProductEntity>().HasData(
            new ProductEntity { Id = 1, Title = "Apple watch series", Price = 30, ImageUrl = "/images/applewatch-270-295.jpg" },
            new ProductEntity { Id = 2, Title = "Table Lamp", Price = 30 , ImageUrl = "" },
            new ProductEntity { Id = 3, Title = "Laptop", Price = 30, ImageUrl = "" },
            new ProductEntity { Id = 4, Title = "Mirror", Price = 30, ImageUrl = "" },
            new ProductEntity { Id = 5, Title = "Rice cooker", Price = 30, ImageUrl = "" },
            new ProductEntity { Id = 6, Title = "Pizza slice", Price = 30, ImageUrl = "" },
            new ProductEntity { Id = 7, Title = "Sunglasses", Price = 30, ImageUrl = "" },
            new ProductEntity { Id = 8, Title = "Watter bottle", Price = 30, ImageUrl = "" },
            new ProductEntity { Id = 9, Title = "Lamp", Price = 30, ImageUrl = "" },
            new ProductEntity { Id = 10, Title = "Lamp", Price = 30, ImageUrl = "" },
            new ProductEntity { Id = 11, Title = "Fotball", Price = 100, ImageUrl = "" },
            new ProductEntity { Id = 12, Title = "Coffe", Price = 30, ImageUrl = "" },
            new ProductEntity { Id = 13, Title = "Dress", Price = 120, ImageUrl = "" },
            new ProductEntity { Id = 14, Title = "Dress", Price = 120, ImageUrl = "" },
            new ProductEntity { Id = 15, Title = "Iphone", Price = 500, ImageUrl = "" },
            new ProductEntity { Id = 16, Title = "Shoes", Price = 200, ImageUrl = "" },
            new ProductEntity { Id = 17, Title = "Lamp", Price = 30, ImageUrl = "" },
            new ProductEntity { Id = 18, Title = "Lamp", Price = 30, ImageUrl = "" },
            new ProductEntity { Id = 19, Title = "Lamp", Price = 30, ImageUrl = "" }

        );

        builder.Entity<ProductTagEntity>().HasData(
            new ProductTagEntity { ProductId = 1, TagId = 2 },
            new ProductTagEntity { ProductId = 2, TagId = 1 }
        );

    }
}
