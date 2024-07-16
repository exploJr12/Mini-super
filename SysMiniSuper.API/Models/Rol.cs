using System.ComponentModel.DataAnnotations;

namespace SysMiniSuper.API.Models
{
    public class Rol
    {
        [Key]
        public int IdRol { get; set; }
        public string NombreRol { get; set; }

        public List<Empleado> Empleados { get; set; }
    }
}
