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
   public class RepositorioEmpleado:Singleton<RepositorioEmpleado>
    {
        private List<Empleado> ListaEmpleados = new List<Empleado>();
        static RepositorioEmpleado instance = null;

        SqlConnection conexion = new SqlConnection(@"Server=LAPTOP-4RC7FOER;Database=Consorcios;Trusted_Connection=True;");

        public int agregarEmpleado(Empleado oEmpleado)
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.Connection = conexion;
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Empleados_Agregar";
            c.Parameters.AddWithValue("ConsorcioId", oEmpleado.Consorcio.ConsorcioId);
            c.Parameters.AddWithValue("Apellido", oEmpleado.Apellido);
            c.Parameters.AddWithValue("Nombre", oEmpleado.Nombre);
            c.Parameters.AddWithValue("CUIL", oEmpleado.Cuil);
            c.Parameters.AddWithValue("ValorHora", oEmpleado.ValorHora);
            c.Parameters.AddWithValue("HorasPorMes", oEmpleado.HoraPorMes);
            /* SqlDataReader dn = c.ExecuteReader();
             if (dn.Read())
                 oEmpleado.EmpleadoId = dn.GetInt32(0);
             return oEmpleado;
             dn.Close();*/
            int affectedRows = c.ExecuteNonQuery();
            conexion.Close();
            return affectedRows;
           
        }
        public List<Empleado> DevolverEmpleados()
        {
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Empleados_DevolverTodos";
            SqlDataReader dn = c.ExecuteReader();
            c.Prepare();
            while (dn.Read())
            {
                string apellido = dn.GetString(1);
                string nombre = dn.GetString(2);
                string cuil = dn.GetString(3);
                double valorHora =Convert.ToDouble(dn.GetDecimal(4));
                double HoraMes = Convert.ToDouble(dn.GetDecimal(5));
                string nombreConsorcio = dn.GetString(7);
                string cuit = dn.GetString(8);
                Consorcio oConsorocio = new Consorcio(nombre,cuit);
                oConsorocio.ConsorcioId = dn.GetInt32(6);
                Empleado oEmpleado = new Empleado(apellido,nombre,cuil,valorHora,HoraMes,oConsorocio);
                oEmpleado.EmpleadoId = dn.GetInt32(0);
                ListaEmpleados.Add(oEmpleado);
            }
            dn.Close();
            conexion.Close();
            return ListaEmpleados;
        }

        public Empleado Buscar(string cuil)
        {
            Empleado oEmpleado=null;
            conexion.Open();
            SqlCommand c = conexion.CreateCommand();
            c.CommandType = CommandType.StoredProcedure;
            c.CommandText = "Buscar_Cuil";
           
            SqlParameter CuilParameter = c.CreateParameter();
            CuilParameter.ParameterName = "@CUIL";
            CuilParameter.SqlDbType = SqlDbType.VarChar;
            CuilParameter.Value = cuil;
            c.Parameters.Add(CuilParameter);
            SqlDataReader dn = c.ExecuteReader();
            while(dn.Read())
            {
                string apellido = dn.GetString(1);
                string nombre = dn.GetString(2);
                string CUIL = dn.GetString(3);
                double valorHora = Convert.ToDouble(dn.GetDecimal(4));
                double HoraMes = Convert.ToDouble(dn.GetDecimal(5));
                string nombreConsorcio = dn.GetString(7);
                string cuit = dn.GetString(8);
                Consorcio oConsorocio = new Consorcio(nombre, cuit);
                oConsorocio.ConsorcioId = dn.GetInt32(6);
                 oEmpleado = new Empleado(apellido, nombre, cuil, valorHora, HoraMes, oConsorocio);
                 oEmpleado.EmpleadoId = dn.GetInt32(0);
            }
            dn.Close();
            conexion.Close();
            return oEmpleado;
        }
    }
}
