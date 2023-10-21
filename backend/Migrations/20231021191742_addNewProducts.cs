using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace buyC.Migrations
{
    /// <inheritdoc />
    public partial class addNewProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 10, 21, 19, 17, 42, 726, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 10, 21, 19, 17, 42, 726, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 10, 21, 19, 17, 42, 726, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 10, 21, 19, 17, 42, 726, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Price" },
                values: new object[] { new DateTime(2023, 10, 21, 19, 17, 42, 726, DateTimeKind.Utc).AddTicks(3065), 4235.0 });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Price" },
                values: new object[] { new DateTime(2023, 10, 21, 19, 17, 42, 726, DateTimeKind.Utc).AddTicks(3067), 3352.0 });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "Price" },
                values: new object[] { new DateTime(2023, 10, 21, 19, 17, 42, 726, DateTimeKind.Utc).AddTicks(3069), 5242.0 });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "Price" },
                values: new object[] { new DateTime(2023, 10, 21, 19, 17, 42, 726, DateTimeKind.Utc).AddTicks(3071), 3645.0 });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "Price" },
                values: new object[] { new DateTime(2023, 10, 21, 19, 17, 42, 726, DateTimeKind.Utc).AddTicks(3073), 4239.0 });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "Price" },
                values: new object[] { new DateTime(2023, 10, 21, 19, 17, 42, 726, DateTimeKind.Utc).AddTicks(3075), 1989.0 });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Category", "Date", "Description", "Image", "IsFeatured", "Name", "Price" },
                values: new object[,]
                {
                    { 11, "Kids", new DateTime(2023, 10, 21, 19, 17, 42, 726, DateTimeKind.Utc).AddTicks(3077), "A stylish and comfortable casual shoe.", "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697914586/Club_C_Shoes_l0syzs.jpg", false, "Club C Shoes", 1969.0 },
                    { 12, "Kids", new DateTime(2023, 10, 21, 19, 17, 42, 726, DateTimeKind.Utc).AddTicks(3079), "A stylish and comfortable casual shoe.", "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697914586/SUPERSTAR_YU-GI-OH_SHOES_ik5j5o.avif", false, "SUPERSTAR YU-GI-OH! SHOES", 1859.0 },
                    { 13, "Kids", new DateTime(2023, 10, 21, 19, 17, 42, 726, DateTimeKind.Utc).AddTicks(3081), "A stylish and comfortable casual shoe.", "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697914587/Jordan_1_Mid_cgson8.webp", false, "Jordan 1 Mid", 2299.0 },
                    { 14, "Kids", new DateTime(2023, 10, 21, 19, 17, 42, 726, DateTimeKind.Utc).AddTicks(3083), "A stylish and comfortable casual shoe.", "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697914587/Jumpman_Two_Trey_xft9yu.webp", false, "Jumpman Two Trey", 2599.0 },
                    { 15, "Accessories", new DateTime(2023, 10, 21, 19, 17, 42, 726, DateTimeKind.Utc).AddTicks(3085), "A stylish and comfortable casual shoe.", "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697915415/UCL_PRO_BALL_me0fxc.avif", false, "UCL PRO BALL", 2299.0 },
                    { 16, "Accessories", new DateTime(2023, 10, 21, 19, 17, 42, 726, DateTimeKind.Utc).AddTicks(3087), "A stylish and comfortable casual shoe.", "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697915415/TERREX_X_NATIONAL_GEOGRAPHIC_BEANIE_gg4hym.avif", false, "TERREX X NATIONAL GEOGRAPHIC BEANIE", 2299.0 },
                    { 17, "Accessories", new DateTime(2023, 10, 21, 19, 17, 42, 726, DateTimeKind.Utc).AddTicks(3089), "A stylish and comfortable casual shoe.", "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697915415/TECH_FISHERMAN_HAT_kl0atg.avif", false, "TECH FISHERMAN HAT", 2299.0 },
                    { 18, "Accessories", new DateTime(2023, 10, 21, 19, 17, 42, 726, DateTimeKind.Utc).AddTicks(3091), "A stylish and comfortable casual shoe.", "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697915415/MONCLER_X_ADIDAS_ORIGINALS_REVERSIBLE_BUCKET_HAT_n59ppi.avif", false, "MONCLER X ADIDAS ORIGINALS REVERSIBLE BUCKET HAT", 2299.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Price" },
                values: new object[] { new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8225), 1699.0 });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Price" },
                values: new object[] { new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8227), 1299.0 });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "Price" },
                values: new object[] { new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8230), 1299.0 });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "Price" },
                values: new object[] { new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8232), 1299.0 });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "Price" },
                values: new object[] { new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8234), 1299.0 });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "Price" },
                values: new object[] { new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8237), 1299.0 });
        }
    }
}
