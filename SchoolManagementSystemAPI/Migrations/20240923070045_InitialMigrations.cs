using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classs",
                columns: table => new
                {
                    Class_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Class_number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classs", x => x.Class_id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Grd_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grd_Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Grd_id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Sbj_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sbj_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Sbj_id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    T_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Teacher_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_of_joining = table.Column<DateOnly>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.T_id);
                });

            migrationBuilder.CreateTable(
                name: "Terms",
                columns: table => new
                {
                    Trm_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terms", x => x.Trm_id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClassTeacher",
                columns: table => new
                {
                    Class_id = table.Column<int>(type: "int", nullable: false),
                    TeachersT_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassTeacher", x => new { x.Class_id, x.TeachersT_id });
                    table.ForeignKey(
                        name: "FK_ClassTeacher_Classs_Class_id",
                        column: x => x.Class_id,
                        principalTable: "Classs",
                        principalColumn: "Class_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassTeacher_Teachers_TeachersT_id",
                        column: x => x.TeachersT_id,
                        principalTable: "Teachers",
                        principalColumn: "T_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectTeacher",
                columns: table => new
                {
                    SubjectSbj_id = table.Column<int>(type: "int", nullable: false),
                    TeachersT_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectTeacher", x => new { x.SubjectSbj_id, x.TeachersT_id });
                    table.ForeignKey(
                        name: "FK_SubjectTeacher_Subjects_SubjectSbj_id",
                        column: x => x.SubjectSbj_id,
                        principalTable: "Subjects",
                        principalColumn: "Sbj_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectTeacher_Teachers_TeachersT_id",
                        column: x => x.TeachersT_id,
                        principalTable: "Teachers",
                        principalColumn: "T_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Std_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Std_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Std_Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Std_Age = table.Column<int>(type: "int", nullable: false),
                    Class_id = table.Column<int>(type: "int", nullable: true),
                    GradeGrd_id = table.Column<int>(type: "int", nullable: true),
                    SubjectSbj_id = table.Column<int>(type: "int", nullable: true),
                    TermTrm_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Std_id);
                    table.ForeignKey(
                        name: "FK_Students_Classs_Class_id",
                        column: x => x.Class_id,
                        principalTable: "Classs",
                        principalColumn: "Class_id");
                    table.ForeignKey(
                        name: "FK_Students_Grades_GradeGrd_id",
                        column: x => x.GradeGrd_id,
                        principalTable: "Grades",
                        principalColumn: "Grd_id");
                    table.ForeignKey(
                        name: "FK_Students_Subjects_SubjectSbj_id",
                        column: x => x.SubjectSbj_id,
                        principalTable: "Subjects",
                        principalColumn: "Sbj_id");
                    table.ForeignKey(
                        name: "FK_Students_Terms_TermTrm_id",
                        column: x => x.TermTrm_id,
                        principalTable: "Terms",
                        principalColumn: "Trm_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassTeacher_TeachersT_id",
                table: "ClassTeacher",
                column: "TeachersT_id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Class_id",
                table: "Students",
                column: "Class_id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GradeGrd_id",
                table: "Students",
                column: "GradeGrd_id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SubjectSbj_id",
                table: "Students",
                column: "SubjectSbj_id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TermTrm_id",
                table: "Students",
                column: "TermTrm_id");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTeacher_TeachersT_id",
                table: "SubjectTeacher",
                column: "TeachersT_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassTeacher");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "SubjectTeacher");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "Classs");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Terms");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
