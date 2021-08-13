using AutoMapper;
using CursoIdiomas.Application.DTOs;
using CursoIdiomas.Application.Interfaces;
using CursoIdiomas.Domain.Entities;
using CursoIdiomas.Domain.Interfaces.Services;

namespace CursoIdiomas.Application.Services
{
    public class AlunoApplicationService :
        BaseApplicationService<Aluno, AlunoDTO>, IAlunoApplicationService
    {
        public AlunoApplicationService(IMapper mapper, IAlunoService service) :
            base(mapper, service)
        {

        }
    }
}
