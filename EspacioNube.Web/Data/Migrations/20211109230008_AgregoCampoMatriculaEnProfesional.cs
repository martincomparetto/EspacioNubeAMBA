using Microsoft.EntityFrameworkCore.Migrations;

namespace EspacioNube.Web.Data.Migrations
{
    public partial class AgregoCampoMatriculaEnProfesional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Matricula",
                table: "Profesionales",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Matricula",
                table: "Profesionales");
        }
    }
}
