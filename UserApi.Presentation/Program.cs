using Microsoft.EntityFrameworkCore;
using UserApi.Infrastructure.Persistence;
using Carter;
using UserApi.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<UserApiDBContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("Escuela")));

builder.Services.AddCarter();
builder.Services.AddServiceManager();
builder.Services.AddRepositoryManager();

var app = builder.Build();

var opciones = new DbContextOptionsBuilder<UserApiDBContext>();

var context = new UserApiDBContext(opciones.Options);

context.Database.Migrate();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapCarter();

app.Run();