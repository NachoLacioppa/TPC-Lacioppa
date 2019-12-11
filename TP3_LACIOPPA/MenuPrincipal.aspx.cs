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
    public partial class MenuPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["PresupuestoTotal"] = 0;
            Session["AcumRepuesto"] = 0;
        }
    }
}