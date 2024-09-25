using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO1_T1_EspinozaMoralesJoseAngel.Models
{
    public class Trabajador
    {
        public string dniTrab { get; set; }
        public string apeTrab { get; set; }
        public string nomTrab { get; set; }
        public DateTime fecContrato { get; set; }
        public string categoriaTrab { get; set; }


        public int Basico()
        {
            int anoContrato = fecContrato.Year - DateTime.Now.Year;

            if (anoContrato <= 3) return 1000;
            else if (anoContrato >= 3 && anoContrato <= 5) return 1500;
            else if (anoContrato >= 3 && anoContrato <= 5) return 2500;
            else return 3500;
        }


        public double Bonificacion()
        {
            if (categoriaTrab == "A") return Basico() * 0.10;
            else return Basico() * 0.15;
        }

        public double Monto()
        {
            return Basico() + Bonificacion();
        }
        /// <summary>
        /// ////////////////////////////////
        /// </summary>
        /// <returns></returns>
        virtual public double BasicoGrado()
        {
            return 0.0;
        }

        virtual public double Escolarizado()
        {
            return 0.0;
        }

        virtual public double BonificacionEspecial()
        {
            return 0.0;
        }

        virtual public double MontoSumarotia()
        {
            return 0.0;
        }








    }
}