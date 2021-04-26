using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagementSystem.Data.Migrations
{
    public partial class AddedEmployeeDataPoints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SParent_AspNetUsers_RequestingStudentId",
                table: "SParent");

            migrationBuilder.DropIndex(
                name: "IX_SParent_RequestingStudentId",
                table: "SParent");

            migrationBuilder.DropColumn(
                name: "RequestingStudentId",
                table: "SParent");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BirthEntryNum",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DOB",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HeightFeet",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HeightInches",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StudendEmail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StudentAdditionalInfo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StudentClass",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StudentGrade",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StudentHouse",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StudentPhoneNumber",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MidddleName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Student",
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
                    StudendEmail = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_Student", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MidddleName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TaxId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "RequestingStudentId",
                table: "SParent",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthEntryNum",
                table: "AspNetUsers",
                type: "nvarchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeightFeet",
                table: "AspNetUsers",
                type: "nvarchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeightInches",
                table: "AspNetUsers",
                type: "nvarchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudendEmail",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentAdditionalInfo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentClass",
                table: "AspNetUsers",
                type: "nvarchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentGrade",
                table: "AspNetUsers",
                type: "nvarchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentHouse",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "AspNetUsers",
                type: "nvarchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentPhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SParent_RequestingStudentId",
                table: "SParent",
                column: "RequestingStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_SParent_AspNetUsers_RequestingStudentId",
                table: "SParent",
                column: "RequestingStudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
