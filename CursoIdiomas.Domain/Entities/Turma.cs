using System.Collections.Generic;

namespace CursoIdiomas.Domain.Entities
{
    public class Turma : BaseEntity
    {
        public string Nome { get; set; }
        
        public string Turno { get; set; }

        public virtual ICollection<Aluno> Alunos { get; set; }
    }
}
