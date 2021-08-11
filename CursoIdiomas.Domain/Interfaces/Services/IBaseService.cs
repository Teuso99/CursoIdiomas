using CursoIdiomas.Domain.Entities;
using FluentValidation;
using System.Collections.Generic;

namespace CursoIdiomas.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        TEntity Add(TEntity obj);

        IList<TEntity> Get();

        TEntity GetById(int id);

        TEntity Update(TEntity obj);

        void Delete(int id);
    }
}
