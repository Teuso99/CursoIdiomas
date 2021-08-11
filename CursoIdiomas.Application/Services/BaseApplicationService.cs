using AutoMapper;
using CursoIdiomas.Application.DTOs;
using CursoIdiomas.Application.Interfaces;
using CursoIdiomas.Domain.Entities;
using CursoIdiomas.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace CursoIdiomas.Application.Services
{
    public class BaseApplicationService<TEntity, TEntityDTO> : 
        IBaseApplicationService<TEntity, TEntityDTO> where TEntity : BaseEntity
        where TEntityDTO : BaseDTO
    {
        protected readonly IBaseService<TEntity> _service;
        protected readonly IMapper _mapper;

        public BaseApplicationService(IMapper mapper, IBaseService<TEntity> service) : base()
        {
            _mapper = mapper;
            _service = service;
        }
        
        TEntityDTO IBaseApplicationService<TEntity, TEntityDTO>.Add(TEntityDTO entity)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<TEntityDTO> IBaseApplicationService<TEntity, TEntityDTO>.Get()
        {
            throw new System.NotImplementedException();
        }

        TEntityDTO IBaseApplicationService<TEntity, TEntityDTO>.GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        TEntityDTO IBaseApplicationService<TEntity, TEntityDTO>.Update(TEntityDTO entity)
        {
            throw new System.NotImplementedException();
        }

        void IBaseApplicationService<TEntity, TEntityDTO>.Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}