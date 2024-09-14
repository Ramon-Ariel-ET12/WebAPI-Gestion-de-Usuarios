using UserApi.Application.Contracts.Repository;
using UserApi.Application.Contracts.Services;

namespace UserApi.Infrastructure.Services.Rol;

public class RolService : IRolService
{
    private readonly IRolRepository _Rol;
    public RolService(IRolRepository rolRepository)
    {
        _Rol = rolRepository;
    }
    public void Crear(Domain.Entities.Rol rol)
    {
        _Rol.CrearRol(rol);
    }

    public void Eliminar(int IdRol)
    {
        _Rol.EliminarRol(IdRol);
    }

    public void Modificar(int IdRol, Domain.Entities.Rol rol)
    {
        _Rol.ModificarRol(IdRol, rol);
    }

    public List<Domain.Entities.Rol> ObtenerRol()
    {
        return _Rol.ObtenerRol();
    }

    public List<Domain.Entities.Rol> ObtenerRolPorId(int IdRol)
    {
        return _Rol.ObtenerRol(x => x.IdRol == IdRol);
    }
}
