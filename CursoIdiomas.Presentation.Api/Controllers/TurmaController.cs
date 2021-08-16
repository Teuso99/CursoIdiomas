using CursoIdiomas.Application.DTOs;
using CursoIdiomas.Application.Interfaces;
using CursoIdiomas.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CursoIdiomas.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class TurmaController : BaseController<Turma, TurmaDTO>
    {
        public TurmaController(ITurmaApplicationService service) : base(service)
        {

        }
    }
}
