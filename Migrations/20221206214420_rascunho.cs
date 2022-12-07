using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseCrimes.Migrations
{
    /// <inheritdoc />
    public partial class rascunho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadastro",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioSobrenome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioDtnascimento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioTelefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioNickname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioTipo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastro", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Filme",
                columns: table => new
                {
                    FilmeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmeTitulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilmeDescricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilmeClassificacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilmeTipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilmeDuracao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filme", x => x.FilmeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadastro");

            migrationBuilder.DropTable(
                name: "Filme");
        }
    }
}
