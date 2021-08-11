using CursoIdiomas.Application.DTOs;
using CursoIdiomas.Domain.Entities;
using System.Collections.Generic;

namespace CursoIdiomas.Application.Interfaces
{
    public interface IBaseApplicationService<TEntity, TEntityDTO> where TEntity : BaseEntity
        where TEntityDTO : BaseDTO
    {
        TEntityDTO Add(TEntityDTO entity);

        IEnumerable<TEntityDTO> Get();

        TEntityDTO GetById(int id);

        TEntityDTO Update(TEntityDTO entity);

        void Delete(int id);
    }
}
