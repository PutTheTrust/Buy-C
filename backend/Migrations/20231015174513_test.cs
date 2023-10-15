using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace buyC.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    Rating = table.Column<int>(type: "INTEGER", nullable: true),
                    ShoeId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Shoes_ShoeId",
                        column: x => x.ShoeId,
                        principalTable: "Shoes",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Date", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 15, 17, 45, 13, 565, DateTimeKind.Utc).AddTicks(3028), "A comfortable and durable running shoe.", "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697391046/Air_Jordan_Legacy_312_a46xsf.webp", "Running Shoe 1", 99.989999999999995 },
                    { 2, new DateTime(2023, 10, 15, 17, 45, 13, 565, DateTimeKind.Utc).AddTicks(3030), "A stylish and comfortable casual shoe.", "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697391046/Jumpman_MVP_vjjeul.webp", "Casual Shoe 2", 49.990000000000002 },
                    { 3, new DateTime(2023, 10, 15, 17, 45, 13, 565, DateTimeKind.Utc).AddTicks(3032), "A stylish and comfortable casual shoe.", "https://res.cloudinary.com/dtwnppsc6/image/upload/v1697391046/Jordan_Post_c5bsey.webp", "Casual Shoe 3", 49.990000000000002 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ShoeId",
                table: "Reviews",
                column: "ShoeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Shoes");
        }
    }
}
