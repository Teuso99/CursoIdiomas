using CursoIdiomas.Domain.Entities;
using CursoIdiomas.Domain.Interfaces.Repositories;
using CursoIdiomas.Infrastructure.Context;

namespace CursoIdiomas.Infrastructure.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(SqlContext context) : base(context)
        {

        }

        public Usuario Authenticate(Usuario obj)
        {
            return _context.Set<Usuario>().Find(obj.Id);
        }
    }
}
