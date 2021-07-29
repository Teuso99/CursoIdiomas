using CursoIdiomas.Domain.Entities;
using FluentValidation;

namespace CursoIdiomas.Domain.Interfaces
{
    public interface IUsuarioService
    {
        Usuario Register<TValidator>(Usuario obj) where TValidator : AbstractValidator<Usuario>;

        string Authenticate(Usuario obj);
    }
}
