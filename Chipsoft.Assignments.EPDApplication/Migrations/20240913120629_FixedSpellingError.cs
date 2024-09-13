using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chipsoft.Assignments.EPDApplication.Migrations
{
    /// <inheritdoc />
    public partial class FixedSpellingError : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "Physicians",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "Physicians",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "Patients",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "Patients",
                newName: "FirstName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Physicians",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Physicians",
                newName: "Firstname");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Patients",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Patients",
                newName: "Firstname");
        }
    }
}
