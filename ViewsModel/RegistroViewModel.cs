using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenParcial.Models;

namespace ExamenParcial.ViewModel
{
    public class RegistroViewModel
    {
        public Transacciones? FormRegistro { get; set; }
        public IEnumerable<Transacciones>? ListRegistro { get; set; }

    }

    public class FormRegistro
    {
        public long Id { get; set; }
        public string? Remitente { get; set; }
        public string? Destinatario { get; set; }
        public string? PaisOrigen { get; set; }
        public string? PaisDestino { get; set; }
        public decimal MontoEnviado { get; set; }
        public string? MonedaEnviado { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal MontoRecibido { get; set; }
        public string? MonedaRecibido { get; set; }
        public string? Estado { get; set; }
    }
}