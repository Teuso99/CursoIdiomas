using CursoIdiomas.Application.DTOs;
using CursoIdiomas.Application.Interfaces;
using CursoIdiomas.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CursoIdiomas.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : BaseController<Aluno, AlunoDTO>
    {
        public AlunoController(IAlunoApplicationService service) : base(service)
        {

        }
    }
}
