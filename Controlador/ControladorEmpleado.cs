using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorEmpleado
    {
        private RepositorioEmpleado listaEmpleados = RepositorioEmpleado.GetInstance();
        public bool AgregarEmpleado(string apellido,string pNombre,string cuil,double ValorHora,double horaMes, int idConsorcio, string nombre, string cuit)
        {
            var result = false;
            Consorcio oConsorcio = new Consorcio(nombre, cuit);
            oConsorcio.ConsorcioId = idConsorcio;
            Empleado oEmpleado = new Empleado(apellido, nombre, cuil, ValorHora, horaMes, oConsorcio);
            if(listaEmpleados.Buscar(cuil)==null)
            {
                listaEmpleados.agregarEmpleado(oEmpleado);
                result = true;
            }
            return result;     
        }

        public List<Empleado> DevolverEmpleados()
        {
            return listaEmpleados.DevolverEmpleados();
        }
        public Empleado BuscarEmpleado(string dni)
        {
            return listaEmpleados.Buscar(dni);
        }

        public double CalcularSueldo()
        {
            double total = 0;
            foreach(Empleado oEmpleado in listaEmpleados.DevolverEmpleados())
            {
                total = total + oEmpleado.CalcularTotalSueldos();
               
            }
            return total;
        }
    }
}
