using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenT2.Models
{
    public class AgenciaCompleta
    {
        public int AgenciaID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Area { get; set; }
        public string Distrito { get; set; }
        public string Provincia { get; set; }
        public string Departamento { get; set; }
    }
}