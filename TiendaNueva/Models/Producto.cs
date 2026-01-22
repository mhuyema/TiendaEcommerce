using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaNueva.Models
{
    public class Producto
    {
        [Key]
        public Guid ProductoID { get; set; } 

        [Required][MaxLength(100)]
        public string Nombre { get; set; }

        [Required][MaxLength(500)]
        public string Descripcion { get; set; }

        [MaxLength(500)]
        [Url]
        public string URLImage {  get; set; }

        [Precision(18,2)]
        public decimal PrecioUnitario { get; set; }

       
        public Guid CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria? Categoria { get; set; }
    }
}
