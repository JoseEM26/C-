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
    public class ProveedoresController : Controller
    {
        public List<Proveedores> MostrarProveedores()
        {
            List<Proveedores> lista = new List<Proveedores>();

            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();

                cmd = new SqlCommand("usp_listar_proovedores", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Proveedores c = new Proveedores()
                    {
                        IdProveedor = reader.GetInt32(0),
                        NomContacto = reader.GetString(1),
                        DirProveedor = reader.GetString(2),
                        CargoContacto = reader.GetString(3),
                        idpais = reader.GetString(4),
                        fonoProveedor = reader.GetString(5),
                        FaxProveedor = reader.GetString(6),
                        TotalUnidades= reader.GetInt32(7)
                    };
                    lista.Add(c);
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

            return lista;
        }

        // GET: Proveedores

        public ActionResult Index()
        {
            List<Proveedores> lista = MostrarProveedores();
            return View(lista);
        }
    }
}