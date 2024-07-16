using System.ComponentModel.DataAnnotations;

namespace SysMiniSuper.API.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
