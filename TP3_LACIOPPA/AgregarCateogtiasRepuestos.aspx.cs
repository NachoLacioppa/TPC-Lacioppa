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
    public partial class AgregarCateogtiasRepuestos : System.Web.UI.Page
    {
        int validacion = 0;
        string validacion1 = null;
        public List<CategoriaRepuestos> listarCategorias { get; set; }
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
                if (validacion == 3)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO TIENE PERMISO');window.location ='MenuPrincipal.aspx';", true);
                }
                CategoriaRepuestosNegocios CRN = new CategoriaRepuestosNegocios();
                listarCategorias = CRN.listarCategorias();
            }

        }

        protected void btnCategoriaRepuesto_Click(object sender, EventArgs e)
        {
            CategoriaRepuestos cr = new CategoriaRepuestos();
            CategoriaRepuestosNegocios crn = new CategoriaRepuestosNegocios();

            if (string.IsNullOrEmpty(txtCategoriaRepuesto.Text))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('INGRESE ALGUNA CATEGORIA');window.location ='AgregarCateogtiasRepuestos.aspx';", true);
            }

            cr.nombre = txtCategoriaRepuesto.Text;

            crn.altaCategoriaRepuesto(cr);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('CATEGORIA DE REPUESTO AGREGADO');window.location ='AgregarCateogtiasRepuestos.aspx';", true);

        }
    }
}