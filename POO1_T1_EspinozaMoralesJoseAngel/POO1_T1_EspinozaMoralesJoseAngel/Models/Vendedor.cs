using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO1_T1_EspinozaMoralesJoseAngel.Models
{
    public class Vendedor:Trabajador
    {
        public string dniTrab { get; set; }
        public string apeTrab { get; set; }
        public string nomTrab { get; set; }
        public DateTime fecContrato { get; set; }
        public string categoriaTrab { get; set; }
    }
}