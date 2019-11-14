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
        public List<CategoriaRepuestos> listarCategorias { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoriaRepuestosNegocios CRN = new CategoriaRepuestosNegocios();
            listarCategorias = CRN.listarCategorias();
        }

        protected void btnCategoriaRepuesto_Click(object sender, EventArgs e)
        {
            CategoriaRepuestos cr = new CategoriaRepuestos();
            CategoriaRepuestosNegocios crn = new CategoriaRepuestosNegocios();

            cr.nombre = txtCategoriaRepuesto.Text;

            crn.altaCategoriaRepuesto(cr);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('CATEGORIA DE REPUESTO AGREGADO');window.location ='AgregarCateogtiasRepuestos.aspx';", true);

        }
    }
}