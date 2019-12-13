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
        int validacion = 0;
        string validacion1 = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            validacion1 = (string)Session["UsuarioTecnico"];
            if (validacion1 == null)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('PRIMERO LOGUEATE');window.location ='login.aspx';", true);
            }
            else
            {
                validacion = (int)Session["PerfilTecnico"];
                if (validacion != 1)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO TIENE PERMISO');window.location ='MenuPrincipal.aspx';", true);
                }
                ReparacionesNegocio rpn = new ReparacionesNegocio();
                lista2 = rpn.listarRep2();
                lista1 = rpn.listarRep1();
            }
        }
    }
}