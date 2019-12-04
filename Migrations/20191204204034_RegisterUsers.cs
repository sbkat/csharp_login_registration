using Microsoft.EntityFrameworkCore.Migrations;

namespace login_registration.Migrations
{
    public partial class RegisterUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RegisterUsers",
                table: "RegisterUsers");

            migrationBuilder.RenameTable(
                name: "RegisterUsers",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "RegisterUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegisterUsers",
                table: "RegisterUsers",
                column: "UserId");
        }
    }
}
