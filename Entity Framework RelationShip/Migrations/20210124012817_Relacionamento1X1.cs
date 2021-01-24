using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity_Framework_RelationShip.Migrations
{
    public partial class Relacionamento1X1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Immobiles",
                columns: table => new
                {
                    ImmobileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EType = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Immobiles", x => x.ImmobileId);
                    table.ForeignKey(
                        name: "FK_Immobiles_Adresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Adresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Immobiles_AddressId",
                table: "Immobiles",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Immobiles");

            migrationBuilder.DropTable(
                name: "Adresses");
        }
    }
}
