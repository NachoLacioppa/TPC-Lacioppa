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
    public partial class BusquedaTecnicos : System.Web.UI.Page
    {
        
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
                TecnicoNegocio ten = new TecnicoNegocio();
                listarTecnicos = ten.listarTecnicos();
            }
            
        }
        public List<Tecnicos> listarTecnicos { get; set; }
    }
}