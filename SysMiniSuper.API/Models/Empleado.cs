using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SysMiniSuper.API.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        [ForeignKey("Rol")]
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public Rol Rol { get; set; }
        public List<Venta> Ventas { get; set; }
        
    }
}
