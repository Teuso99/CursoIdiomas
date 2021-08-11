using AutoMapper;
using CursoIdiomas.Application.DTOs;
using CursoIdiomas.Application.Interfaces;
using CursoIdiomas.Domain.Entities;
using CursoIdiomas.Domain.Interfaces.Services;

namespace CursoIdiomas.Application.Services
{
    public class TurmaApplicationService :
        BaseApplicationService<Turma, TurmaDTO>, ITurmaApplicationService
    {
        public TurmaApplicationService(IMapper mapper, ITurmaService service) :
            base(mapper, service)
        {

        }
    }
}
