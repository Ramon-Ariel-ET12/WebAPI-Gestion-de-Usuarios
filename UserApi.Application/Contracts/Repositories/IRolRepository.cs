using System.Linq.Expressions;
using UserApi.Domain.Entities;

namespace UserApi.Application.Contracts.Repository;

public interface IRolRepository
{
    void CrearRol(Rol rol);
    void ModificarRol(Rol rol);
    void EliminarRol(int IdRol);
    List<Rol> ObtenerRol(Expression<Func<Rol, bool>>? expression = null);
}
