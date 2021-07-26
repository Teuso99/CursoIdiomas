using CursoIdiomas.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoIdiomas.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Informe um nome!")
                .NotNull().WithMessage("Informe um nome!");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Informe um email!")
                .NotNull().WithMessage("Informe um email!");

            RuleFor(c => c.Senha)
                .NotEmpty().WithMessage("Informe uma senha!")
                .NotNull().WithMessage("Informe uma senha!");
        }
    }
}
