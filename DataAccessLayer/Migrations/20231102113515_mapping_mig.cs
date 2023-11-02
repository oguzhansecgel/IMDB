using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mapping_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FilmYear",
                table: "Films",
                newName: "FILM_CIKIS_SENESİ");

            migrationBuilder.RenameColumn(
                name: "FilmName",
                table: "Films",
                newName: "FILM_ADI");

            migrationBuilder.RenameColumn(
                name: "FilmDescription",
                table: "Films",
                newName: "FILM_ACIKLAMASI");

            migrationBuilder.RenameColumn(
                name: "FilmId",
                table: "Films",
                newName: "FILM_ID");

            migrationBuilder.RenameColumn(
                name: "DirectorSurname",
                table: "Directors",
                newName: "YONETMEN_SOYADI");

            migrationBuilder.RenameColumn(
                name: "DirectorName",
                table: "Directors",
                newName: "YONETMEN_ADI");

            migrationBuilder.RenameColumn(
                name: "DirectorID",
                table: "Directors",
                newName: "YONETMEN_ID");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "KATEGORI_ADI");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "KATEGORI_ID");

            migrationBuilder.AlterColumn<int>(
                name: "FILM_CIKIS_SENESİ",
                table: "Films",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "FILM_ADI",
                table: "Films",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "FILM_ACIKLAMASI",
                table: "Films",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "FILM_ID",
                table: "Films",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "YONETMEN_SOYADI",
                table: "Directors",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "YONETMEN_ADI",
                table: "Directors",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "YONETMEN_ID",
                table: "Directors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "KATEGORI_ADI",
                table: "Categories",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "KATEGORI_ID",
                table: "Categories",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FILM_CIKIS_SENESİ",
                table: "Films",
                newName: "FilmYear");

            migrationBuilder.RenameColumn(
                name: "FILM_ADI",
                table: "Films",
                newName: "FilmName");

            migrationBuilder.RenameColumn(
                name: "FILM_ACIKLAMASI",
                table: "Films",
                newName: "FilmDescription");

            migrationBuilder.RenameColumn(
                name: "FILM_ID",
                table: "Films",
                newName: "FilmId");

            migrationBuilder.RenameColumn(
                name: "YONETMEN_SOYADI",
                table: "Directors",
                newName: "DirectorSurname");

            migrationBuilder.RenameColumn(
                name: "YONETMEN_ADI",
                table: "Directors",
                newName: "DirectorName");

            migrationBuilder.RenameColumn(
                name: "YONETMEN_ID",
                table: "Directors",
                newName: "DirectorID");

            migrationBuilder.RenameColumn(
                name: "KATEGORI_ADI",
                table: "Categories",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "KATEGORI_ID",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "FilmYear",
                table: "Films",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "FilmName",
                table: "Films",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "FilmDescription",
                table: "Films",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)")
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "FilmId",
                table: "Films",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 1)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "DirectorSurname",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)")
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "DirectorName",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "DirectorID",
                table: "Directors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 1)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Categories",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 1)
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
