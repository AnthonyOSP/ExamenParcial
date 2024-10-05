using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenParcial.Models;

namespace ExamenParcial.ViewModel
{
    public class ConversionViewModel
    {
        public HistorialConversiones? FormConversion { get; set; }
        public IEnumerable<HistorialConversiones>? ListConversion { get; set; }
    }

    public class FormConversion
    {
        public string? Usuario { get; set; }
        public decimal MontoEnviado { get; set; }
        public decimal MontoRecibido { get; set; }
        public string? Moneda { get; set; }
    }
}