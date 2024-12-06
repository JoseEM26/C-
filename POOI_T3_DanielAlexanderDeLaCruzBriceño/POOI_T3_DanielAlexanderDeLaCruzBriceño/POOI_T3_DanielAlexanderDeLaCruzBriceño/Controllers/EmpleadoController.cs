using Microsoft.Ajax.Utilities;
using POOI_T3_DanielAlexanderDeLaCruzBriceño.Metodos;
using POOI_T3_DanielAlexanderDeLaCruzBriceño.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POOI_T3_DanielAlexanderDeLaCruzBriceño.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        FiltrosEmpleado empleado = new FiltrosEmpleado();
        public ActionResult Index(string filtro = "")
        {
            List<Empleados> lista = empleado.MostrarTodo(filtro);
            return View(lista);
        }

        public ActionResult Details(int id)
        {
            Empleados e = empleado.MostrarEmpleado(id);
            return View(e);
        }

        public ActionResult Create()
        {
            return View(new Empleados());
        }
        [HttpPost]
        public ActionResult Create(Empleados e)
        {
            if (empleado.MostrarTodo(string.Empty).Any(x => x.DNI == e.DNI))
            {
                ViewBag.mensaje = "El DNI ya existe";
                return View(e);
            }
            else if (empleado.MostrarTodo(string.Empty).Any(x => x.Email == e.Email))
            {
                ViewBag.mensaje = "El Email ya existe";
                return View(e);
            }
            else
            {
                ViewBag.mensaje = "Empleado registrado correctamente";
            }
            empleado.InsertarEmpleado(e);
            return View(e);
        }

        public ActionResult Delete(int id)
        {
            Empleados emp = empleado.MostrarEmpleado(id);
            return View(emp);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            empleado.EliminarEmpleado(id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Empleados emp = empleado.MostrarEmpleado(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Empleados e)
        {
            if (empleado.MostrarTodo(string.Empty).Any(x => x.DNI == e.DNI))
            {
                ViewBag.mensajeEdit = "El DNI ya existe";
                return View(e);
            }
            else if (empleado.MostrarTodo(string.Empty).Any(x => x.Email == e.Email))
            {
                ViewBag.mensajeEdit = "El Email ya existe";
                return View(e);
            }
            else
            {
                ViewBag.mensajeEdit = "Empleado Actualizo correctamente";
            }
            empleado.ActualizarEmpleado(e);
            return View(e);
        }

    }
}