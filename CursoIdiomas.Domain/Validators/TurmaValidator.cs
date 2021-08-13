using CursoIdiomas.Domain.Entities;
using FluentValidation;

namespace CursoIdiomas.Domain.Validators
{
    public class TurmaValidator : AbstractValidator<Turma>
    {
        public TurmaValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Informe um nome!")
                .NotNull().WithMessage("Informe um nome!");

            RuleFor(c => c.Turno)
                .NotEmpty().WithMessage("Informe um turno!")
                .NotNull().WithMessage("Informe um turno!");
        }
    }
}
