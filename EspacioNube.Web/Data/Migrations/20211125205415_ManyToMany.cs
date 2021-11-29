using Microsoft.EntityFrameworkCore.Migrations;

namespace EspacioNube.Web.Data.Migrations
{
    public partial class ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ProfesionalesPacientes",
                columns: table => new
                {
                    PacientesID = table.Column<int>(type: "int", nullable: false),
                    ProfesionalesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfesionalesPacientes", x => new { x.PacientesID, x.ProfesionalesID });
                    table.ForeignKey(
                        name: "FK_ProfesionalesPacientes_Pacientes_PacientesID",
                        column: x => x.PacientesID,
                        principalTable: "Pacientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfesionalesPacientes_Profesionales_ProfesionalesID",
                        column: x => x.ProfesionalesID,
                        principalTable: "Profesionales",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfesionalesPacientes_ProfesionalesID",
                table: "ProfesionalesPacientes",
                column: "ProfesionalesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfesionalesPacientes");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
