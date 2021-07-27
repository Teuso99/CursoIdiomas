using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoIdiomas.Domain.Entities
{
    public class Aluno : BaseEntity
    {
        public string Nome { get; set; }
        
        public string Matricula { get; set; }

        public int Idade { get; set; }

        //Turma
    }
}
