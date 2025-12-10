using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tarea3.Migrations
{
    /// <inheritdoc />
    public partial class InitialInventario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "TEXT", nullable: false),
                    StockActual = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CostoCompra = table.Column<decimal>(type: "TEXT", nullable: false),
                    StockMinimo = table.Column<int>(type: "INTEGER", nullable: false),
                    Categoria = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reparaciones",
                columns: table => new
                {
                    ID_Reparacion = table.Column<string>(type: "TEXT", nullable: false),
                    ID_Cliente = table.Column<string>(type: "TEXT", nullable: false),
                    ID_Tecnico = table.Column<string>(type: "TEXT", nullable: false),
                    Fecha_Ingreso = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Dispositivo = table.Column<string>(type: "TEXT", nullable: false),
                    FallaReportada = table.Column<string>(type: "TEXT", nullable: false),
                    Diagnostico = table.Column<string>(type: "TEXT", nullable: false),
                    EstadoServicio = table.Column<string>(type: "TEXT", nullable: false),
                    CostoReparacion = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reparaciones", x => x.ID_Reparacion);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Reparaciones");
        }
    }
}
