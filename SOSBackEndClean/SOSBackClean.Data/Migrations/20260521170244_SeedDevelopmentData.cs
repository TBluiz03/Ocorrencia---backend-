using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SOSBackClean.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDevelopmentData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE predio MODIFY COLUMN Nome nvarchar(20) Not Null Unique");


            migrationBuilder.Sql("INSERT INTO predio(Nome, Numero_Andares) VALUES('Predio Sul', 4)");
            migrationBuilder.Sql("INSERT INTO predio(Nome, Numero_Andares) VALUES('Predio Norte', 3)");
            migrationBuilder.Sql("INSERT INTO predio(Nome, Numero_Andares) VALUES('Predio Leste', 2)");

            migrationBuilder.Sql("INSERT INTO Funcionario(Nome, Foto, Cargo) VALUES('Marcelo','https:/12h?392fkdj',3)");
            migrationBuilder.Sql("INSERT INTO Funcionario(Nome, Foto, Cargo) VALUES('fatima','',3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
