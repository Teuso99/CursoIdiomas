using CursoIdiomas.Domain.Entities;

namespace CursoIdiomas.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        void Register(Usuario obj);
        Usuario Authenticate(Usuario obj);
    }
}
