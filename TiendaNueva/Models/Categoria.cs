using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaNueva.Models
{
    public class Categoria
    {
        [Key]
        public Guid CategoriaId { get; set; }
        
        [Required] [MaxLength(100)]
        public string CategoriaName { get; set; }
        
        [Required] [MaxLength(500)]
        public string Descripcion {get; set; }

        public List<Producto>? Productos {  get; set; }
    
    }
}
