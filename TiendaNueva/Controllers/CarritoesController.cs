using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TiendaNueva.Data;
using TiendaNueva.Models;

namespace TiendaNueva.Controllers
{
    public class CarritoesController : Controller
    {
        private readonly DbContextTiendaNueva _context;

        public CarritoesController(DbContextTiendaNueva context)
        {
            _context = context;
        }

        // GET: Carritoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Carrito.ToListAsync());
        }

        // GET: Carritoes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrito = await _context.Carrito
                .FirstOrDefaultAsync(m => m.CarritoID == id);
            if (carrito == null)
            {
                return NotFound();
            }

            return View(carrito);
        }

        // GET: Carritoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carritoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CarritoID,UsuarioID,PrecioFinal,EstadoCarrito")] Carrito carrito)
        {
            if (ModelState.IsValid)
            {
                carrito.CarritoID = Guid.NewGuid();
                _context.Add(carrito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carrito);
        }

        // GET: Carritoes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrito = await _context.Carrito.FindAsync(id);
            if (carrito == null)
            {
                return NotFound();
            }
            return View(carrito);
        }

        [HttpPost]
        public async Task<IActionResult> MiCarrito(MiCompraViewModel MiCompra)
        {
            if (MiCompra == null)
            {
                return BadRequest();
            }
            var itemsReales = MiCompra.ItemsElegidos.Where((item => item.ProductoID != Guid.Empty)).ToList();
            var ids = itemsReales.Select(i => i.ProductoID).ToList();
            var productosDB = await _context.Productos.Where(p => ids.Contains(p.ProductoID)).ToListAsync();
            Carrito carrito = new Carrito() { CarritoID = Guid.NewGuid() };
            List<CarritoItem> productos = new List<CarritoItem>();
            foreach (var prod in productosDB)
            {
                var item = new CarritoItem() { CarritoID = Guid.NewGuid() };
                item.Item = prod;
                foreach (var it in itemsReales)
                {
                    if (it.ProductoID == prod.ProductoID)
                    {
                        item.Cantidad = it.Cantidad;
                    }
                }
                item.CalcularPrecio();
                productos.Add(item);
            }


            carrito.Productos = productos;


            carrito.CalcularPrecioFinal();
            carrito.EstadoCarrito = Estado.ACTIVO;


            return View(carrito);
        }

        // POST: Carritoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CarritoID,UsuarioID,PrecioFinal,EstadoCarrito")] Carrito carrito)
        {
            if (id != carrito.CarritoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carrito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarritoExists(carrito.CarritoID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(carrito);
        }

        // GET: Carritoes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrito = await _context.Carrito
                .FirstOrDefaultAsync(m => m.CarritoID == id);
            if (carrito == null)
            {
                return NotFound();
            }

            return View(carrito);
        }

        // POST: Carritoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var carrito = await _context.Carrito.FindAsync(id);
            if (carrito != null)
            {
                _context.Carrito.Remove(carrito);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarritoExists(Guid id)
        {
            return _context.Carrito.Any(e => e.CarritoID == id);
        }
    }
}
