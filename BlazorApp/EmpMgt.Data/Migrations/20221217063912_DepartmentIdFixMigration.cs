using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpMgt.Data.Migrations
{
    public partial class DepartmentIdFixMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Employees",
                newName: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Employees",
                newName: "Department");
        }
    }
}
