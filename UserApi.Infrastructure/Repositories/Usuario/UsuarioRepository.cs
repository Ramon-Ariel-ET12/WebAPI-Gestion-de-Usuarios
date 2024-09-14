using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using UserApi.Application.Contracts.Repository;
using UserApi.Infrastructure.Persistence;

namespace UserApi.Infrastructure.Repositories.Usuario;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly UserApiDBContext _Usuario;
    public UsuarioRepository(UserApiDBContext context)
    {
        _Usuario = context;
    }

    public void CrearUsuario(Domain.Entities.Usuario usuario)
    {
        _Usuario.Usuario.Add(new Domain.Entities.Usuario(usuario.Nombre, usuario.Email, usuario.Contrasena, usuario.Habilitado, DateTime.Now.ToUniversalTime()));
        _Usuario.SaveChanges();
    }

    public void ElminarUsuario(int IdUsuario)
    {
        var usuario = _Usuario.Usuario.FirstOrDefault(x => x.IdUsuario == IdUsuario);
        if (usuario != null)
        {
            _Usuario.Remove(usuario);
            _Usuario.SaveChanges();
        }
    }

    public void ModificarUsuario(int IdUsuario, Domain.Entities.Usuario usuario)
    {
        var usuarios = _Usuario.Usuario.FirstOrDefault(x => x.IdUsuario == IdUsuario);
        if (usuarios != null)
        {
            usuarios.Email = usuario.Email;
            usuarios.Habilitado = usuario.Habilitado;
            usuarios.Contrasena = usuario.Contrasena;
            _Usuario.SaveChanges();
        }
    }

    public List<Domain.Entities.Usuario> ObtenerUsuario(Expression<Func<Domain.Entities.Usuario, bool>>? expression)
    {
        if (expression == null)
        {
            return _Usuario.Usuario.ToList();
        }
        return _Usuario.Usuario.Where(expression).ToList();
    }
}
