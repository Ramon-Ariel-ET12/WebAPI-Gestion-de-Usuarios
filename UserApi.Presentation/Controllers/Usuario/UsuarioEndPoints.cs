using Carter;
using Microsoft.AspNetCore.Mvc;
using UserApi.Application.Contracts.Services;

namespace UserApi.Presentation.Controllers.Usuario;

[ApiController]
[Route("api/[controller]")]
public class UsuarioEndPoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/api/Usuario", ([FromServices] IUsuarioService usuarioService, Domain.Entities.Usuario usuario) =>
        {
            if (usuario.Nombre == null || usuario.Email == null || usuario.Contrasena == null)
            {
                return Results.BadRequest("Por favor, no deje campos vacios.");
            }
            usuarioService.Crear(usuario);
            return Results.Created();
        });

        app.MapGet("/api/Usuarios", ([FromServices] IUsuarioService usuarioService) =>
        {
            var usuarios = usuarioService.ObtenerUsuario();
            return Results.Ok(usuarios);
        });

        app.MapGet("/api/Usuario/{IdUsuario}", ([FromServices] IUsuarioService usuarioService, int IdUsuario) =>
        {
            var usuario = usuarioService.ObtenerUsuarioPorId(IdUsuario);
            if (usuario.Count == 0)
            {
                return Results.NotFound();
            }
            return Results.Ok(usuario);
        });

        app.MapPut("/api/Usuario/{IdUsuario}", ([FromServices] IUsuarioService usuarioService, Domain.Entities.Usuario usuario) =>
        {
            if (!string.IsNullOrEmpty(usuario.Nombre))
            {
                return Results.BadRequest();
            }

            var existe = usuarioService.ObtenerUsuarioPorId(usuario.IdUsuario);

            if (existe.Count == 0)
            {
                return Results.NotFound();
            }

            usuarioService.Modificar(usuario);
            return Results.NoContent();
        });

        app.MapDelete("/api/Usuario/{IdUsuario}", ([FromServices] IUsuarioService usuarioService, int IdUsuario) =>
        {
            var exise = usuarioService.ObtenerUsuarioPorId(IdUsuario);

            if (exise.Count == 0)
            {
                return Results.NotFound();
            }
            usuarioService.Eliminar(IdUsuario);
            return Results.NoContent();
        });
    }
}
