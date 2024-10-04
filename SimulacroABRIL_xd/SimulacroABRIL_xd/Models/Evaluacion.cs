using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimulacroABRIL_xd.Models
{
    public class Evaluacion:Alumno
    {
        

        public int idEvaluacion { get; set; }
        public string NombreCurso { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int NotaParcial { get; set; }
        public int NotaFinal { get; set; }

        public Evaluacion(int idEvaluacion, string nombreCurso, 
            int nota1, int nota2, int notaParcial, int notaFinal,int CodigoAlumno,string nombreAlumno) :base(CodigoAlumno, nombreAlumno)
        {
            this.idEvaluacion = idEvaluacion;
            this.NombreCurso = nombreCurso;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.NotaParcial = notaParcial;
            this.NotaFinal = notaFinal;
        }

        public double PromedioFinal()
        {
            return Nota1 * 0.15 + Nota2 * 0.15
                   + NotaParcial * 0.25 + NotaFinal * 0.45;
        }

        public string Resultado()
        {
            if (PromedioFinal() < 13) return "REPROBADO";
            else if (PromedioFinal() >= 12 && PromedioFinal() < 16) return "APROBADO";
            else return "SOBRESALIENTE";
        }



    }
}