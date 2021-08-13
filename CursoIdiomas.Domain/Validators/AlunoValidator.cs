using CursoIdiomas.Domain.Entities;
using FluentValidation;

namespace CursoIdiomas.Domain.Validators
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
