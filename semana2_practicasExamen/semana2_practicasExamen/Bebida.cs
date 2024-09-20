using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana2_practicasExamen
{
    internal class Bebida
    {
        public int id { get; set; }
        public int marca { get; set; }

        public Bebida(int id, int marca)
        {
            this.id = id;
            this.marca = marca;
        }

        public string presentacionBebida()
        {
            return $"hola soy {marca}";
        }
    }
}
