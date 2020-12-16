using Busco.Data;
using Busco.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Busco.Controllers
{
    public class ProductoController: Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ProductoController> _logger;

        public ProductoController(ILogger<ProductoController> logger,
        ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Authorize]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                _context.SaveChanges();
                return RedirectToAction("index", "home");
            }

            return View(producto);
        }
    }   
}