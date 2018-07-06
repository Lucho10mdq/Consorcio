using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Modelo
{
   public class RepositorioConsorcio:Singleton<RepositorioConsorcio>
    {
        private List<Consorcio> ListaConsorcio = new List<Consorcio>();
        static RepositorioConsorcio instance = null;

        SqlConnection conexion = new SqlConnection();


        //LISTAR CONSORCIO

        public List<Consorcio> DevolverConsorcio()
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Consorcios_DevolverTodos";
            SqlDataReader dn = c.ExecuteReader();
            c.Prepare();
            while (dn.Read())
            {
                string nombre = dn.GetString(1);
                string cuit = dn.GetString(2);
                Consorcio oConsorcio = new Consorcio(nombre, cuit);
                oConsorcio.ConsorcioId = dn.GetInt32(0);
                ListaConsorcio.Add(oConsorcio);
            }
            dn.Close();
            conexion.Close();
            return ListaConsorcio;

        }
      
    }
}
