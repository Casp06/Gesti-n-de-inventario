using tarea3.Components;
using Tarea3.Services;
using Microsoft.EntityFrameworkCore;
using Tarea3.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// 1. Configurar SQLite y EF Core
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? 
                       "DataSource=inventario.db";

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlite(connectionString)); 


builder.Services.AddScoped<ProductoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

// 🛑 CORRECCIÓN 1: Comentar esta línea para evitar problemas de proxy en Render
// app.UseHttpsRedirection(); 

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();


// 🛑 CORRECCIÓN 2: Código para asegurar que la base de datos (inventario.db) exista al iniciar
// Esto resuelve el error de la página blanca al intentar acceder a la DB por primera vez.
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AppDbContext>();

    // Asegura que el archivo SQLite y las tablas existan en el contenedor
    context.Database.EnsureCreated(); 
}

app.Run();