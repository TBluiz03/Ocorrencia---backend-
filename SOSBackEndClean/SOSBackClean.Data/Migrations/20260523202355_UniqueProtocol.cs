using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SOSBackClean.Data.Migrations
{
    /// <inheritdoc />
    public partial class UniqueProtocol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Formulario_Protocolo",
                table: "Formulario",
                column: "Protocolo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Formulario_Protocolo",
                table: "Formulario");
        }
    }
}
