using CursoIdiomas.Application.Interfaces;
using CursoIdiomas.Application.Services;
using CursoIdiomas.Domain.Interfaces.Repositories;
using CursoIdiomas.Domain.Interfaces.Services;
using CursoIdiomas.Domain.Services;
using CursoIdiomas.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CursoIdiomas.Infrastructure.IoC
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection serviceCollection)
        {
            //Application
            serviceCollection.AddScoped(typeof(IBaseApplicationService<,>), typeof(BaseApplicationService<,>));
            serviceCollection.AddScoped<IAlunoApplicationService, AlunoApplicationService>();
            serviceCollection.AddScoped<ITurmaApplicationService, TurmaApplicationService>();
            serviceCollection.AddScoped<IUsuarioApplicationService, UsuarioApplicationService>();

            //Domain
            serviceCollection.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            serviceCollection.AddScoped<IAlunoService, AlunoService>();
            serviceCollection.AddScoped<ITurmaService, TurmaService>();
            serviceCollection.AddScoped<IUsuarioService, UsuarioService>();

            //Repository
            serviceCollection.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IAlunoRepository, AlunoRepository>();
            serviceCollection.AddScoped<ITurmaRepository, TurmaRepository>();
            serviceCollection.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
