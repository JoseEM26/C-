using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_tarea2
{
    internal class Computadora
    {
        public int codigo { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
        public double precioDolares { get; set; }

        public Computadora(int codigo, string marca, string color, double precioDolares)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.precioDolares = precioDolares;
        }

        public double PrecioSoles()
        {
            return precioDolares * 3.35;
        }

        public double precioEurps()
        {
            return precioDolares * 1.20;
        }
    }
}
