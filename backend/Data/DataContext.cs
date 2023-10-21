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
                    IsFeatured = true,
                    Category = "Man"
                },
                new Shoe
                {
                    Id = 2,
                    Name = "Air Jordan Legacy 312",
                    Price = 3526.23,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697391046/Jumpman_MVP_vjjeul.webp",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = true,
                    Category = "Man"

                },
                new Shoe
                {
                    Id = 3,
                    Name = "Air Jordan Legacy 312",
                    Price = 2300.36,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697391046/Jordan_Post_c5bsey.webp",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = true,
                    Category = "Man"
                },
                new Shoe
                {
                    Id = 4,
                    Name = "X_PLRBOOST SHOES",
                    Price = 3499.00,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697392428/X_PLRBOOST_SHOES_e5z4m3.avif",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = false,
                    Category = "Man"
                },
                new Shoe
                {
                    Id = 5,
                    Name = "RACER TR23 SHOES",
                    Price = 4235.00,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697392428/RACER_TR23_SHOES_jpfphb.avif",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = false,
                    Category = "Man"
                },
                new Shoe
                {
                    Id = 6,
                    Name = "DURAMO SL SHOES",
                    Price = 3352.00,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697392428/DURAMO_SL_SHOES_erzcaq.avif",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = false,
                    Category = "Man"
                },
                new Shoe
                {
                    Id = 7,
                    Name = "Nano 2 Shoes",
                    Price = 5242.00,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697913855/Nano_2_Shoes_nkty64.jpg",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = false,
                    Category = "Woman"
                },
                new Shoe
                {
                    Id = 8,
                    Name = "Nano X3 Shoes",
                    Price = 3645.00,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697913855/Nano_X3_Shoes_aiom3s.jpg",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = false,
                    Category = "Woman"
                },
                new Shoe
                {
                    Id = 9,
                    Name = "Zig Dynamica 4",
                    Price = 4239.00,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697913855/Zig_Dynamica_4_pw2nb6.jpg",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = false,
                    Category = "Woman"
                },
                new Shoe
                {
                    Id = 10,
                    Name = "ADIDAS BY STELLA MCCARTNEY ULTRABOOST LIGHT SHOES",
                    Price = 1989.00,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697913855/ADIDAS_BY_STELLA_MCCARTNEY_ULTRABOOST_LIGHT_SHOES_qrnor5.avif",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = false,
                    Category = "Woman"
                },
                new Shoe
                {
                    Id = 11,
                    Name = "Club C Shoes",
                    Price = 1969.00,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697914586/Club_C_Shoes_l0syzs.jpg",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = false,
                    Category = "Kids"
                },
                new Shoe
                {
                    Id = 12,
                    Name = "SUPERSTAR YU-GI-OH! SHOES",
                    Price = 1859.00,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697914586/SUPERSTAR_YU-GI-OH_SHOES_ik5j5o.avif",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = false,
                    Category = "Kids"
                },
                new Shoe
                {
                    Id = 13,
                    Name = "Jordan 1 Mid",
                    Price = 2299.00,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697914587/Jordan_1_Mid_cgson8.webp",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = false,
                    Category = "Kids"
                },
                new Shoe
                {
                    Id = 14,
                    Name = "Jumpman Two Trey",
                    Price = 2599.00,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697914587/Jumpman_Two_Trey_xft9yu.webp",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = false,
                    Category = "Kids"
                },
                new Shoe
                {
                    Id = 15,
                    Name = "UCL PRO BALL",
                    Price = 2299.00,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697915415/UCL_PRO_BALL_me0fxc.avif",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = false,
                    Category = "Accessories"
                },
                new Shoe
                {
                    Id = 16,
                    Name = "TERREX X NATIONAL GEOGRAPHIC BEANIE",
                    Price = 2299.00,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697915415/TERREX_X_NATIONAL_GEOGRAPHIC_BEANIE_gg4hym.avif",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = false,
                    Category = "Accessories"
                },
                new Shoe
                {
                    Id = 17,
                    Name = "TECH FISHERMAN HAT",
                    Price = 2299.00,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697915415/TECH_FISHERMAN_HAT_kl0atg.avif",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = false,
                    Category = "Accessories"
                },
                new Shoe
                {
                    Id = 18,
                    Name = "MONCLER X ADIDAS ORIGINALS REVERSIBLE BUCKET HAT",
                    Price = 2299.00,
                    Image = "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697915415/MONCLER_X_ADIDAS_ORIGINALS_REVERSIBLE_BUCKET_HAT_n59ppi.avif",
                    Description = "A stylish and comfortable casual shoe.",
                    Date = DateTime.UtcNow,
                    IsFeatured = false,
                    Category = "Accessories"
                }
                );
        }
    }
}
