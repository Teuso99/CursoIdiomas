using CursoIdiomas.Application.DTOs;
using CursoIdiomas.Application.Interfaces;
using CursoIdiomas.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CursoIdiomas.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : BaseController<Turma, TurmaDTO>
    {
        public TurmaController(ITurmaApplicationService service) : base(service)
        {

        }
    }
}
