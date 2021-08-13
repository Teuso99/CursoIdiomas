namespace CursoIdiomas.Application.DTOs
{
    public class AlunoDTO : BaseDTO
    {
        public string Nome { get; set; }

        public string Matricula { get; set; }

        public int Idade { get; set; }

        public int TurmaId { get; set; }
    }
}
