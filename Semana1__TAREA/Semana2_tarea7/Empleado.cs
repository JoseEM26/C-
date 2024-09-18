using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_tarea7
{
    internal class Empleado
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int celular { get; set; }
        public double sueldo { get; set; }

        public Empleado(int codigo, string nombre, int celular, double sueldo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.celular = celular;
            this.sueldo = sueldo;
        }

        public string medidorSueldo()
        {
            if (sueldo > 3500) return "Mayor a 3500";
            else if (sueldo < 3500) return "Mayor a 3500";
            else return "igual a 3500";
        }
    }
}
