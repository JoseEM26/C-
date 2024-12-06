using POOI_EF_AndyChacchiLuque.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POOI_EF_AndyChacchiLuque.Controllers
{
    public class ContribuyenteController : Controller
    {
        // GET: Contribuyente
        public List<Contribuyente> MostrarTodo()
        {
            List<Contribuyente> lista = new List<Contribuyente>();

            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();

                cmd = new SqlCommand("usp_Crud_Contribuyente", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@indicador", "MostrarTodo");
                cmd.Parameters.AddWithValue("@dniCont", "");
                cmd.Parameters.AddWithValue("@nomCont", "");
                cmd.Parameters.AddWithValue("@direcCont", "");
                cmd.Parameters.AddWithValue("@emailCont", "");
                cmd.Parameters.AddWithValue("@idpais", "");
                cmd.Parameters.AddWithValue("@fonoCont", "");

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Contribuyente c = new Contribuyente()
                    {
                        dniCont = reader.GetString(0),
                        nomCont = reader.GetString(1),
                        direcCont = reader.GetString(2),
                        emailCont = reader.GetString(3),
                        idpais = reader.GetString(4),
                        fonoCont = reader.GetString(5),
                    };
                    lista.Add(c);
                }


            }catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
                reader.Close();
            }

            return lista;
        }
        /// //////////////////////////////////////////////////////////////////////////////////////////
        public Contribuyente MostrarContribuyente(string id)
        {
            Contribuyente c = new Contribuyente();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();

                cmd = new SqlCommand("usp_Crud_Contribuyente", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@indicador", "MostrarContribuyente");
                cmd.Parameters.AddWithValue("@dniCont", id);
                cmd.Parameters.AddWithValue("@nomCont", "");
                cmd.Parameters.AddWithValue("@direcCont", "");
                cmd.Parameters.AddWithValue("@emailCont", "");
                cmd.Parameters.AddWithValue("@idpais", "");
                cmd.Parameters.AddWithValue("@fonoCont", "");

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    c = new Contribuyente()
                    {
                        dniCont = reader.GetString(0),
                        nomCont = reader.GetString(1),
                        direcCont = reader.GetString(2),
                        emailCont = reader.GetString(3),
                        idpais = reader.GetString(4),
                        fonoCont = reader.GetString(5),
                    };
                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
                reader.Close();
            }

            return c;
        }
        /// //////////////////////////////////////////////////////////////////////////////////////////
        public List<Paises> ComboPaises()
        {
            List<Paises> lista = new List<Paises>();

            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();

                cmd = new SqlCommand("usp_combo_pais", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Paises c = new Paises()
                    {
                        idPais= reader.GetString(0),
                        NombrePais= reader.GetString(1)
                    };
                    lista.Add(c);
                }


            }catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
                reader.Close();
            }

            return lista;
        }

        /// //////////////////////////////////////////////////////////////////////////////////////////
        public int ActualizarContribuyente(Contribuyente c)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int estado = -1;

            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();

                cmd = new SqlCommand("usp_Crud_Contribuyente", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@indicador", "Actualizar");
                cmd.Parameters.AddWithValue("@dniCont", c.dniCont);
                cmd.Parameters.AddWithValue("@nomCont", c.nomCont);
                cmd.Parameters.AddWithValue("@direcCont", c.direcCont);
                cmd.Parameters.AddWithValue("@emailCont", c.emailCont);
                cmd.Parameters.AddWithValue("@idpais", c.idpais);
                cmd.Parameters.AddWithValue("@fonoCont", c.fonoCont);

                estado = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return estado;
        }

        /// //////////////////////////////////////////////////////////////////////////////////////////
        public int EliminarContribuyente(string id)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int estado = -1;

            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();

                cmd = new SqlCommand("usp_Crud_Contribuyente", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@indicador", "Eliminar");
                cmd.Parameters.AddWithValue("@dniCont", id);
                cmd.Parameters.AddWithValue("@nomCont", "");
                cmd.Parameters.AddWithValue("@direcCont", "");
                cmd.Parameters.AddWithValue("@emailCont", "");
                cmd.Parameters.AddWithValue("@idpais", "");
                cmd.Parameters.AddWithValue("@fonoCont", "");

                estado = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return estado;
        }
        /// //////////////////////////////////////////////////////////////////////////////////////////
        public int InsertarContribuyente(Contribuyente c)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int estado = -1;

            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();

                cmd = new SqlCommand("usp_Crud_Contribuyente", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@indicador", "insertar");
                cmd.Parameters.AddWithValue("@dniCont", c.dniCont);
                cmd.Parameters.AddWithValue("@nomCont", c.nomCont);
                cmd.Parameters.AddWithValue("@direcCont", c.direcCont);
                cmd.Parameters.AddWithValue("@emailCont", c.emailCont);
                cmd.Parameters.AddWithValue("@idpais", c.idpais);
                cmd.Parameters.AddWithValue("@fonoCont", c.fonoCont);

                estado = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return estado;
        }
        /// //////////////////////////////////////////////////////////////////////////////////////////


        public ActionResult Index()
        {
            List<Contribuyente> lista = MostrarTodo();
            return View(lista);
        }

        public ActionResult Details(string id)
        {
            Contribuyente con = MostrarContribuyente(id);
            return View(con);
        }
        public ActionResult Delete(string id)
        {
            Contribuyente con = MostrarContribuyente(id);
            return View(con);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            EliminarContribuyente(id);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(string id)
        {
            List<Paises> lista = ComboPaises();
            ViewBag.combo = new SelectList(lista, "idPais", "NombrePais");
            Contribuyente con = MostrarContribuyente(id);
            return View(con);
        }
        [HttpPost]
        public ActionResult Edit(Contribuyente c)
        {
            List<Paises> lista = ComboPaises();
            ViewBag.combo = new SelectList(lista, "idPais", "NombrePais");
            ActualizarContribuyente(c);
            return RedirectToAction("Index");
        }
        public ActionResult Create(string id)
        {
            List<Paises> lista = ComboPaises();
            ViewBag.combo = new SelectList(lista, "idPais", "NombrePais");
            return View(new Contribuyente());
        }
        [HttpPost]
        public ActionResult Create(Contribuyente c)
        {
            List<Paises> lista = ComboPaises();
            ViewBag.combo = new SelectList(lista, "idPais", "NombrePais");
            InsertarContribuyente(c);
            return RedirectToAction("Index");
        }
    }
}