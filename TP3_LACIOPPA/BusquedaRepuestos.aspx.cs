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
    public partial class BusquedaRepuestos : System.Web.UI.Page
    {
        public List<Repuestos> listarRepuestos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            RepuestosNegocio rn = new RepuestosNegocio();
            listarRepuestos = rn.listarRepuestos();
        }
    }
}