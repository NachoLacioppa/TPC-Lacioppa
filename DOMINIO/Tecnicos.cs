using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Tecnicos
    {
        public int ID { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public PerfilesTecnicos perfil { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public float sueldo { get; set; }
        public bool estado { get; set; }

    }
}
