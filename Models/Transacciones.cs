using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenParcial.Models
{
    [Table("t_transacciones")]
    public class Transacciones
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        public Boolean Estado { get; set; }

    }
}