using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoEF;

var builder = WebApplication.CreateBuilder(args);

//Base de datos en memoria
//builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB"));
builder.Services.AddSqlServer<TareasContext>(
    "Data Source=192.168.0.165\\SQLSTANDARD;Initial Catalog=TareasDb;Trusted_Connection=False;Integrated Security=false;TrustServerCertificate=True;User ID=sa;Password=C4mb5sc4l;");

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/dbconexion", async ([FromServices] TareasContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria: " + dbContext.Database.IsInMemory());
});

app.Run();
