using CursoIdiomas.Domain.Entities;

namespace CursoIdiomas.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Usuario Authenticate(Usuario obj);
    }
}
