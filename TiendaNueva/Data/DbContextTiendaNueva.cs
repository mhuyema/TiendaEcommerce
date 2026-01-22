using Microsoft.EntityFrameworkCore;
using TiendaNueva.Models;

namespace TiendaNueva.Data
{
    public class DbContextTiendaNueva : DbContext
    {
        public DbContextTiendaNueva(DbContextOptions<DbContextTiendaNueva> options) : base(options) { }

        public DbSet<Carrito> Carrito{ get; set; }

        public DbSet<CarritoItem> CarritoItems{ get; set; }


        public DbSet<Categoria> Categorias{ get; set; }


        public DbSet<Venta>Ventas{ get; set; }


        public DbSet<Producto> Productos{ get; set; }




    }
}
