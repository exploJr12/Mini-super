using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysMiniSuper.API.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        [ForeignKey("Categoria")]
        public int IdCategoria { get; set; }
        [ForeignKey("Proveedor")]
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string codigo { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra { get; set; }
        public int CantidadStock { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public Categoria Categorias { get; set; }
        public Proveedor Proveedores { get; set; }
    }
}
