using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class seeds_data_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "KATEGORI_ID", "KATEGORI_ADI" },
                values: new object[,]
                {
                    { 1, "Aksiyon" },
                    { 2, "Komedi" },
                    { 3, "Romantik" },
                    { 4, "Korku" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "YONETMEN_ID", "YONETMEN_ADI", "YONETMEN_SOYADI" },
                values: new object[] { 1, "Şahan", "Gökbahar" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FILM_ID", "CategoryId", "DirectorId", "FILM_ACIKLAMASI", "FILM_ADI", "FILM_CIKIS_SENESİ" },
                values: new object[] { 1, 2, 1, "Deneme Deneme Deneme Deneme", "Recep İvedik 1 ", 2008 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "KATEGORI_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "KATEGORI_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "KATEGORI_ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FILM_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "KATEGORI_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "YONETMEN_ID",
                keyValue: 1);
        }
    }
}
