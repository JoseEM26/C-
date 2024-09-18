using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1__TAREA
{
    internal class celular
    {
        public int numero { get; set; }
        public string usuario { get; set; }
        public int s_consumidos { get; set; }
        public double p_unidad { get; set; }

        public celular(int numero, string usuario, int s_consumidos, double p_unidad)
        {
            this.numero = numero;
            this.usuario = usuario;
            this.s_consumidos = s_consumidos;
            this.p_unidad = p_unidad;
        }

        public double CostoConsumo()
        {
            return s_consumidos * p_unidad;
        }
        public double impuesto()
        {
            return CostoConsumo() * 0.18;
        }
        public double impuestoTotal()
        {
            return CostoConsumo() - impuesto();
        }
    }
}
