using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductosCRUD.Server.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    idActividad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreActividad = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    conocimientoActividad = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    relacionamientoActividad = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    condicionTrabajoActividad = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    impactoActividad = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    responsabilidadActividad = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    ponderacionActividad = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    ponderacionNivelActividad = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    grupoOcupacionalActividad = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    observacionActividad = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.idActividad);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_nombreActividad",
                table: "Productos",
                column: "nombreActividad",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
