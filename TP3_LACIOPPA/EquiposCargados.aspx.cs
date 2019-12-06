using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMINIO;
using NEGOCIO;

namespace TP3_LACIOPPA
{
    public partial class EquiposCargados : System.Web.UI.Page
    {
        public List<Equipos> listaEquipos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            EquipoNegocio eqn = new EquipoNegocio();
            listaEquipos = eqn.listar();
        }
    }
}