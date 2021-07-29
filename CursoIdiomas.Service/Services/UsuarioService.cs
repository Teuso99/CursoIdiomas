using CursoIdiomas.Domain.Entities;
using CursoIdiomas.Domain.Interfaces;
using FluentValidation;
using System;

namespace CursoIdiomas.Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }
        
        public string Authenticate(Usuario obj)
        {
            var user = _repository.Authenticate(obj);

            if (user == null)
            {
                return String.Empty;
            }

            var token = TokenService.GenerateToken(user);

            return token;
        }

        public Usuario Register<TValidator>(Usuario obj) where TValidator : AbstractValidator<Usuario>
        {
            Validate(obj, Activator.CreateInstance<TValidator>());
            _repository.Register(obj);
            return obj;
        }

        private void Validate(Usuario obj, AbstractValidator<Usuario> validator)
        {
            if (obj == null)
            {
                throw new Exception("Registro não encontrado");
            }

            validator.ValidateAndThrow(obj);
        }
    }
}
