using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenT2.Models
{
    public class Ticket
    {
        public string TicketID { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaCierre { get; set; }
        public int ItemID { get; set; }
        public int AgenciaID { get; set; }
        public string Resumen { get; set; }
    }
}