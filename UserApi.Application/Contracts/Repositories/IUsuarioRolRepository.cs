using System.Linq.Expressions;
using UserApi.Domain.Entities;

namespace UserApi.Application.Contracts.Repository;

public interface IUsuarioRolRepository
{
    void Crear(int IdRol, int IdUsuario);
    void Eliminar(int IdRol, int IdUsuario);
}
