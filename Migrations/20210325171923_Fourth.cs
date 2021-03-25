using Microsoft.EntityFrameworkCore.Migrations;

namespace AlkBlog.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "is_deleted",
                table: "Posts",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "creation_date",
                table: "Posts",
                newName: "creationDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Posts",
                newName: "is_deleted");

            migrationBuilder.RenameColumn(
                name: "creationDate",
                table: "Posts",
                newName: "creation_date");
        }
    }
}
