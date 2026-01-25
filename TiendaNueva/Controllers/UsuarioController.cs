using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using TiendaNueva.Data;
using TiendaNueva.Models;

namespace TiendaNueva.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsuarioController : Controller
    {
        private readonly DbContextTiendaNueva _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager1;

        public UsuarioController(DbContextTiendaNueva context, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> usManager)
        {
            _context = context;
            _userManager = usManager;
            _roleManager1 = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var usuarios = await _userManager.Users.ToListAsync();
            var listaVM = new List<UsuarioViewModel>();

            foreach (var u in usuarios)
            {
                listaVM.Add(new UsuarioViewModel
                {
                    Id = u.Id,
                    Email = u.Email,
                    EsAdmin = await _userManager.IsInRoleAsync(u, "Admin")
                });
            }
            return View(listaVM);
        }

        public async Task<IActionResult> DarPermisoAdmin(string id)
        {
            var usuario = await _userManager.FindByIdAsync(id);
            if (usuario == null) return NotFound();

            if (!await _roleManager1.RoleExistsAsync("Admin"))
            {
                await _roleManager1.CreateAsync(new IdentityRole("Admin"));
            }

            var yaEsAdmin = await _userManager.IsInRoleAsync(usuario, "Admin");

            if (yaEsAdmin)
            {
                await _userManager.RemoveFromRoleAsync(usuario, "Admin");
            }
            else
            {
                await _userManager.AddToRoleAsync(usuario, "Admin");
            }



            return RedirectToAction("Index");
        }


    }
}
