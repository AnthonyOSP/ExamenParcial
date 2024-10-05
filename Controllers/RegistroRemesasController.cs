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
    public class RegistroRemesasController : Controller
    {
        private readonly ILogger<RegistroRemesasController> _logger;
        private readonly ApplicationDbContext _context;

        public RegistroRemesasController(ILogger<RegistroRemesasController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarTransaccion(RegistroViewModel viewModel)
        {

            var transaccion = new Transacciones
            {
                Remitente = viewModel.FormRegistro.Remitente,
                Destinatario = viewModel.FormRegistro.Destinatario,
                PaisOrigen = viewModel.FormRegistro.PaisOrigen,
                PaisDestino = viewModel.FormRegistro.PaisDestino,
                MontoEnviado = viewModel.FormRegistro.MontoEnviado,
                MonedaEnviado = viewModel.FormRegistro.MonedaEnviado,
                TipoCambio = viewModel.FormRegistro.TipoCambio,
                MontoRecibido = viewModel.FormRegistro.MontoRecibido,
                MonedaRecibido = viewModel.FormRegistro.MonedaRecibido,
                Estado = viewModel.FormRegistro.Estado
            };

            _context.Add(transaccion);
            _context.SaveChanges();

            TempData["Message"] = "Transacción registrada con éxito!";

            return RedirectToAction(nameof(Index));

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}