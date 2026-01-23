using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TiendaNueva.Data;

namespace TiendaNueva.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly DbContextTiendaNueva _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager1;

        public UsuarioController( DbContextTiendaNueva context, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> usManager)
        {
            _context = context;
            _userManager = usManager;
            _roleManager1 = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var usuarios = await _context.Users.ToListAsync();

            return View(usuarios);
        }

    }
}
