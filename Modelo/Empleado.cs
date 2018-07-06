using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class Empleado
    {
        int empleadoId;
        string apellido;
        string nombre;
        string cuil;
        double valorHora;
        double horaPorMes;
        Consorcio consorcio;

        public int EmpleadoId
        {
            get
            {
                return empleadoId;
            }

            set
            {
                empleadoId = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Cuil
        {
            get
            {
                return cuil;
            }

            set
            {
                cuil = value;
            }
        }

        public double ValorHora
        {
            get
            {
                return valorHora;
            }

            set
            {
                valorHora = value;
            }
        }

        public double HoraPorMes
        {
            get
            {
                return horaPorMes;
            }

            set
            {
                horaPorMes = value;
            }
        }

        public Consorcio Consorcio
        {
            get
            {
                return consorcio;
            }

            set
            {
                consorcio = value;
            }
        }

        public Empleado( string apellido, string nombre, string cuil, double valorHora, double horaPorMes, Consorcio consorcio)
        {
           
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Cuil = cuil;
            this.ValorHora = valorHora;
            this.HoraPorMes = horaPorMes;
            this.Consorcio = consorcio;
        }
        public double CalcularTotalSueldos()
        {
            return ValorHora * HoraPorMes;
        }
    }
}
