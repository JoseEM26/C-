using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_tarea8
{
    internal class asesor
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int horas { get; set; }
        public double tarifa { get; set; }

        public asesor(int codigo, string nombre, int horas, double tarifa)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horas = horas;
            this.tarifa = tarifa;
        }

        public double sueldoBruto() => horas * tarifa;
        public double Descuento() => sueldoBruto()*0.15;
        public double SueldoNeto() => sueldoBruto()-Descuento();
    }
}
