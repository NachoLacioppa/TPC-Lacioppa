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
                Session["PresupuestoTotal"] = 0;
                Session["AcumRepuesto"] = 0;
                lblPerfilTecnico.Visible = false;
                lblPerfilTecnico.Text = (string)Session["PerfilTecnico"].ToString();
                lblUser.Text = (string)Session["UsuarioTecnico"];
                if (Convert.ToInt32(lblPerfilTecnico.Text) == 2)
                {
                    btnTec.Disabled = true;
                    lstReparaciones.Visible = false;
                }
                if (Convert.ToInt32(lblPerfilTecnico.Text) == 3)
                {
                    btnTec.Disabled = true;
                    lstReparaciones.Visible = false;
                    btnRepuestos.Disabled = true;
                }
            }
        }
    }
}