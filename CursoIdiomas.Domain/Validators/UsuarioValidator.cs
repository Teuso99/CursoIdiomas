using CursoIdiomas.Domain.Entities;
using FluentValidation;

namespace CursoIdiomas.Domain.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Informe um email!")
                .NotNull().WithMessage("Informe um email!");

            RuleFor(c => c.Senha)
                .NotEmpty().WithMessage("Informe uma senha!")
                .NotNull().WithMessage("Informe uma senha!");
        }
    }
}
