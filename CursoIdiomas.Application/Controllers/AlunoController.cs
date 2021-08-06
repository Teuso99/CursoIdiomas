using CursoIdiomas.Domain.Entities;
using CursoIdiomas.Domain.Interfaces.Services;
using CursoIdiomas.Domain.Validators;
using CursoIdiomas.Service.Validators;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CursoIdiomas.Application.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private IBaseService<Aluno> _service;

        public AlunoController(IBaseService<Aluno> service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Execute(() => _service.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            
            return Execute(() => _service.GetById(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] Aluno aluno)
        {
            if (aluno == null)
            {
                return NotFound();
            }
            
            return Execute(() => _service.Add<AlunoValidator>(aluno).Id);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Aluno aluno)
        {
            if (aluno == null)
            {
                return NotFound();
            }

            return Execute(() => _service.Update<AlunoValidator>(aluno));
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
                return true;
            });

            return new NoContentResult();
        }

        private IActionResult Execute(Func<object> func)
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
