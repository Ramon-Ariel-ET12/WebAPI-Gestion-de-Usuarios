using System.Linq.Expressions;
using UserApi.Domain.Entities;

namespace UserApi.Application.Contracts.Repository;

public interface IUsuarioRepository
{
    void CrearUsuario(Usuario usuario);
    void ModificarUsuario(Usuario usuario);
    void ElminarUsuario(int IdUsuario);
    List<Usuario> ObtenerUsuario(Expression<Func<Usuario, bool>>? expression = null);
}
