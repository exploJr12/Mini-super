using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysMiniSuper.API.Models
{
    public class Venta
    {
        [Key]
        public int IdVenta { get; set; }
        [ForeignKey("DetalleVenta")]
        public int IdDetalle { get; set; }
        [ForeignKey("Empleado")]
        public int IdEmpleado { get; set; }
        public DateTime FechaVenta { get; set; }
        public string MetodoPago { get; set; }
        public decimal TotalPago { get; set; }
        public bool Deuda { get; set; }
        public decimal PagoAdicional { get; set; }
        public Detalle_Venta Detalle_Venta { get; set; }
        public Empleado Empleado { get; set; }
    }
}
