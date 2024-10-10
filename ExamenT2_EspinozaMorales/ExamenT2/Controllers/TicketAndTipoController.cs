using ExamenT2.DAO.DaoImpl;
using ExamenT2.DAO.List;
using ExamenT2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenT2.Controllers
{
    public class TicketAndTipoController : Controller
    {
        // GET: TicketAndTipo
        DaoTicketImpl ticket = new DaoTicketImpl();
        AgenciaList agencia = new AgenciaList();
        ItemList item = new ItemList();
        DaoTipoImpl tipo = new DaoTipoImpl();
        CategoriaList categoria = new CategoriaList();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MostrarTodoTipo()
        {

            return View(tipo.SeleccionarTodo());
        }

        public ActionResult DetailsTipo(int id)
        {

            return View(tipo.SeleccionarXID(id));
        }

        public ActionResult CreateTipo()
        {
            ViewBag.Categoria = new SelectList(categoria.SeleccionarTodo(), "CategoriaID", "Nombre");
           return View(new Tipo());
        }
        [HttpPost]
        public ActionResult CreateTipo(Tipo t)
        {


            tipo.Create(t);
            return RedirectToAction("MostrarTodoTipo");
        }

        public ActionResult EditTipo(int id)
        {
            ViewBag.Categoria = new SelectList(categoria.SeleccionarTodo(), "CategoriaID", "Nombre");

            var x = tipo.SeleccionarXID(id);
            return View(x);
        }

        [HttpPost]
        public ActionResult EditTipo(Tipo t)
        {
            tipo.Update(t);
            return RedirectToAction("MostrarTodoTipo");
        }
        public ActionResult DeleteTipo(int id)
        {
            return View(tipo.SeleccionarXID(id));
        }
        [HttpPost, ActionName("DeleteTipo")]
        public ActionResult DeleteTipoConfirmed(int id)
        {
            tipo.Delete(id);
            return RedirectToAction("MostrarTodoTipo");
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
        public ActionResult MostrarTodoTicket()
        {
            
            return View(ticket.SeleccionarTodo());
        }

        public ActionResult Details(int id)
        {

            return View(ticket.SeleccionarXID(id));
        }

        public ActionResult Create()
        {
            ViewBag.Item = new SelectList(item.SeleccionarTodo(), "ItemID", "ItemID");
            ViewBag.Agencia = new SelectList(agencia.SeleccionarTodo(), "AgenciaID", "Nombre");
            return View(new Ticket());
        }
        [HttpPost]
        public ActionResult Create(Ticket t)
        {
     

            ticket.Create(t);
            return RedirectToAction("MostrarTodoTicket");
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Item = new SelectList(item.SeleccionarTodo(), "ItemID", "ItemID");
            ViewBag.Agencia = new SelectList(agencia.SeleccionarTodo(), "AgenciaID", "Nombre");
            var x = ticket.SeleccionarXID(id);
            return View(x);
        }

        [HttpPost]
        public ActionResult Edit(Ticket t)
        {
            ticket.Update(t);
            return RedirectToAction("MostrarTodoTicket");
        }
        public ActionResult Delete(int id)
        {
            return View(ticket.SeleccionarXID(id));
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ticket.Delete(id);
            return RedirectToAction("MostrarTodoTicket");
        }


    }
}