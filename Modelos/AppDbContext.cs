using Microsoft.EntityFrameworkCore;
using Tarea3.Models; // Asegúrate de usar el namespace de tus modelos

namespace Tarea3.Data
{
    public class AppDbContext : DbContext
    {
        // Constructor que acepta opciones
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Define las colecciones (tablas) que EF Core debe mapear
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Reparacion> Reparaciones { get; set; }
        // public DbSet<Cliente> Clientes { get; set; } // Agrega otros si los creas
    }
}