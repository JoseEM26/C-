using ExamenT2.DAO;
using ExamenT2.DAO.DaoImpl;
using ExamenT2.DAO.List;
using ExamenT2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenT2.Controllers
{
    public class AtencionesController : Controller
    {
        // GET: Atenciones
        DaoAtencionesImpl atencion = new DaoAtencionesImpl();
        TicketList ticket = new TicketList();
        ProveedorList prooveedor = new ProveedorList();
        ItemList item = new ItemList();
        EstadoList estado = new EstadoList();
        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostrarTodo()
        {

            return View(atencion.SeleccionarTodo());
        }

        public ActionResult Details(int id)
        {

            return View(atencion.SeleccionarXID(id));
        }

        public ActionResult Create()
        {
            ViewBag.ticket = new SelectList(ticket.SeleccionarTodo(), "TicketID", "Resumen");
            ViewBag.proovedorcito = new SelectList(prooveedor.SeleccionarTodo(), "idProveedor", "nombreProveedor");
            ViewBag.Item = new SelectList(item.SeleccionarTodo(), "ItemID", "Descripcion");
            ViewBag.estadocito= new SelectList(estado.SeleccionarTodo(), "idEstado", "idEstado");
            return View(new Atenciones());
        }
        [HttpPost]
        public ActionResult Create(Atenciones t)
        {
            ViewBag.ticket = new SelectList(ticket.SeleccionarTodo(), "TicketID", "Resumen");
            ViewBag.proovedorcito = new SelectList(prooveedor.SeleccionarTodo(), "idProveedor", "nombreProveedor");
            ViewBag.Item = new SelectList(item.SeleccionarTodo(), "ItemID", "Descripcion");
            ViewBag.estadocito = new SelectList(estado.SeleccionarTodo(), "idEstado", "idEstado");

            atencion.Create(t);
            return RedirectToAction("MostrarTodo");
        }
        public ActionResult EditTipo(int id)
        {
            //ViewBag.Categoria = new SelectList(atencion.SeleccionarTodo(), "CategoriaID", "Nombre");
            ViewBag.ticket = new SelectList(ticket.SeleccionarTodo(), "TicketID", "Resumen");
            ViewBag.proovedorcito = new SelectList(prooveedor.SeleccionarTodo(), "idProveedor", "nombreProveedor");
            ViewBag.Item = new SelectList(item.SeleccionarTodo(), "ItemID", "Descripcion");
            ViewBag.estadocito = new SelectList(estado.SeleccionarTodo(), "idEstado", "idEstado");

            var x = atencion.SeleccionarXID(id);
            return View(x);
        }

        [HttpPost]
        public ActionResult EditTipo(Atenciones t)
        {
            ViewBag.ticket = new SelectList(ticket.SeleccionarTodo(), "TicketID", "Resumen");
            ViewBag.proovedorcito = new SelectList(prooveedor.SeleccionarTodo(), "idProveedor", "nombreProveedor");
            ViewBag.Item = new SelectList(item.SeleccionarTodo(), "ItemID", "Descripcion");
            ViewBag.estadocito = new SelectList(estado.SeleccionarTodo(), "idEstado", "idEstado");

            atencion.Update(t);
            return RedirectToAction("MostrarTodo");
        }
        public ActionResult Delete(int id)
        {
            return View(atencion.SeleccionarXID(id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            atencion.Delete(id);
            return RedirectToAction("MostrarTodo");
        }
    }
}