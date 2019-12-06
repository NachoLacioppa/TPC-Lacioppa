using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Reparaciones
    {
        public int id { get; set; }
        public long orden { get; set; }
        public Clientes cliente { get; set; }
        public Tecnicos tecnico { get; set; }
        public Repuestos repuesto { get; set; }
        public Equipos equipo { get; set; }
        public string informe { get; set; }
        public string problema { get; set; }
        public float presupuesto { get; set; }
        public DateTime fecha_entrada { get; set; }
        public DateTime fecha_salida { get; set; }
        public EstadosReparacion estados { get; set; }

    }
}
