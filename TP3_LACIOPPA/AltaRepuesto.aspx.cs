using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMINIO;
using NEGOCIO;

//LLENAR DROPDOWN LIST CON LAS CATEGORIAS PARA DAR DE ALTA

namespace TP3_LACIOPPA
{
    public partial class AltaRepuesto : System.Web.UI.Page
    {
        //private List<CategoriaRepuestos> Lista;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                CategoriaRepuestosNegocios negocio = new CategoriaRepuestosNegocios();
                dwCategorias.DataTextField = "nombre";
                dwCategorias.DataValueField = "id";
                dwCategorias.DataSource = negocio.listarCategorias();
                dwCategorias.DataBind();
            }

        }

        protected void btnAltaRepuesto_Click(object sender, EventArgs e)
        {
            try
            {
            Repuestos re = new Repuestos();
            RepuestosNegocio ren = new RepuestosNegocio();

            re.codigo = txtCodigo.Text;
            re.nombre = txtnombre.Text;
            re.precio = Convert.ToSingle(txtPrecio.Text);
            re.cantidad = Convert.ToInt32(txtCantidad.Text);

            re.categoria = new CategoriaRepuestos();
            re.categoria.id = Convert.ToInt32(dwCategorias.SelectedItem.Value);

            ren.altaRepuesto(re);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('REPUESTO AGREGADO');window.location ='MenuPrincipal.aspx';", true);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}