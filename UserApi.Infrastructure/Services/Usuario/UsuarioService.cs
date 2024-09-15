using UserApi.Application.Contracts.Repository;
using UserApi.Application.Contracts.Services;
using UserApi.Domain.Entities;

namespace UserApi.Infrastructure.Services.Usuario;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _Usuario;

    public UsuarioService(IUsuarioRepository usuarioRepository)
    {
        _Usuario = usuarioRepository;
    }

    public void Crear(Domain.Entities.Usuario usuario)
    {
        _Usuario.CrearUsuario(usuario);
    }

    public void Eliminar(int IdUsuario)
    {
        _Usuario.ElminarUsuario(IdUsuario);
    }

    public void Modificar(Domain.Entities.Usuario usuario)
    {
        _Usuario.ModificarUsuario(usuario);
    }

    public List<Domain.Entities.Usuario> ObtenerUsuario()
    {
        return _Usuario.ObtenerUsuario();
    }

    public List<Domain.Entities.Usuario> ObtenerUsuarioPorId(int IdUsuario)
    {
        return _Usuario.ObtenerUsuario(x => x.IdUsuario == IdUsuario);
    }
}
