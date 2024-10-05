using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ExamenParcial.Models;
using ExamenParcial.ViewModel;
using ExamenParcial.Data;

namespace ExamenParcial.Controllers
{
    public class TransaccionesController : Controller
    {
        private readonly ILogger<TransaccionesController> _logger;
        private readonly ApplicationDbContext _context;

        public TransaccionesController(ILogger<TransaccionesController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var mistransacciones = from o in _context.DataTransacciones select o;
            var viewModel = new RegistroViewModel
            {
                FormRegistro = new Transacciones(),
                ListRegistro = [.. mistransacciones.OrderBy(c => c.Id)]
            };
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}