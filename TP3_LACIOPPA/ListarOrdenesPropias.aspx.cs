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
    public partial class ListarOrdenesPropias : System.Web.UI.Page
    {
        public List<Reparaciones> lista3 { get; set; }
        public List<Reparaciones> lista4 { get; set; }
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
                ReparacionesNegocio rpn = new ReparacionesNegocio();
                lblidtecnico.Visible = false;
                lblidtecnico.Text = (string)Session["IDTecnico"].ToString();

                lista3 = rpn.listarRep3(lblidtecnico.Text);
                lista4 = rpn.listarRep4(lblidtecnico.Text);
            }
        }
    }
}