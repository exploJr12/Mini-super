using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysMiniSuper.API.Models
{
    public class Detalle_Venta
    {
        [Key]
        public int IdDetalle { get; set; }
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        [ForeignKey("Producto")]
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public Cliente Cliente { get; set; }
        public Producto Producto { get; set; }
        public List<Venta> Ventas { get; set; }
    }
}
