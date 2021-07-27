using CursoIdiomas.Domain.Entities;
using CursoIdiomas.Domain.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace CursoIdiomas.Service.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public TEntity Add<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>
        {
            Validate(obj, Activator.CreateInstance<TValidator>());
            _repository.Insert(obj);
            return obj;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IList<TEntity> Get()
        {
            return _repository.Select();
        }

        public TEntity GetById(int id)
        {
            return _repository.Select(id);
        }

        public TEntity Update<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>
        {
            Validate(obj, Activator.CreateInstance<TValidator>());
            _repository.Update(obj);
            return obj;
        }

        private void Validate(TEntity obj, AbstractValidator<TEntity> validator)
        {
            if (obj == null)
            {
                throw new Exception("Registro não encontrado!");
            }

            validator.ValidateAndThrow(obj);
        }
    }
}
