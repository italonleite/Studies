using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity_Framework_RelationShip.Migrations
{
    public partial class v2InserindoBairro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Neighborhood",
                table: "Adresses",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Neighborhood",
                table: "Adresses");
        }
    }
}
