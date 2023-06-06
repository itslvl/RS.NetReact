using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class TambahField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Kode",
                table: "Jabatan",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Kode",
                table: "Golongan",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Kode",
                table: "Gender",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Kode",
                table: "Bahasa",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Kode",
                table: "Agama",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kode",
                table: "Jabatan");

            migrationBuilder.DropColumn(
                name: "Kode",
                table: "Golongan");

            migrationBuilder.DropColumn(
                name: "Kode",
                table: "Gender");

            migrationBuilder.DropColumn(
                name: "Kode",
                table: "Bahasa");

            migrationBuilder.DropColumn(
                name: "Kode",
                table: "Agama");
        }
    }
}
