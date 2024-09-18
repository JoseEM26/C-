using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_tarea9
{
    internal class pelota
    {
        public string marca { get; set; }
        public double peso { get; set; }
        public double presion { get; set; }
        public double diametro { get; set; }
        public double precio { get; set; }

        public pelota(string marca, double peso, double presion, double diametro, double precio)
        {
            this.marca = marca;
            this.peso = peso;
            this.presion = presion;
            this.diametro = diametro;
            this.precio = precio;
        }

        public double radio() => diametro / 2;
        public double volumen() => 4*3.1416*radio()*radio()*radio()/3;
        public double descuento() => precio*0.10;
        public double importe() => precio-descuento();
    }
}
