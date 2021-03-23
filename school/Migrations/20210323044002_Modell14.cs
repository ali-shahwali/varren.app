using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace school.Migrations
{
    public partial class Modell14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "Tid",
                table: "Events",
                type: "time",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tid",
                table: "Events");
        }
    }
}
