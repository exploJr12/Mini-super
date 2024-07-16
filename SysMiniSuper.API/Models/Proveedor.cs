using System.ComponentModel.DataAnnotations;


namespace SysMiniSuper.API.Models
{
    public class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string correo { get; set; }
        public List<Producto> Productos { get; set; }

    }
}
