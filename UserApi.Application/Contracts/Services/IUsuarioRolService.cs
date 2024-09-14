namespace UserApi.Application.Contracts.Services;

public interface IUsuarioRolService
{
    void CrearPorIdRol(int IdRol, int IdUsuario);
    void EliminarPorIdRol(int IdRol, int IdUsuario);
    void CrearPorIdUsuario(int IdUsuario, int IdRol);
    void EliminarPorIdUsuario(int IdUsuario, int IdRol);
}
