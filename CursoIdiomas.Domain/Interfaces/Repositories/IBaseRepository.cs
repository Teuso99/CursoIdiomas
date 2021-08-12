using CursoIdiomas.Domain.Entities;
using System.Collections.Generic;

namespace CursoIdiomas.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity obj);

        TEntity Select(int id);

        IList<TEntity> Select();

        void Update(TEntity obj);

        void Delete(int id);
    }
}
