using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Clientes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
        public string telefono { get; set; }
        public string mail { get; set; }
        public bool estado{ get; set; }
    }
}
