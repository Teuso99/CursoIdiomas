using CursoIdiomas.Domain.Entities;

namespace CursoIdiomas.Domain.Interfaces.Services
{
    public interface IUsuarioService : IBaseService<Usuario>
    {
        string Authenticate(Usuario obj);
    }
}
