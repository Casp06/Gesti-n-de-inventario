using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tarea3.Migrations
{
    /// <inheritdoc />
    public partial class AddCodigoSku : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodigoSKU",
                table: "Productos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoSKU",
                table: "Productos");
        }
    }
}
