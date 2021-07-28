using CursoIdiomas.Domain.Entities;
using CursoIdiomas.Domain.Interfaces;
using CursoIdiomas.Service.Validators;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CursoIdiomas.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private IBaseService<Turma> _service;

        public TurmaController(IBaseService<Turma> service)
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
        public IActionResult Create([FromBody] Turma aluno)
        {
            if (aluno == null)
            {
                return NotFound();
            }

            return Execute(() => _service.Add<TurmaValidator>(aluno).Id);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Turma aluno)
        {
            if (aluno == null)
            {
                return NotFound();
            }

            return Execute(() => _service.Update<TurmaValidator>(aluno));
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
