using CursoIdiomas.Domain.Entities;
using CursoIdiomas.Domain.Interfaces.Repositories;
using CursoIdiomas.Domain.Interfaces.Services;

namespace CursoIdiomas.Domain.Services
{
    public class TurmaService : BaseService<Turma>, ITurmaService
    {
        private readonly ITurmaRepository _repository;

        public TurmaService(ITurmaRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
