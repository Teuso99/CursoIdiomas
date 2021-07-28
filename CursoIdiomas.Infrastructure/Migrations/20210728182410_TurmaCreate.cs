using Microsoft.EntityFrameworkCore.Migrations;

namespace CursoIdiomas.Infrastructure.Migrations
{
    public partial class TurmaCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Aluno",
                table: "Aluno");

            migrationBuilder.RenameTable(
                name: "Aluno",
                newName: "Alunos");

            migrationBuilder.AddColumn<int>(
                name: "TurmaId",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Turno = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_TurmaId",
                table: "Alunos",
                column: "TurmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Turmas_TurmaId",
                table: "Alunos",
                column: "TurmaId",
                principalTable: "Turmas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Turma_TurmaId",
                table: "Alunos");

            migrationBuilder.DropTable(
                name: "Turmas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_TurmaId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "TurmaId",
                table: "Alunos");

            migrationBuilder.RenameTable(
                name: "Alunos",
                newName: "Aluno");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Aluno",
                table: "Aluno",
                column: "Id");
        }
    }
}
