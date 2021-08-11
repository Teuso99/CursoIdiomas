using CursoIdiomas.Domain.Entities;
using FluentValidation;
using System;

namespace CursoIdiomas.Domain.Services
{
    public static class ValidationService<TEntity> where TEntity : BaseEntity
    {
        public static void Validate(TEntity obj)
        {
            if (obj == null)
            {
                throw new Exception("Registro não encontrado!");
            }

            var validator = Activator.CreateInstance<AbstractValidator<TEntity>>();

            validator.ValidateAndThrow(obj);
        }
    }
}
