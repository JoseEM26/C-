using ExamenT2.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace ExamenT2.DAO.List
{
    public class ItemList
    {
        public List<Item> SeleccionarTodo()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            List<Item> lista = new List<Item>();
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                con.Open();

                cmd = new SqlCommand("USP_LISTAR_ITEM", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Item Item = new Item()
                    {
                        ItemID = Convert.ToInt32(reader[0]),
                        TipoID = Convert.ToInt32(reader[1]),
                    };

                    lista.Add(Item);
                }




            }
            catch (Exception e)
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

    }
}