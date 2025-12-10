using tarea3.Components;
using Tarea3.Services;
using Microsoft.EntityFrameworkCore;
using Tarea3.Data; // Asumiendo que tu contexto está aquí

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Después de builder.Services.AddRazorPages();

// 1. Configurar SQLite y EF Core
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? 
                       "DataSource=inventario.db"; // Si no hay configuración, usa este archivo

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlite(connectionString)); 


builder.Services.AddScoped<ProductoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
