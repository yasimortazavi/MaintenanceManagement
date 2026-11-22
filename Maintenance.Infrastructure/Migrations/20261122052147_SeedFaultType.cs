using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maintenance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedFaultType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FaultTypes",
                columns: new[] { "Id", "Description", "IsActive", "Title" },
                values: new object[,]
                {
                    { 1, "مشکلات مربوط به سیستم برق", true, "خرابی الکتریکی" },
                    { 2, "مشکلات مربوط به قطعات مکانیکی", true, "خرابی مکانیکی" },
                    { 3, "مشکلات مربوط به تجهیزات اندازه‌گیری و کنترل", true, "خرابی ابزار دقیق" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FaultTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FaultTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FaultTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
