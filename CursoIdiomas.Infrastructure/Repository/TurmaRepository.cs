using CursoIdiomas.Domain.Entities;
using CursoIdiomas.Domain.Interfaces.Repositories;
using CursoIdiomas.Infrastructure.Context;

namespace CursoIdiomas.Infrastructure.Repository
{
    public class TurmaRepository : BaseRepository<Turma>, ITurmaRepository
    {
        public TurmaRepository(SqlContext context) : base(context)
        {

        }
    }
}
