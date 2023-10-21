using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace buyC.Migrations
{
    /// <inheritdoc />
    public partial class addWomanShoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Shoes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Date" },
                values: new object[] { "Man", new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Date" },
                values: new object[] { "Man", new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Date" },
                values: new object[] { "Man", new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Date" },
                values: new object[] { "Man", new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Date" },
                values: new object[] { "Man", new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Date" },
                values: new object[] { "Man", new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8227) });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Category", "Date", "Description", "Image", "IsFeatured", "Name", "Price" },
                values: new object[,]
                {
                    { 7, "Woman", new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8230), "A stylish and comfortable casual shoe.", "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697913855/Nano_2_Shoes_nkty64.jpg", false, "Nano 2 Shoes", 1299.0 },
                    { 8, "Woman", new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8232), "A stylish and comfortable casual shoe.", "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697913855/Nano_X3_Shoes_aiom3s.jpg", false, "Nano X3 Shoes", 1299.0 },
                    { 9, "Woman", new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8234), "A stylish and comfortable casual shoe.", "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697913855/Zig_Dynamica_4_pw2nb6.jpg", false, "Zig Dynamica 4", 1299.0 },
                    { 10, "Woman", new DateTime(2023, 10, 21, 18, 51, 14, 843, DateTimeKind.Utc).AddTicks(8237), "A stylish and comfortable casual shoe.", "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697913855/ADIDAS_BY_STELLA_MCCARTNEY_ULTRABOOST_LIGHT_SHOES_qrnor5.avif", false, "ADIDAS BY STELLA MCCARTNEY ULTRABOOST LIGHT SHOES", 1299.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Shoes");

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 10, 18, 16, 48, 27, 667, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 10, 18, 16, 48, 27, 667, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 10, 18, 16, 48, 27, 667, DateTimeKind.Utc).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 10, 18, 16, 48, 27, 667, DateTimeKind.Utc).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 10, 18, 16, 48, 27, 667, DateTimeKind.Utc).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 10, 18, 16, 48, 27, 667, DateTimeKind.Utc).AddTicks(1453));
        }
    }
}
