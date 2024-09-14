using System.Linq.Expressions;
using UserApi.Domain.Entities;

namespace UserApi.Application.Contracts.Repository;

public interface IUsuarioRolRepository
{
    void CrearPorIdRol(int IdRol, int IdUsuario);
    void EliminarPorIdRol(int IdRol, int IdUsuario);
    void CrearPorIdUsuario(int IdUsuario, int IdRol);
    void EliminarPorIdUsuario(int IdUsuario, int IdRol);
}
