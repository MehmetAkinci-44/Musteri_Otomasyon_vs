using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    E_mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kullanici_Adi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    rol = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musteris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    E_mail = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Dogum_Tarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Meslegi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteris", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_Kullanici_Adi",
                table: "Admins",
                column: "Kullanici_Adi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Musteris_Telefon",
                table: "Musteris",
                column: "Telefon",
                unique: true,
                filter: "[Telefon] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Musteris");
        }
    }
}
