using CursoIdiomas.Domain.Entities;
using CursoIdiomas.Domain.Interfaces;
using CursoIdiomas.Service.Validators;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CursoIdiomas.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("Authenticate")]
        public IActionResult Authenticate([FromBody] Usuario usuario)
        {
            if (usuario == null)
            {
                return NotFound();
            }

            return Execute(() => _service.Authenticate(usuario));
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register([FromBody] Usuario usuario)
        {
            if (usuario == null)
            {
                return NotFound();
            }

            return Execute(() => _service.Register<UsuarioValidator>(usuario).Id);
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
