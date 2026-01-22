using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TiendaNueva.Data;
using TiendaNueva.Models;

namespace TiendaNueva.Controllers
{
    public class CarritoItemController : Controller
    {
        private readonly DbContextTiendaNueva _context;

        public CarritoItemController(DbContextTiendaNueva context)
        {
            _context = context;
        }

        // GET: CarritoItem
        public async Task<IActionResult> Index()
        {
            var dbContextTiendaNueva = _context.CarritoItems.Include(c => c.Carrito).Include(c => c.Item);
            return View(await dbContextTiendaNueva.ToListAsync());
        }

        // GET: CarritoItem/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carritoItem = await _context.CarritoItems
                .Include(c => c.Carrito)
                .Include(c => c.Item)
                .FirstOrDefaultAsync(m => m.CarritoItemID == id);
            if (carritoItem == null)
            {
                return NotFound();
            }

            return View(carritoItem);
        }

        // GET: CarritoItem/Create
        public IActionResult Create()
        {
            ViewData["CarritoID"] = new SelectList(_context.Carrito, "CarritoID", "CarritoID");
            ViewData["ProductoID"] = new SelectList(_context.Productos, "ProductoID", "Descripcion");
            return View();
        }

        // POST: CarritoItem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CarritoItemID,Cantidad,PrecioFinalPorProducto,ProductoID,CarritoID")] CarritoItem carritoItem)
        {
            if (ModelState.IsValid)
            {
                carritoItem.CarritoItemID = Guid.NewGuid();
                _context.Add(carritoItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CarritoID"] = new SelectList(_context.Carrito, "CarritoID", "CarritoID", carritoItem.CarritoID);
            ViewData["ProductoID"] = new SelectList(_context.Productos, "ProductoID", "Descripcion", carritoItem.ProductoID);
            return View(carritoItem);
        }

        // GET: CarritoItem/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carritoItem = await _context.CarritoItems.FindAsync(id);
            if (carritoItem == null)
            {
                return NotFound();
            }
            ViewData["CarritoID"] = new SelectList(_context.Carrito, "CarritoID", "CarritoID", carritoItem.CarritoID);
            ViewData["ProductoID"] = new SelectList(_context.Productos, "ProductoID", "Descripcion", carritoItem.ProductoID);
            return View(carritoItem);
        }

        // POST: CarritoItem/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CarritoItemID,Cantidad,PrecioFinalPorProducto,ProductoID,CarritoID")] CarritoItem carritoItem)
        {
            if (id != carritoItem.CarritoItemID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carritoItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarritoItemExists(carritoItem.CarritoItemID))
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
            ViewData["CarritoID"] = new SelectList(_context.Carrito, "CarritoID", "CarritoID", carritoItem.CarritoID);
            ViewData["ProductoID"] = new SelectList(_context.Productos, "ProductoID", "Descripcion", carritoItem.ProductoID);
            return View(carritoItem);
        }

        // GET: CarritoItem/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carritoItem = await _context.CarritoItems
                .Include(c => c.Carrito)
                .Include(c => c.Item)
                .FirstOrDefaultAsync(m => m.CarritoItemID == id);
            if (carritoItem == null)
            {
                return NotFound();
            }

            return View(carritoItem);
        }

        // POST: CarritoItem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var carritoItem = await _context.CarritoItems.FindAsync(id);
            if (carritoItem != null)
            {
                _context.CarritoItems.Remove(carritoItem);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarritoItemExists(Guid id)
        {
            return _context.CarritoItems.Any(e => e.CarritoItemID == id);
        }
    }
}
