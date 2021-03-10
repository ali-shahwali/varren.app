using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace school.Data.Migrations
{
    public partial class TentorModell2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Data",
                table: "Tentor",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Tentor");
        }
    }
}
