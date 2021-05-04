using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagementSystem.Data.Migrations
{
    public partial class studenttableupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudendEmail",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "StudentEmail",
                table: "Students",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudentDetailsVM",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    HeightFeet = table.Column<string>(nullable: false),
                    HeightInches = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    StudentEmail = table.Column<string>(nullable: true),
                    StudentPhoneNumber = table.Column<string>(nullable: true),
                    BirthEntryNum = table.Column<string>(nullable: false),
                    StudentId = table.Column<string>(nullable: false),
                    StudentGrade = table.Column<string>(nullable: false),
                    StudentClass = table.Column<string>(nullable: false),
                    StudentHouse = table.Column<string>(nullable: true),
                    StudentAdditionalInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDetailsVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentVM",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentVM", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentDetailsVM");

            migrationBuilder.DropTable(
                name: "StudentVM");

            migrationBuilder.DropColumn(
                name: "StudentEmail",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "StudendEmail",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
