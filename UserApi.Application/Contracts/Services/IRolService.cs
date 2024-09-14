using UserApi.Domain.Entities;

namespace UserApi.Application.Contracts.Services;

public interface IRolService
{
    void Crear(Rol rol);
    List<Rol> ObtenerRol();
    List<Rol> ObtenerRolPorId(int IdRol);
    void Modificar(int IdRol, Rol rol);
    void Eliminar(int IdRol);
}
