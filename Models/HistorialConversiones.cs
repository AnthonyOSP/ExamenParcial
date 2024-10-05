using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenParcial.Models
{
    [Table("t_historial_conversiones")]
    public class HistorialConversiones
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string? Usuario { get; set; }
        public decimal MontoEnviado { get; set; }
        public decimal MontoRecibido { get; set; }
        public string? Moneda { get; set; }

    }
}