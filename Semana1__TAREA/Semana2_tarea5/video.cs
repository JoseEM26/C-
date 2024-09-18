using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_tarea5
{
    internal class video
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public double duracion { get; set; }
        public double precio { get; set; }
        public double tipo { get; set; }

        public video(int codigo, string nombre, double duracion, double precio, double tipo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.duracion = duracion;
            this.precio = precio;
            this.tipo = tipo;
        }

        public double precioDolar()
        {
            return precio * 3.24;
        }
    }
}
