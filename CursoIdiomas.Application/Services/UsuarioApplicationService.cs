using AutoMapper;
using CursoIdiomas.Application.DTOs;
using CursoIdiomas.Application.Interfaces;
using CursoIdiomas.Domain.Entities;
using CursoIdiomas.Domain.Interfaces.Services;

namespace CursoIdiomas.Application.Services
{
    public class UsuarioApplicationService :
        BaseApplicationService<Usuario, UsuarioDTO>, IUsuarioApplicationService
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioApplicationService(IMapper mapper, IUsuarioService service) :
            base(mapper, service)
        {
            _usuarioService = service;
        }

        public string Authenticate(UsuarioDTO entity)
        {
            return _usuarioService.Authenticate(_mapper.Map<Usuario>(entity));
        }
    }
}
