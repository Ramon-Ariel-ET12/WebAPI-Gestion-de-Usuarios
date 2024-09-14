using Microsoft.Extensions.DependencyInjection;
using UserApi.Application.Contracts.Repository;
using UserApi.Infrastructure.Repositories.Rol;
using UserApi.Infrastructure.Repositories.Usuario;
using UserApi.Infrastructure.Repositories.UsuarioRol;

namespace UserApi.Infrastructure.Services;

public static class ConfigureRepository
{
    public static IServiceCollection AddRepositoryManager(this IServiceCollection services)
    {
        // Registrar repositorios
        services.AddTransient<IUsuarioRepository, UsuarioRepository>();
        services.AddTransient<IRolRepository, RolRepository>();
        services.AddTransient<IUsuarioRolRepository, UsuarioRolRepository>();

        return services;
    }
}
