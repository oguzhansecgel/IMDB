using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class seriesaddedcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Serieses",
                columns: table => new
                {
                    DIZI_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DIZI_ADI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DIZI_ACIKLAMASI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DIZI_YILI = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DirectorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serieses", x => x.DIZI_ID);
                    table.ForeignKey(
                        name: "FK_Serieses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "KATEGORI_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Serieses_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "YONETMEN_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Serieses_CategoryId",
                table: "Serieses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Serieses_DirectorId",
                table: "Serieses",
                column: "DirectorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Serieses");
        }
    }
}
