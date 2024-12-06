using Microsoft.Ajax.Utilities;
using POOI_T3_DanielAlexanderDeLaCruzBriceño.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace POOI_T3_DanielAlexanderDeLaCruzBriceño.Metodos
{
    public class FiltrosEmpleado
    {
        public List<Empleados> MostrarTodo(string filtro)
        {
            List<Empleados> lista = new List<Empleados>();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();

                cmd = new SqlCommand("USP_FILTRAR_EMPLEADOS", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FILTRO", filtro);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Empleados obj = new Empleados()
                    {
                        IdEmpleado=reader.GetInt32(0),
                        Nombre=reader.GetString(1),
                        Apellidos=reader.GetString(2),
                        DNI=reader.GetString(3),
                        Email=reader.GetString(4),
                    };
                    lista.Add(obj);
                }

            }catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
                reader.Close();
            }
            return lista;
        }

        public Empleados MostrarEmpleado(int id)
        {
            Empleados e = new Empleados();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();

                cmd = new SqlCommand("usp_obtener_empleado", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", id);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    e = new Empleados()
                    {
                        IdEmpleado = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellidos = reader.GetString(2),
                        DNI = reader.GetString(3),
                        Email = reader.GetString(4),
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
            return e;
        }

        public int InsertarEmpleado(Empleados e)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int error = -1;
            string parametro = "";
            
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();

                cmd = new SqlCommand("usp_insertar_empleado", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", e.Nombre);
                cmd.Parameters.AddWithValue("@Apellidos", e.Apellidos);
                cmd.Parameters.AddWithValue("@DNI", e.DNI);
                cmd.Parameters.AddWithValue("@Email", e.Email);
                
                error = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return error;
        }

        public int EliminarEmpleado(int id)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int error = -1;

            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();

                cmd = new SqlCommand("usp_eliminar_empleado", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", id);
           

                error = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return error;
        }
        public int ActualizarEmpleado(Empleados e)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            int error = -1;

            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();

                cmd = new SqlCommand("usp_actualizar_empleado", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", e.IdEmpleado);
                cmd.Parameters.AddWithValue("@Nombre", e.Nombre);
                cmd.Parameters.AddWithValue("@Apellidos", e.Apellidos);
                cmd.Parameters.AddWithValue("@DNI", e.DNI);
                cmd.Parameters.AddWithValue("@Email", e.Email);

                error = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return error;
        }
    }
}