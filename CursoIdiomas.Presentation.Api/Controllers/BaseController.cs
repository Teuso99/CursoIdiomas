using CursoIdiomas.Application.DTOs;
using CursoIdiomas.Application.Interfaces;
using CursoIdiomas.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CursoIdiomas.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity, TEntityDTO> : ControllerBase
        where TEntity : BaseEntity where TEntityDTO : BaseDTO
    {
        protected readonly IBaseApplicationService<TEntity, TEntityDTO> _service;

        public BaseController(IBaseApplicationService<TEntity, TEntityDTO> service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Execute(() => _service.Get());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            return Execute(() => _service.GetById(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] TEntityDTO entity)
        {
            if (entity == null)
            {
                return NotFound();
            }

            return Execute(() => _service.Add(entity));
        }

        [HttpPut]
        public IActionResult Update([FromBody] TEntityDTO entity)
        {
            if (entity == null)
            {
                return NotFound();
            }

            return Execute(() => _service.Update(entity));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            Execute(() =>
            {
                _service.Delete(id);
                return Ok();
            });

            return new NoContentResult();
        }

        protected IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
