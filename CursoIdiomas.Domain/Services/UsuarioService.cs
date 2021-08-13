using CursoIdiomas.Domain.Entities;
using CursoIdiomas.Domain.Interfaces.Repositories;
using CursoIdiomas.Domain.Interfaces.Services;

namespace CursoIdiomas.Domain.Services
{
    public class UsuarioService : BaseService<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public string Authenticate(Usuario obj)
        {
            var user = _repository.Authenticate(obj);

            if (user == null)
            {
                return string.Empty;
            }

            var token = TokenService.GenerateToken(user);

            return token;
        }
    }
}
