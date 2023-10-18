using buyC.Models;
using Microsoft.EntityFrameworkCore;

namespace buyC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Shoe> Shoes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Shoe>().HasData(
                new Shoe
                {
                    Id=1,
                    Name = "Air Jordan Legacy 312",
                    Price = 2799.95,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697391046/Air_Jordan_Legacy_312_a46xsf.webp",
                    Description = "A comfortable and durable running shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = true
                },
                new Shoe
                {
                    Id = 2,
                    Name = "Air Jordan Legacy 312",
                    Price = 3526.23,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697391046/Jumpman_MVP_vjjeul.webp",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = true

                },
                new Shoe
                {
                    Id = 3,
                    Name = "Air Jordan Legacy 312",
                    Price = 2300.36,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697391046/Jordan_Post_c5bsey.webp",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = true
                },
                new Shoe
                {
                    Id = 4,
                    Name = "X_PLRBOOST SHOES",
                    Price = 3499.00,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697392428/X_PLRBOOST_SHOES_e5z4m3.avif",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = false
                },
                new Shoe
                {
                    Id = 5,
                    Name = "RACER TR23 SHOES",
                    Price = 1699.00,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697392428/RACER_TR23_SHOES_jpfphb.avif",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = false
                },
                new Shoe
                {
                    Id = 6,
                    Name = "DURAMO SL SHOES",
                    Price = 1299.00,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697392428/DURAMO_SL_SHOES_erzcaq.avif",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = false
                });
        }
    }
}
