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
    public class ConversionMonedaController : Controller
    {
        private readonly ILogger<ConversionMonedaController> _logger;
        private readonly ApplicationDbContext _context;

        public ConversionMonedaController(ILogger<ConversionMonedaController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var conversiones = from o in _context.DataHistorial select o;
            var viewModel = new ConversionViewModel
            {
                FormConversion = new HistorialConversiones(),
                ListConversion = conversiones.OrderBy(c => c.Id).ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Convertir(decimal monto, string moneda, string usuario)
        {
            decimal tasaConversion = moneda == "USD" ? 62059.40m : 0.000016m;
            decimal montoConvertido = monto * tasaConversion;

            var historial = new HistorialConversiones
            {
                Usuario = usuario,
                MontoEnviado = monto,
                MontoRecibido = montoConvertido,
                Moneda = moneda
            };

            _context.DataHistorial.Add(historial);
            _context.SaveChanges();

            TempData["MontoConvertido"] = montoConvertido.ToString();
            TempData["Moneda"] = moneda == "USD" ? "USD" : "BTC";

            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}