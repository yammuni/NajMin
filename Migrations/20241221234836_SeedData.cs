using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KuaforYonetimSistemi.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Salons",
                columns: new[] { "Id", "Address", "Name", "WorkingHours" },
                values: new object[,]
                {
                    { 1, "Istanbul, Kadıköy", "Kuaför ve Güzellik Salonu", "09:00 - 18:00" },
                    { 2, "Ankara, Çankaya", "Berber ve Kuaför Salonu", "10:00 - 20:00" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
