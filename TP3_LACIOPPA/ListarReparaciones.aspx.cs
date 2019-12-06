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
    public partial class ListarReparaciones : System.Web.UI.Page
    {
        public List<Reparaciones> lista2 { get; set; }
        public List<Reparaciones> lista1 { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ReparacionesNegocio rpn = new ReparacionesNegocio();
            lista2 = rpn.listarRep2();
            lista1 = rpn.listarRep1();
        }
    }
}