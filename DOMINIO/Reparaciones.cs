using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Reparaciones
    {
        public int numeroorden { get; set; }
        public Clientes cliente { get; set; }
        public Tecnicos tecnico { get; set; }
        public Repuestos repuesto { get; set; }
        public string informeTEC { get; set; }
        public string informeCLI { get; set; }
        public float presupuesto { get; set; }
        public int estados { get; set; }

    }
}
