using Microsoft.EntityFrameworkCore;
using UserApi.Infrastructure.Persistence;
using Carter;
using UserApi.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentVariables();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<UserApiDBContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("Escuela")));

builder.Services.AddCarter();
builder.Services.AddServiceManager();
builder.Services.AddRepositoryManager();

var opciones = new DbContextOptionsBuilder<UserApiDBContext>();

opciones.UseNpgsql(builder.Configuration.GetConnectionString("Escuela"));

var context = new UserApiDBContext(opciones.Options);

context.Database.Migrate();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapCarter();

app.Run();