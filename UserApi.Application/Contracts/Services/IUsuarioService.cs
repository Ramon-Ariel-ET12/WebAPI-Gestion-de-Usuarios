using UserApi.Domain.Entities;

namespace UserApi.Application.Contracts.Services;

public interface IUsuarioService
{
    void Crear(Usuario usuario);
    List<Usuario> ObtenerUsuario();
    List<Usuario> ObtenerUsuarioPorId(int IdUsuario);
    void Modificar(int IdUsuario, Usuario usuario);
    void Eliminar(int IdUsuario);
}
