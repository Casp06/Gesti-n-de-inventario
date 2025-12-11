using Microsoft.EntityFrameworkCore;
using Tarea3.Models;
using System;

namespace Tarea3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Reparacion> Reparaciones { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 1. Datos para la tabla Productos (10 productos con IDs únicos)
            modelBuilder.Entity<Producto>().HasData(
                // 1. Monitor (Stock OK)
                new Producto 
                { 
                    Id = "00000000-0000-0000-0000-000000000001", // ID ÚNICO
                    Nombre = "Monitor Curvo 27' 144Hz", 
                    PrecioUnitario = 250.00m, 
                    StockActual = 15, 
                    StockMinimo = 5,
                    CostoCompra = 180.00m,
                    CodigoSKU = "MON-27C-144",
                    FechaIngreso = new DateTime(2025, 9, 15), 
                    Categoria = "Monitores"
                },
                // 2. Teclado (Stock OK)
                new Producto 
                { 
                    Id = "00000000-0000-0000-0000-000000000002", // ID ÚNICO
                    Nombre = "Teclado Mecánico RGB", 
                    PrecioUnitario = 85.00m, 
                    StockActual = 30, 
                    StockMinimo = 10,
                    CostoCompra = 50.00m,
                    CodigoSKU = "TEC-MEC-RGB",
                    FechaIngreso = new DateTime(2025, 11, 20),
                    Categoria = "Periféricos"
                },
                // 3. RAM (Stock OK)
                new Producto 
                { 
                    Id = "00000000-0000-0000-0000-000000000003", // ID ÚNICO
                    Nombre = "Memoria RAM DDR4 16GB", 
                    PrecioUnitario = 55.00m, 
                    StockActual = 50, 
                    StockMinimo = 20,
                    CostoCompra = 40.00m,
                    CodigoSKU = "RAM-DDR4-16",
                    FechaIngreso = new DateTime(2025, 12, 10),
                    Categoria = "Componentes"
                },
                // 4. SSD (Stock OK)
                new Producto 
                { 
                    Id = "00000000-0000-0000-0000-000000000004", // ID ÚNICO
                    Nombre = "Disco SSD M.2 NVMe 1TB", 
                    PrecioUnitario = 99.00m, 
                    StockActual = 25, 
                    StockMinimo = 15,
                    CostoCompra = 70.00m,
                    CodigoSKU = "SSD-NVME-1TB",
                    FechaIngreso = new DateTime(2025, 10, 5),
                    Categoria = "Almacenamiento"
                },
                // 5. Mouse (Stock OK)
                new Producto 
                { 
                    Id = "00000000-0000-0000-0000-000000000005", // ID ÚNICO
                    Nombre = "Mouse Inalámbrico Gaming", 
                    PrecioUnitario = 45.00m, 
                    StockActual = 18, 
                    StockMinimo = 8,
                    CostoCompra = 25.00m,
                    CodigoSKU = "MOU-WL-GAM",
                    FechaIngreso = new DateTime(2025, 9, 28),
                    Categoria = "Periféricos"
                },
                
                // 6. RTX 4070 (Stock BAJO: 2 < 5)
                new Producto 
                { 
                    Id = "00000000-0000-0000-0000-000000000006", // ID ÚNICO
                    Nombre = "Tarjeta Gráfica RTX 4070", 
                    PrecioUnitario = 650.00m, 
                    StockActual = 2, 
                    StockMinimo = 5,
                    CostoCompra = 550.00m,
                    CodigoSKU = "GPU-RTX-4070",
                    FechaIngreso = new DateTime(2025, 8, 1),
                    Categoria = "Componentes"
                },
                // 7. Cámara Web (Stock MÍNIMO: 5 = 5)
                new Producto 
                { 
                    Id = "00000000-0000-0000-0000-000000000007", // ID ÚNICO
                    Nombre = "Cámara Web Full HD", 
                    PrecioUnitario = 30.00m, 
                    StockActual = 5, 
                    StockMinimo = 5,
                    CostoCompra = 18.00m,
                    CodigoSKU = "CAM-WEB-FHD",
                    FechaIngreso = new DateTime(2025, 12, 1),
                    Categoria = "Periféricos"
                },
                // 8. Procesador (Stock OK, pero cerca)
                new Producto 
                { 
                    Id = "00000000-0000-0000-0000-000000000008", // ID ÚNICO
                    Nombre = "Procesador Intel Core i7", 
                    PrecioUnitario = 350.00m, 
                    StockActual = 8, 
                    StockMinimo = 5,
                    CostoCompra = 280.00m,
                    CodigoSKU = "CPU-INT-I7",
                    FechaIngreso = new DateTime(2025, 7, 20),
                    Categoria = "Componentes"
                },
                // 9. Fuente de Poder (Stock MUY BAJO: 1 < 10)
                new Producto 
                { 
                    Id = "00000000-0000-0000-0000-000000000009", // ID ÚNICO
                    Nombre = "Fuente de Poder 750W", 
                    PrecioUnitario = 75.00m, 
                    StockActual = 1, 
                    StockMinimo = 10,
                    CostoCompra = 50.00m,
                    CodigoSKU = "PSU-750W-G",
                    FechaIngreso = new DateTime(2025, 10, 25),
                    Categoria = "Componentes"
                },
                // 10. Router (Stock AGOTADO: 0 < 3)
                new Producto 
                { 
                    Id = "00000000-0000-0000-0000-000000000010", // ID ÚNICO
                    Nombre = "Router Wi-Fi 6 AX1800", 
                    PrecioUnitario = 120.00m, 
                    StockActual = 0, 
                    StockMinimo = 3,
                    CostoCompra = 80.00m,
                    CodigoSKU = "RTR-AX-1800",
                    FechaIngreso = new DateTime(2025, 11, 1),
                    Categoria = "Redes"
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}