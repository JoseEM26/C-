using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO1_T1_EspinozaMoralesJoseAngel.Models
{
    public class Asistente : Trabajador
    {
        public int numeroHijos { get; set; }
        public string gradoEducacion { get; set; }

        override public double BasicoGrado()
        {
            if (gradoEducacion.ToLower() == "secundaria") return 950;
            else if (gradoEducacion.ToLower() == "superior") return 1500;
            else return 0000;
        }

        override public double Escolarizado()
        {
            return numeroHijos * 95;
        }

        override public double BonificacionEspecial()
        {
            int fechaTrabajada = fecContrato.Year - DateTime.Now.Year;

            if (fechaTrabajada <= 1) return BasicoGrado() * 0.05;
            else return BasicoGrado() * 0.10;
        }
        override public double MontoSumarotia()
        {
            return BasicoGrado() + Escolarizado() + BonificacionEspecial();
        }
    }
}