using CursoIdiomas.Application.DTOs;
using CursoIdiomas.Application.Interfaces;
using CursoIdiomas.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CursoIdiomas.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : BaseController<Usuario, UsuarioDTO>
    {
        private readonly IUsuarioApplicationService _usuarioService;

        public UsuarioController(IUsuarioApplicationService service) : base(service)
        {
            _usuarioService = service;
        }

        [HttpPost]
        [Route("Authentication")]
        public IActionResult Authenticate([FromBody] UsuarioDTO entity)
        {
            return Execute(() => _usuarioService.Authenticate(entity));
        }
    }
}
