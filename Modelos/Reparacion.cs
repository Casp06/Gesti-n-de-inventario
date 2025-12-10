using System.ComponentModel.DataAnnotations;

namespace Tarea3.Models
{
    public class Reparacion
        // Campos basados en la tabla REPARACION del PDF
    {
        [Key]
        public string ID_Reparacion { get; set; } = Guid.NewGuid().ToString();

        // Foreign Key: Asume que tienes una tabla Cliente (ID Cliente)
        public string ID_Cliente { get; set; } = string.Empty; 
        
        // Foreign Key: Asume que tienes una tabla Técnico (ID_Tecnico)
        public string ID_Tecnico { get; set; } = string.Empty; 

        public DateTime Fecha_Ingreso { get; set; } = DateTime.Now;
        
        public string Dispositivo { get; set; } = string.Empty;
        
        public string FallaReportada { get; set; } = string.Empty;
        
        public string Diagnostico { get; set; } = string.Empty;

        // Estado: Pendiente, En Proceso, Terminada, Entregada
        public string EstadoServicio { get; set; } = "Pendiente"; 
        
        public decimal CostoReparacion { get; set; } = 0;

        // Propiedades de navegación (opcional por ahora)
        // public Cliente Cliente { get; set; } 
    }
}