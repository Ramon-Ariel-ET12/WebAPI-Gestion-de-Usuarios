using Microsoft.Extensions.DependencyInjection;
using UserApi.Application.Contracts.Services;
using UserApi.Infrastructure.Services.Rol;
using UserApi.Infrastructure.Services.Usuario;
using UserApi.Infrastructure.Services.UsuarioRol;

namespace UserApi.Infrastructure.Services;

public static class ConfigureService
{
    public static IServiceCollection AddServiceManager(this IServiceCollection services)
    {
        // Registrar servicios
        services.AddScoped<IUsuarioService, UsuarioService>();
        services.AddScoped<IRolService, RolService>();
        services.AddScoped<IUsuarioRolService, UsuarioRolService>();

        return services;
    }
}
