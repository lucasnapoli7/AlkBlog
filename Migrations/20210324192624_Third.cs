using Microsoft.EntityFrameworkCore.Migrations;

namespace AlkBlog.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "state",
                table: "Posts");

            migrationBuilder.AddColumn<bool>(
                name: "is_deleted",
                table: "Posts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_deleted",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "state",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
