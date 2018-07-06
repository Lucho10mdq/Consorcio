using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class Consorcio
    {
        int consorcioId;
        string nombre;
        string cuit;

        public int ConsorcioId
        {
            get
            {
                return consorcioId;
            }

            set
            {
                consorcioId = value;
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

        public string Cuit
        {
            get
            {
                return cuit;
            }

            set
            {
                cuit = value;
            }
        }

        public Consorcio(string nombre, string cuit)
        {
            this.Nombre = nombre;
            this.Cuit = cuit;
        }
    }
}
