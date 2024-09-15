using UserApi.Application.Contracts.Repository;
using UserApi.Application.Contracts.Services;

namespace UserApi.Infrastructure.Services.UsuarioRol;

public class UsuarioRolService : IUsuarioRolService
{
    private readonly IUsuarioRolRepository _UsuarioRol;
    public UsuarioRolService(IUsuarioRolRepository usuarioRolRepository)
    {
        _UsuarioRol = usuarioRolRepository;
    }

    public void Crear(int IdRol, int IdUsuario)
    {
        _UsuarioRol.Crear(IdRol, IdUsuario);
    }

    public void Eliminar(int IdRol, int IdUsuario)
    {
        _UsuarioRol.Eliminar(IdRol, IdUsuario);
    }
}
