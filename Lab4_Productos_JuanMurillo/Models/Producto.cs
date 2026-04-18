using System.ComponentModel.DataAnnotations;

namespace Lab4_Productos_JuanMurillo.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Range(0.01, 999999)]
        public decimal Precio { get; set; }

        [Required]
        public string Categoria { get; set; }
    }
}
