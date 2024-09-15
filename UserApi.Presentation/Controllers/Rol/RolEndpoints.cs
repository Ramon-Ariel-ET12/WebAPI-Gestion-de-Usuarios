using Carter;
using Microsoft.AspNetCore.Mvc;
using UserApi.Application.Contracts.Services;

namespace UserApi.Presentation.Controllers.Rol
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/rol", ([FromServices] IRolService rolService, Domain.Entities.Rol rol) =>
            {
                if (rol.Nombre == null)
                {
                    return Results.BadRequest("400 Bad requests xd, nah mentira, porfavor complete los campos vacios");
                }
                rolService.Crear(rol);
                return Results.Created();
            });

            app.MapGet("/api/rol", ([FromServices] IRolService rolService) =>
            {
                return Results.Ok(rolService.ObtenerRol());
            });

            app.MapGet("api/rol/{IdRol}", ([FromServices] IRolService rolService, int IdRol) =>
            {
                var rol = rolService.ObtenerRolPorId(IdRol);
                if (rol.Count == 0)
                {
                    return Results.NotFound("404 Not Found, Intente con otra id plis.");
                }
                return Results.Ok(rol);
            });

            app.MapPut("/api/rol/{IdRol}", ([FromServices] IRolService rolService, Domain.Entities.Rol rol) =>
            {
                if (!string.IsNullOrEmpty(rol.Nombre))
                {
                    return Results.BadRequest("400 Mala solicitud");
                }
                var existe = rolService.ObtenerRolPorId(rol.IdRol);
                if (existe.Count == 0)
                {
                    return Results.NotFound("404 Not Found");
                }
                rolService.Modificar(rol);
                return Results.NoContent();
            });

            app.MapDelete("api/rol/{IdRol}", ([FromServices] IRolService rolService, int IdRol) =>
            {
                var rol = rolService.ObtenerRolPorId(IdRol);
                if (rol.Count == 0)
                {
                    return Results.NotFound("404 No encontrado");
                }
                rolService.Eliminar(IdRol);
                return Results.NoContent();
            });
        }
    }
}
