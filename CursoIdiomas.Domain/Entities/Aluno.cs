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
        
        public string Email { get; set; }

        public string Senha { get; set; }
    }
}
