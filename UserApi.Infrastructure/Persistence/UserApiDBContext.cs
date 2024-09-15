using Microsoft.EntityFrameworkCore;
using UserApi.Domain.Entities;

namespace UserApi.Infrastructure.Persistence;

public class UserApiDBContext : DbContext
{
    public UserApiDBContext(DbContextOptions<UserApiDBContext> options) : base(options) { }

    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Rol> Rol { get; set; }
    public DbSet<UsuarioRol> UsuarioRol { get; set; }
}

// dotnet ef migrations add FirstMigration --context UserApiDBContext --project .\UserApi.Infrastructure\ --startup-project .\UserApi.Presentation\


// dotnet ef database update --context UserApiDBContext --project .\UserApi.Infrastructure\ --startup-project .\UserApi.Presentation\