using System.ComponentModel.DataAnnotations;


namespace SysMiniSuper.API.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
    }
}
