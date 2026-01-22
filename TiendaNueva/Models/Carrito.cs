using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TiendaNueva.Models
{
    public class Carrito
    {
        [Key]
        public Guid CarritoID { get; set; }

        public string? UsuarioID { get; set; }

        public List<CarritoItem> Productos { get; set; }

        [Precision(18,2)]
        public decimal PrecioFinal { get; set;}

        public Estado? EstadoCarrito {  get; set; }



        public void CalcularPrecioFinal() 
        {

            decimal Subtotal = 0;
            foreach(var p in this.Productos) 
            {
                p.CalcularPrecio();
                Subtotal += p.PrecioFinalPorProducto;
            }

            this.PrecioFinal = Subtotal;
        }

        public void LlenarCarrito(List<CarritoItem> Items)
        {
            foreach (var item in Items)
            {

                this.Productos.Add(item);
            }

            this.CalcularPrecioFinal();
            this.EstadoCarrito = Estado.ACTIVO;

        }



    }
}
