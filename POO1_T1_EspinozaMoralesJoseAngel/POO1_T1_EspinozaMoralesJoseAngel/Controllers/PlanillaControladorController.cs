using POO1_T1_EspinozaMoralesJoseAngel.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace POO1_T1_EspinozaMoralesJoseAngel.Controllers
{
    public class PlanillaControladorController : Controller
    {
        public static List<Asistente> list_as = new List<Asistente>();
        public static int contador = 0;
        // GET: PlanillaControlador
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateTrabajador()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTrabajador(Trabajador t)
        {
            ViewBag.dni = t.dniTrab;
            ViewBag.nombre = t.nomTrab;
            ViewBag.apellido = t.apeTrab;
            ViewBag.cate = t.categoriaTrab;
            ViewBag.contrato = t.fecContrato;
            ViewBag.basico = t.Basico();
            ViewBag.bono = t.Bonificacion();
            ViewBag.monto = t.Monto();


            Debug.WriteLine("dni:    " + t.dniTrab);
            Debug.WriteLine("nombre:   " + t.nomTrab);
            Debug.WriteLine("Apellido:   " + t.apeTrab);
            Debug.WriteLine("fecha COntrato:  " + t.fecContrato);
            Debug.WriteLine("Categoria:   " + t.categoriaTrab);
            Debug.WriteLine("basico:   " + t.Basico());
            Debug.WriteLine("bono:   " + t.Bonificacion());
            Debug.WriteLine("monto:   " + t.Monto());
            return View();
        }

        [HttpGet]
        public ActionResult CreateAsistente()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAsistente(Asistente a)
        {
            ViewBag.dni = a.dniTrab;
            ViewBag.nombre = a.nomTrab;
            ViewBag.apellido = a.apeTrab;
            ViewBag.cate = a.categoriaTrab;
            ViewBag.contrato = a.fecContrato;
            ViewBag.hijos = a.numeroHijos;
            ViewBag.grado = a.gradoEducacion;
    
            ViewBag.basico = a.BasicoGrado();
            ViewBag.esco = a.Escolarizado();
            ViewBag.bonifi = a.BonificacionEspecial();
            ViewBag.sumatoria = a.MontoSumarotia();


            Debug.WriteLine("dni:    " + a.dniTrab);
            Debug.WriteLine("nombre:   " + a.nomTrab);
            Debug.WriteLine("Apellido:   " + a.apeTrab);
            Debug.WriteLine("fecha COntrato:  " + a.fecContrato);
            Debug.WriteLine("Categoria:   " + a.categoriaTrab);
            Debug.WriteLine("NumeroHijos:   " + a.numeroHijos);
            Debug.WriteLine("grado escolar:   " + a.gradoEducacion);
            Debug.WriteLine("Basico:   " + a.BasicoGrado());
            Debug.WriteLine("Escolarizado:   " + a.Escolarizado());
            Debug.WriteLine("Bonificaicion:   " + a.BonificacionEspecial());
            Debug.WriteLine("Monto:   " + a.MontoSumarotia());
          
 

            return View();
        }

        public ActionResult Listado()
        {
            return View(list_as);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Asistente a)
        {
            foreach(var x in list_as)
            {
                if (a.dniTrab == x.dniTrab)
                {
                    ViewBag.mensaje = "El DNI escrito ya existe(PORFAVOR INGRESA UNO DIFERENTE)";
                    return View(a);
                }

            }
          
            list_as.Add(a);
            contador++;
            ViewBag.mensaje = ": Registro Creado Correctamente";
            ViewBag.contador = contador;
            return View(new Asistente());
            //return RedirectToAction("Listado");
        }


    }
}