namespace UserApi.Application.Contracts.Services;

public interface IUsuarioRolService
{
    void Crear(int IdRol, int IdUsuario);
    void Eliminar(int IdRol, int IdUsuario);
}
