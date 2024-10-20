using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POOI_Semana04.Models;
using POOI_Semana04.dao;
using POOI_Semana04.dao.daoImpl;
using System.Diagnostics;
using System.Web.Configuration;


namespace POOI_Semana04.Controllers
{
    public class PaisController : Controller
    {
        // GET: Pais
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Reporte()
        {
            PaisDao dao = new PaisDaoImpl();
            List<Pais> lista = dao.consultarTodo("crud", new Pais());
            return View(lista);
        }

        public ActionResult DetalleRegistro(string codigo)
        {
            Debug.WriteLine("Codigo De Pais : " + codigo);
            PaisDao dao = new PaisDaoImpl();
            Pais pais = dao.obtenerPais(codigo);
            return View(pais);
        }

        [HttpGet]
        public ActionResult Editar(string codigo)
        {
            PaisDao dao = new PaisDaoImpl();
            Pais pais = dao.obtenerPais(codigo);
            return View(pais);
        }

        [HttpPost]
        public ActionResult Editar(Pais objPais)
        {

            PaisDao dao = new PaisDaoImpl();
            int procesar = dao.actualizar(objPais);
            return RedirectToAction("Reporte");
        }

        [HttpGet]
        public ActionResult Eliminar(string codigo)
        {
            PaisDao dao = new PaisDaoImpl();
            Pais pais = dao.obtenerPais(codigo);
            return View(pais);
        }

        [HttpPost, ActionName("Eliminar")]
        public ActionResult Eliminar_confirmacion(string codigo)
        {
            Debug.WriteLine("Codigo a eliminar : "+ codigo);
            PaisDao dao = new PaisDaoImpl();
            int procesar= dao.eliminar(codigo);
            return RedirectToAction("Reporte");
        }


        public ActionResult Create()
        {

            ViewBag.comboRegiones = new SelectList(
                    listadoRegiones(),"region_id","region_name"
                );
            return View(new Pais());
        }

        [HttpPost]
        public ActionResult Create(Pais p)
        {
            if (ModelState.IsValid)
            {
                PaisDao dao = new PaisDaoImpl();
                int procesar = dao.registrar(p);
                Debug.WriteLine("Procesar - rpta registrar : " + procesar);
                if (procesar >= 0)
                {
                    return RedirectToAction("Reporte");
                }
                else
                {
                    ViewBag.MensajeValidacion = "Ocurrio un error al registrar";
                    ViewBag.comboRegiones = new SelectList(
                    listadoRegiones(), "region_id", "region_name"
                    );
                    return View(p);
                }
            }
            return View(p);
        }


        public List<Region> listadoRegiones()
        {
            
            IRegionDao regionDao = new RegionDaoImpl();
            List<Region> lista = regionDao.listado();
            return lista;
        }



        public ActionResult Consulta(string txtNom= "", 
            string txtCod= "", int cboRegiones = 0)
        {

            PaisDao dao = new PaisDaoImpl();
            Pais objPais = new Pais();
            objPais.country_id= txtCod;
            objPais.country_name= txtNom;
            objPais.region_id = cboRegiones;

            List<Pais> lista = dao.consultarTodo("busqueda", objPais);

            ViewBag.comboRegiones = new SelectList(
                    listadoRegiones(), "region_id", "region_name");
      
            return View(lista);
        }


    }
}