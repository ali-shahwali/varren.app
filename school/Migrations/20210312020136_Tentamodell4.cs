using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace school.Migrations
{
    public partial class Tentamodell4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tentor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tentor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Examinator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kursnamn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tentor", x => x.Id);
                });
        }
    }
}
