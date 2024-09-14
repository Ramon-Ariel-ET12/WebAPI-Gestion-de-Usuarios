using Microsoft.EntityFrameworkCore;
using UserApi.Infrastructure.Persistence;
using Carter;
using UserApi.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure the conection to PostgreSQL
builder.Services.AddDbContext<UserApiDBContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("ABCDB")));

// Add Carter services
builder.Services.AddCarter();

// Add Service manager and Repository manager
builder.Services.AddServiceManager();
builder.Services.AddRepositoryManager();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Use Carter
app.MapCarter();

app.Run();
