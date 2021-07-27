using CursoIdiomas.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoIdiomas.Service.Validators
{
    public class AlunoValidator : AbstractValidator<Aluno>
    {
        public AlunoValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Informe um nome!")
                .NotNull().WithMessage("Informe um nome!");

            RuleFor(c => c.Matricula)
                .NotEmpty().WithMessage("Informe uma matrícula!")
                .NotNull().WithMessage("Informe uma matrícula!");

            RuleFor(c => c.Idade)
                .NotEmpty().WithMessage("Informe uma idade!")
                .NotNull().WithMessage("Informe uma idade!");
        }
    }
}
