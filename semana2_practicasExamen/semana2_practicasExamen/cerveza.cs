using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana2_practicasExamen
{
    internal class cerveza : Bebida
    {
        public string nombre { get; set; }
        public cerveza(int id, int marca, string nombre) : base(id, marca)
        {
            this.id = id;
            this.marca = marca;
            this.nombre = nombre;
        }
    }
}
