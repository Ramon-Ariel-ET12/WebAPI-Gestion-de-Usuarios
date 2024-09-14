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

    public void CrearPorIdRol(int IdRol, int IdUsuario)
    {
        _UsuarioRol.CrearPorIdRol(IdRol, IdUsuario);
    }

    public void CrearPorIdUsuario(int IdUsuario, int IdRol)
    {
        _UsuarioRol.CrearPorIdUsuario(IdUsuario, IdRol);
    }

    public void EliminarPorIdRol(int IdRol, int IdUsuario)
    {
        _UsuarioRol.EliminarPorIdRol(IdRol, IdUsuario);
    }

    public void EliminarPorIdUsuario(int IdUsuario, int IdRol)
    {
        _UsuarioRol.EliminarPorIdUsuario(IdUsuario, IdRol);
    }
}
