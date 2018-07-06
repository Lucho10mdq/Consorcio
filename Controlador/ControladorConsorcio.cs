using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ControladorConsorcio
    {
        private RepositorioConsorcio listaConsorcio = RepositorioConsorcio.GetInstance();

        public List<Consorcio> DevolverConsorcios()
        {
            return listaConsorcio.DevolverConsorcio();
        }
    }
}
