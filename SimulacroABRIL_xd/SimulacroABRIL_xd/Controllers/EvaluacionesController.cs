using SimulacroABRIL_xd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimulacroABRIL_xd.Controllers
{
    public class EvaluacionesController : Controller
    {
        public static List<Evaluacion> lista = new List<Evaluacion> {
            new Evaluacion(111, "POO", 15, 20, 15, 19, 222, "Abril"),
            new Evaluacion(112, "JAVA", 12, 20, 19, 20, 223, "JOSE"),
            new Evaluacion(113, "REACT", 10, 20, 15, 09, 224, "PEpito")
            };

        // GET: Evaluaciones
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Listado()
        {
            ViewBag.contador = lista.Count;
            return View(lista);
        }


        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(Evaluacion e)
        {
            var mensajes = new List<string>();

            // Validar el idEvaluacion
            foreach (var x in lista)
            {
                if (e.idEvaluacion < x.idEvaluacion)
                {
                    mensajes.Add($"No puedes enviar un id menor a {x.idEvaluacion}");
                }
            }

            // Validar campos
            if (string.IsNullOrWhiteSpace(e.NombreCurso))
            {
                mensajes.Add("No puedes dejar vacío el campo Nombre del Curso.");
            }

            if (e.CodigoAlumno <= 0) // Asumiendo que Código Alumno es un entero
            {
                mensajes.Add("No puedes dejar vacío el Código Alumno.");
            }

            if (string.IsNullOrWhiteSpace(e.nombreAlumno))
            {
                mensajes.Add("No puedes dejar vacío el Nombre del Alumno.");
            }

            // Validar notas
            if (e.Nota1 < 0 || e.Nota1 > 20)
            {
                mensajes.Add("La Nota 1 debe estar entre 0 y 20.");
            }
            if (e.Nota2 < 0 || e.Nota2 > 20)
            {
                mensajes.Add("La Nota 2 debe estar entre 0 y 20.");
            }
            if (e.NotaParcial < 0 || e.NotaParcial > 20)
            {
                mensajes.Add("La Nota Parcial debe estar entre 0 y 20.");
            }
            if (e.NotaFinal < 0 || e.NotaFinal > 20)
            {
                mensajes.Add("La Nota Final debe estar entre 0 y 20.");
            }

            // Si hay mensajes de error, devolver la vista con los mensajes
            if (mensajes.Any())
            {
                ViewBag.mensaje = string.Join("<br/>", mensajes);
                return View(e);
            }

            // Agregar la evaluación a la lista
            lista.Add(e);

            return RedirectToAction("Listado");
        }


    }
}