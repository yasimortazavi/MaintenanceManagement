using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maintenance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedEquipment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "AssetCode", "DepartmentId", "IsActive", "Model", "Name", "SerialNumber" },
                values: new object[,]
                {
                    { 1, "EQ-001", 1, true, null, "الکتروموتور", null },
                    { 2, "EQ-002", 1, true, null, "تابلو برق", null },
                    { 3, "EQ-003", 2, true, null, "پمپ صنعتی", null },
                    { 4, "EQ-004", 2, true, null, "گیربکس", null },
                    { 5, "EQ-005", 3, true, null, "سنسور فشار", null },
                    { 6, "EQ-006", 3, true, null, "ترانسمیتر دما", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
