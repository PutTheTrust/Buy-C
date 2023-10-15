using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace buyC.Migrations
{
    /// <inheritdoc />
    public partial class tests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Name", "Price" },
                values: new object[] { new DateTime(2023, 10, 15, 17, 58, 12, 378, DateTimeKind.Utc).AddTicks(9409), "Air Jordan Legacy 312", 2799.9499999999998 });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Name", "Price" },
                values: new object[] { new DateTime(2023, 10, 15, 17, 58, 12, 378, DateTimeKind.Utc).AddTicks(9410), "Air Jordan Legacy 312", 3526.23 });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Name", "Price" },
                values: new object[] { new DateTime(2023, 10, 15, 17, 58, 12, 378, DateTimeKind.Utc).AddTicks(9412), "Air Jordan Legacy 312", 2300.3600000000001 });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Date", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 10, 15, 17, 58, 12, 378, DateTimeKind.Utc).AddTicks(9414), "A stylish and comfortable casual shoe.", "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697392428/X_PLRBOOST_SHOES_e5z4m3.avif", "X_PLRBOOST SHOES", 3499.0 },
                    { 5, new DateTime(2023, 10, 15, 17, 58, 12, 378, DateTimeKind.Utc).AddTicks(9416), "A stylish and comfortable casual shoe.", "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697392428/RACER_TR23_SHOES_jpfphb.avif", "RACER TR23 SHOES", 1699.0 },
                    { 6, new DateTime(2023, 10, 15, 17, 58, 12, 378, DateTimeKind.Utc).AddTicks(9417), "A stylish and comfortable casual shoe.", "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697392428/DURAMO_SL_SHOES_erzcaq.avif", "DURAMO SL SHOES", 1299.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Name", "Price" },
                values: new object[] { new DateTime(2023, 10, 15, 17, 45, 13, 565, DateTimeKind.Utc).AddTicks(3028), "Running Shoe 1", 99.989999999999995 });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Name", "Price" },
                values: new object[] { new DateTime(2023, 10, 15, 17, 45, 13, 565, DateTimeKind.Utc).AddTicks(3030), "Casual Shoe 2", 49.990000000000002 });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Name", "Price" },
                values: new object[] { new DateTime(2023, 10, 15, 17, 45, 13, 565, DateTimeKind.Utc).AddTicks(3032), "Casual Shoe 3", 49.990000000000002 });
        }
    }
}
