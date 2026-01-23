using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TiendaNueva.Data;
using TiendaNueva.Models;

namespace TiendaNueva.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbContextTiendaNueva _context;

        public HomeController(DbContextTiendaNueva context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dbContextTiendaNueva = _context.Productos.Take(8).Include(p => p.Categoria);
            var ItemsTienda = new List<CarritoItem>();
            var ModeloDeVistaNuestraTienda = new MiCompraViewModel();
            ModeloDeVistaNuestraTienda.Productos = await dbContextTiendaNueva.ToListAsync();
            return View(ModeloDeVistaNuestraTienda);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
