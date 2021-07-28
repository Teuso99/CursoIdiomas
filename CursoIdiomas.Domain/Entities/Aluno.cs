namespace CursoIdiomas.Domain.Entities
{
    public class Aluno : BaseEntity
    {
        public string Nome { get; set; }
        
        public string Matricula { get; set; }

        public int Idade { get; set; }

        public int TurmaId { get; set; }
        
        public virtual Turma Turma { get; set; }
    }
}
