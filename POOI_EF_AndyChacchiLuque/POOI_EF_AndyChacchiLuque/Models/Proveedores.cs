using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POOI_EF_AndyChacchiLuque.Models
{
    public class Proveedores
    {
        public int IdProveedor { get; set; }
        public string NomContacto { get; set; }
        public string DirProveedor { get; set; }
        public string CargoContacto { get; set; }
        public string idpais { get; set; }
        public string fonoProveedor { get; set; }
        public string FaxProveedor { get; set; }
        public int TotalUnidades { get; set; }
    }
}