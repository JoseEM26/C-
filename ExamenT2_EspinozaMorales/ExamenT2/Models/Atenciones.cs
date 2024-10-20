using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenT2.Models
{
    public class Atenciones
    {
        public int TicketID { get; set; }
        public DateTime FechaProgramada { get; set; }
        public int ProveedorID { get; set; }
        public int ItemID { get; set; }
        public string TipoTicket { get; set; }
        public int EstadoID { get; set; }
        public decimal CostoAtencion { get; set; }
    }
}