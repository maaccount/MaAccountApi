using Microsoft.EntityFrameworkCore.Migrations;

namespace MaAccount.Migrations
{
    public partial class Add_User_PasswordCheck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "AbpUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Question",
                table: "AbpUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "Question",
                table: "AbpUsers");
        }
    }
}
