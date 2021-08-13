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

        public TEntityDTO Add(TEntityDTO entity)
        {
            var serviceCall = _service.Add(_mapper.Map<TEntity>(entity));
            return _mapper.Map<TEntityDTO>(serviceCall);
        }

        public IEnumerable<TEntityDTO> Get()
        {
            return _mapper.Map<IEnumerable<TEntityDTO>>(_service.Get());
        }

        public TEntityDTO GetById(int id)
        {
            return _mapper.Map<TEntityDTO>(_service.GetById(id));
        }

        public TEntityDTO Update(TEntityDTO entity)
        {
            var serviceCall = _service.Update(_mapper.Map<TEntity>(entity));
            return _mapper.Map<TEntityDTO>(serviceCall);
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}