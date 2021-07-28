using Microsoft.EntityFrameworkCore.Migrations;

namespace CursoIdiomas.Infrastructure.Migrations
{
    public partial class AlunosPorTurma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Turmas_TurmaId",
                table: "Alunos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Turmas",
                table: "Turmas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Turmas",
                table: "Turmas",
                column: "Id");

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
                name: "FK_Alunos_Turmas_TurmaId",
                table: "Alunos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Turmas",
                table: "Turmas");

            migrationBuilder.RenameTable(
                name: "Turmas",
                newName: "Turma");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Turma",
                table: "Turma",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Turma_TurmaId",
                table: "Alunos",
                column: "TurmaId",
                principalTable: "Turma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
