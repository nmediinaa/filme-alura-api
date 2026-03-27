using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class deletepolices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinema_Endereco_EnderecoId",
                table: "Cinema");

            migrationBuilder.AddForeignKey(
                name: "FK_Cinema_Endereco_EnderecoId",
                table: "Cinema",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinema_Endereco_EnderecoId",
                table: "Cinema");

            migrationBuilder.AddForeignKey(
                name: "FK_Cinema_Endereco_EnderecoId",
                table: "Cinema",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
