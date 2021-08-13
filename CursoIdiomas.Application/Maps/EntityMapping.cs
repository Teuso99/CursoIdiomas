using AutoMapper;
using CursoIdiomas.Application.DTOs;
using CursoIdiomas.Domain.Entities;

namespace CursoIdiomas.Application.Maps
{
    public class EntityMapping : Profile
    {
        public EntityMapping()
        {
            CreateMap<Aluno, AlunoDTO>();
            CreateMap<AlunoDTO, Aluno>();

            CreateMap<Turma, TurmaDTO>();
            CreateMap<TurmaDTO, Turma>();

            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<UsuarioDTO, Usuario>();
        }
    }
}
