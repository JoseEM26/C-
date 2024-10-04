using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimulacroABRIL_xd.Models
{
    public class Alumno
    {
        public int CodigoAlumno { get; set; }
        public string nombreAlumno { get; set; }

        public Alumno(int codigoAlumno, string nombreAlumno)
        {
            this.CodigoAlumno = codigoAlumno;
            this.nombreAlumno = nombreAlumno;
        }
    }
}