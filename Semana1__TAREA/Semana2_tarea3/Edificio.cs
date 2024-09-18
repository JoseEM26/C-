using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_tarea3
{
    internal class Edificio
    {
        public int codigo { get; set; }
        public int departamento { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }

        public Edificio(int codigo, int departamento, int cantidad, double precio)
        {
            this.codigo = codigo;
            this.departamento = departamento;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public double precioDolarEdificio()
        {
            return cantidad * precio;
        }

    }
}
