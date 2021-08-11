using CursoIdiomas.Domain.Entities;
using CursoIdiomas.Domain.Interfaces.Repositories;
using CursoIdiomas.Domain.Interfaces.Services;
using FluentValidation;
using System.Collections.Generic;

namespace CursoIdiomas.Domain.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public TEntity Add(TEntity obj)
        {
            ValidationService<TEntity>.Validate(obj);
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

        public TEntity Update(TEntity obj)
        {
            ValidationService<TEntity>.Validate(obj);
            _repository.Update(obj);
            return obj;
        }
    }
}
