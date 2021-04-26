using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagementSystem.Data.Migrations
{
    public partial class AddedParentsDataPoints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SParent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestingStudentId = table.Column<string>(nullable: true),
                    Parent1FirstName = table.Column<string>(nullable: true),
                    Parent1LastName = table.Column<string>(nullable: true),
                    Parent1DOB = table.Column<DateTime>(nullable: false),
                    Parent1Email = table.Column<string>(nullable: true),
                    Parent1PhoneNumber = table.Column<string>(nullable: true),
                    Parent2FirstName = table.Column<string>(nullable: true),
                    Parent2LastName = table.Column<string>(nullable: true),
                    Parent2DOB = table.Column<DateTime>(nullable: false),
                    Parent2Address = table.Column<string>(nullable: true),
                    Parent2Email = table.Column<string>(nullable: true),
                    Parent2PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SParent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SParent_AspNetUsers_RequestingStudentId",
                        column: x => x.RequestingStudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SParent_RequestingStudentId",
                table: "SParent",
                column: "RequestingStudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SParent");
        }
    }
}
