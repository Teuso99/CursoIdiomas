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
    public class AlunoController : BaseController<Aluno, AlunoDTO>
    {
        public AlunoController(IAlunoApplicationService service) : base(service)
        {

        }
    }
}
