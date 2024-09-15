using UserApi.Application.Contracts.Repository;
using UserApi.Infrastructure.Persistence;

namespace UserApi.Infrastructure.Repositories.UsuarioRol;

public class UsuarioRolRepository : IUsuarioRolRepository
{
    private readonly UserApiDBContext _UsuarioRol;
    public UsuarioRolRepository(UserApiDBContext userApiDBContext)
    {
        _UsuarioRol = userApiDBContext;        
    }

    public void Crear(int IdRol, int IdUsuario)
    {
        var usuario = _UsuarioRol.Usuario.FirstOrDefault(x => x.IdUsuario == IdUsuario);
        var rol = _UsuarioRol.Rol.FirstOrDefault(x => x.IdRol == IdRol);
        _UsuarioRol.Add(new Domain.Entities.UsuarioRol(usuario, rol));
        _UsuarioRol.SaveChanges();
    }

    public void Eliminar(int IdRol, int IdUsuario)
    {
        var usuarioRol = _UsuarioRol.UsuarioRol.FirstOrDefault(x => x.Rol.IdRol == IdRol && x.Usuario.IdUsuario == IdUsuario);
        if (usuarioRol != null)
        {
            _UsuarioRol.UsuarioRol.Remove(usuarioRol);
            _UsuarioRol.SaveChanges();
        }
    }
}
