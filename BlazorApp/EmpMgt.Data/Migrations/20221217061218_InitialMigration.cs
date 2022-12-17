using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpMgt.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<int>(type: "int", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Marketing" },
                    { 2, "Designs" },
                    { 3, "Products" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "Department", "Email", "FirstName", "Gender", "LastName", "Photo" },
                values: new object[,]
                {
                    { 1, new DateTime(1982, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "maryl@sample.com", "Mary", 1, "Linglang", "images/mary.png" },
                    { 2, new DateTime(1989, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "johnl@sample.com", "John", 0, "Longrich", "images/john.png" },
                    { 3, new DateTime(1994, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "sarar@sample.com", "Sara", 1, "Richards", "images/sara.png" },
                    { 4, new DateTime(1984, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "samf@sample.com", "Sam", 0, "Fin", "images/sam.jpeg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
