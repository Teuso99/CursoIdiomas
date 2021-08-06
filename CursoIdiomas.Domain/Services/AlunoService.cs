using CursoIdiomas.Domain.Entities;
using CursoIdiomas.Domain.Interfaces.Repositories;
using CursoIdiomas.Domain.Interfaces.Services;

namespace CursoIdiomas.Domain.Services
{
    public class AlunoService : BaseService<Aluno>, IAlunoService
    {
        private readonly IAlunoRepository _repository;
        
        public AlunoService(IAlunoRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
