using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace buyC.Migrations
{
    /// <inheritdoc />
    public partial class addFeatured : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Shoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "IsFeatured" },
                values: new object[] { new DateTime(2023, 10, 18, 16, 48, 27, 667, DateTimeKind.Utc).AddTicks(1443), true });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "IsFeatured" },
                values: new object[] { new DateTime(2023, 10, 18, 16, 48, 27, 667, DateTimeKind.Utc).AddTicks(1445), true });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "IsFeatured" },
                values: new object[] { new DateTime(2023, 10, 18, 16, 48, 27, 667, DateTimeKind.Utc).AddTicks(1447), true });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "IsFeatured" },
                values: new object[] { new DateTime(2023, 10, 18, 16, 48, 27, 667, DateTimeKind.Utc).AddTicks(1449), false });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "IsFeatured" },
                values: new object[] { new DateTime(2023, 10, 18, 16, 48, 27, 667, DateTimeKind.Utc).AddTicks(1451), false });

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "IsFeatured" },
                values: new object[] { new DateTime(2023, 10, 18, 16, 48, 27, 667, DateTimeKind.Utc).AddTicks(1453), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Shoes");

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 10, 15, 17, 58, 12, 378, DateTimeKind.Utc).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 10, 15, 17, 58, 12, 378, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 10, 15, 17, 58, 12, 378, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 10, 15, 17, 58, 12, 378, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 10, 15, 17, 58, 12, 378, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 10, 15, 17, 58, 12, 378, DateTimeKind.Utc).AddTicks(9417));
        }
    }
}
