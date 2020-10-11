using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DegPortal.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseLanguage = table.Column<string>(nullable: true),
                    NameRus = table.Column<string>(nullable: true),
                    NameKaz = table.Column<string>(nullable: true),
                    NameEng = table.Column<string>(nullable: true),
                    Cypher = table.Column<string>(nullable: true),
                    DateStart = table.Column<DateTime>(nullable: false),
                    DateEnd = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(nullable: true),
                    MName = table.Column<string>(nullable: true),
                    LName = table.Column<string>(nullable: true),
                    FNameEng = table.Column<string>(nullable: true),
                    MNameEng = table.Column<string>(nullable: true),
                    LNameEng = table.Column<string>(nullable: true),
                    InstructorId = table.Column<int>(nullable: false),
                    Iin = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    PlaceOfWorkRus = table.Column<string>(nullable: true),
                    PlaceOfWorkKaz = table.Column<string>(nullable: true),
                    PlaceOfWorkEng = table.Column<string>(nullable: true),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructor_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(nullable: true),
                    MName = table.Column<string>(nullable: true),
                    LName = table.Column<string>(nullable: true),
                    FNameEng = table.Column<string>(nullable: true),
                    MNameEng = table.Column<string>(nullable: true),
                    LNameEng = table.Column<string>(nullable: true),
                    StudentId = table.Column<int>(nullable: false),
                    Iin = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    PlaceOfWorkRus = table.Column<string>(nullable: true),
                    PlaceOfWorkKaz = table.Column<string>(nullable: true),
                    PlaceOfWorkEng = table.Column<string>(nullable: true),
                    UrlWorkLink = table.Column<string>(nullable: true),
                    Payment = table.Column<bool>(nullable: false),
                    Diploma = table.Column<bool>(nullable: false),
                    DiplomaNumber = table.Column<string>(nullable: true),
                    DiplomaIssuedDate = table.Column<DateTime>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_CourseId",
                table: "Instructor",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_CourseId",
                table: "Student",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Course");
        }
    }
}
