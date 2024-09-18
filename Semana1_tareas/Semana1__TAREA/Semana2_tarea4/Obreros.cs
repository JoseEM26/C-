using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_tarea4
{
    internal class Obreros
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int horas { get; set; }
        public double tarifas { get; set; }

        public Obreros(int codigo, string nombre, int horas, double tarifas)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horas = horas;
            this.tarifas = tarifas;
        }

        public double sueldoBruto()=>   horas * tarifas;
        public double DescuentoAFP() => sueldoBruto()*0.10;
        public double DescuentoEPS() => sueldoBruto()*0.05;
        public double sueldoNeto() => sueldoBruto()-(DescuentoAFP()+DescuentoEPS());
        
        
    }
}
