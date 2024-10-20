using ExamenT2.DAO.Busqueda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenT2.Controllers
{
    public class AgenciaController : Controller
    {
        // GET: Agencia
        AgenciaBusqueda agencia = new AgenciaBusqueda();
        public ActionResult Index(int id=0,string nombre="",string distrito="")
        {
            var lista = agencia.Busqueda(id,nombre,distrito);
            return View(lista);
        }
    }
}