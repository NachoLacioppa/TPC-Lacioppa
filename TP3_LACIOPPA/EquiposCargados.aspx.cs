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
                EquipoNegocio eqn = new EquipoNegocio();
                listaEquipos = eqn.listar();
            }

        }
    }
}