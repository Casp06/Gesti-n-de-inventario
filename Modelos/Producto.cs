using System.ComponentModel.DataAnnotations;

namespace Tarea3.Models
{
    public class Producto
    {
        // Clave Primaria
        [Key] 
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        public decimal PrecioUnitario { get; set; } = 0;

        public int StockActual { get; set; } = 0;
        
        // Asumiendo que quieres registrar la fecha de ingreso
        public DateTime FechaIngreso { get; set; } = DateTime.Now;
        public string CodigoSKU { get; set; } = string.Empty;
        
        // Puedes añadir otros campos de tu PDF (Costo Compra, Stock Mínimo, Categoría, etc.)
        public decimal CostoCompra { get; set; } = 0;
        public int StockMinimo { get; set; } = 0;
        public string Categoria { get; set; } = string.Empty;
    }
}