using System;
using System.Collections.Generic;
using System.Linq;
using Busco.Data;
using Busco.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Busco.Controllers
{
    public class ProductoController : Controller
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
                producto.FechaRegistro = DateTime.Now;
                producto.Usuario = User.Identity.Name;
                _context.Add(producto);
                _context.SaveChanges();
                return RedirectToAction("index", "home");
            }

            return View(producto);
        }

        public List<Producto> LastSeven()
        {
            var lista = _context.Productos.Where(x=>x.FechaRegistro > DateTime.Now.AddDays(-7)).ToList();  
            return lista;
        }
    }
}