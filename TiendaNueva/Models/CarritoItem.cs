using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaNueva.Models
{
    public class CarritoItem
    {
        [Key]
        public Guid CarritoItemID { get; set; }


        [Range(1,1000)]
        public int Cantidad { get; set; }


        [Precision(18,2)]
        public decimal PrecioFinalPorProducto { get; set; }



        public Guid ProductoID {  get; set; } 


        [ForeignKey("ProductoID")]
        public Producto Item { get; set; }


        public Guid CarritoID { get; set; }

        [ForeignKey("CarritoID")]
        public Carrito Carrito{ get; set; }




        public void CalcularPrecio()
        {
            decimal TotalItem = Item.PrecioUnitario * Cantidad;
            this.PrecioFinalPorProducto = TotalItem;
        }

    }
}
