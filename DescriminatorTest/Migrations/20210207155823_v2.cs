using Microsoft.EntityFrameworkCore.Migrations;

namespace DescriminatorTest.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "blog_type",
                table: "Blogs",
                newName: "Discriminator");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Blogs",
                newName: "blog_type");
        }
    }
}
