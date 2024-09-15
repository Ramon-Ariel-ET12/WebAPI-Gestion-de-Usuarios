using Carter;
using Microsoft.AspNetCore.Mvc;
using UserApi.Application.Contracts.Services;

namespace UserApi.Presentation.Controllers.UsuarioRol
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioRolEndPoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/rol/{IdRol}/usuario/{IdUsuario}", ([FromServices] IUsuarioRolService usuarioRolService, IUsuarioService usuarioService, IRolService rolService, int IdRol, int IdUsuario) =>
            {
                var usuario = usuarioService.ObtenerUsuarioPorId(IdUsuario);
                var rol = rolService.ObtenerRolPorId(IdRol);
                if (usuario.Count == 0 || rol.Count == 0)
                {
                    return Results.NotFound("404 Not Found");
                }
                usuarioRolService.Crear(IdRol, IdUsuario);
                return Results.Created();
            });

            app.MapDelete("/api/rol/{IdRol}/usuario/{IdUsuario}", ([FromServices] IUsuarioRolService usuarioRolService, IUsuarioService usuarioService, IRolService rolService, int IdRol, int IdUsuario) =>
            {
                var usuario = usuarioService.ObtenerUsuarioPorId(IdUsuario);
                var rol = rolService.ObtenerRolPorId(IdRol);
                if (usuario.Count == 0 || rol.Count == 0)
                {
                    return Results.NotFound("404 Not Found");
                }
                usuarioRolService.Eliminar(IdRol, IdUsuario);
                return Results.NoContent();
            });

            app.MapPost("/api/usuario/{IdUsuario}/rol/{IdRol}", ([FromServices] IUsuarioRolService usuarioRolService, IUsuarioService usuarioService, IRolService rolService, int IdUsuario, int IdRol) =>
            {
                var usuario = usuarioService.ObtenerUsuarioPorId(IdUsuario);
                var rol = rolService.ObtenerRolPorId(IdRol);
                if (usuario.Count == 0 || rol.Count == 0)
                {
                    return Results.NotFound("404 Not Found");
                }
                usuarioRolService.Crear(IdRol, IdUsuario);
                return Results.Created();
            });

            app.MapDelete("/api/usuario/{IdUsuario}/rol/{IdRol}", ([FromServices] IUsuarioRolService usuarioRolService, IUsuarioService usuarioService, IRolService rolService, int IdUsuario, int IdRol) =>
            {
                var usuario = usuarioService.ObtenerUsuarioPorId(IdUsuario);
                var rol = rolService.ObtenerRolPorId(IdRol);
                if (usuario.Count == 0 || rol.Count == 0)
                {
                    return Results.NotFound("404 Not Found");
                }
                usuarioRolService.Eliminar(IdRol, IdUsuario);
                return Results.NoContent();
            });
        }
    }
}
