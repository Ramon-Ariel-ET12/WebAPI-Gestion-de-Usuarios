using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using UserApi.Application.Contracts.Repository;
using UserApi.Infrastructure.Persistence;

namespace UserApi.Infrastructure.Repositories.Rol;
public class RolRepository : IRolRepository
{
    private readonly UserApiDBContext _Rol;
    public RolRepository(UserApiDBContext userApiDBContext)
    {
        _Rol = userApiDBContext;
    }
    public void CrearRol(Domain.Entities.Rol rol)
    {
        _Rol.Rol.Add(new Domain.Entities.Rol(rol.Nombre, rol.Habilitado, rol.FechaCreacion));
        _Rol.SaveChanges();
    }

    public void EliminarRol(int IdRol)
    {
        var rol = _Rol.Rol.FirstOrDefault(x => x.IdRol == IdRol);
        if (rol != null)
        {
            _Rol.Remove(rol);
            _Rol.SaveChanges();
        }
    }

    public void ModificarRol(int IdRol, Domain.Entities.Rol rol)
    {
        var roles = _Rol.Rol.FirstOrDefault(x => x.IdRol == IdRol);
        if (roles != null)
        {
            roles.Nombre = rol.Nombre;
            roles.Habilitado = rol.Habilitado;
            _Rol.SaveChanges();
        }
    }

    public List<Domain.Entities.Rol> ObtenerRol(Expression<Func<Domain.Entities.Rol, bool>>? expression = null)
    {
        if (expression == null)
        {
            return _Rol.Rol.ToList();
        }
        return _Rol.Rol.Where(expression).ToList();
    }
}
