using CursoIdiomas.Domain.Entities;
using CursoIdiomas.Domain.Interfaces;
using CursoIdiomas.Infrastructure.Context;

namespace CursoIdiomas.Infrastructure.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    { 
        protected readonly SqlContext _context;

        public UsuarioRepository(SqlContext context)
        {
            _context = context;
        }
        
        public Usuario Authenticate(Usuario obj)
        {
            return _context.Set<Usuario>().Find(obj.Id);
        }

        public void Register(Usuario obj)
        {
            _context.Set<Usuario>().Add(obj);
            _context.SaveChanges();
        }
    }
}
