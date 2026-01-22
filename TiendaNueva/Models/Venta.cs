using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaNueva.Models
{
    public class Venta
    {
        [Key]
        public Guid VentaID { get; set; }

        public DateTime FechaTransaccion { get; set; } = DateTime.Now;

        public string? UsuarioID { get; set; }

        public Guid CarritoID { get; set; }

        [ForeignKey("CarritoID")]
        public Carrito CarritoVendido {  get; set; }

        [Precision(18,2)]
        public decimal PrecioVenta { get; set; }


        public void GuardarPrecioFinal() 
        {
            this.PrecioVenta = CarritoVendido.PrecioFinal;
        }
    }
}
