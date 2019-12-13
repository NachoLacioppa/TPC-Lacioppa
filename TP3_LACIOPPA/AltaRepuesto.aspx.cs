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
                if (validacion == 3)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO TIENE PERMISO');window.location ='MenuPrincipal.aspx';", true);
                }

                if (!IsPostBack)
                {
                    CategoriaRepuestosNegocios negocio = new CategoriaRepuestosNegocios();
                    dwCategorias.DataTextField = "nombre";
                    dwCategorias.DataValueField = "id";
                    dwCategorias.DataSource = negocio.listarCategorias();
                    dwCategorias.DataBind();
                }
            }
            

        }

        public Repuestos repu;
        protected void btnAltaRepuesto_Click(object sender, EventArgs e)
        {
            try
            {
            Repuestos re = new Repuestos();
            RepuestosNegocio ren = new RepuestosNegocio();

                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('CODIGO NULO');window.location ='AltaRepuesto.aspx';", true);
                }

                repu = ren.ValidarCodigo(txtCodigo.Text);

                if (repu == null)
                {
                    re.codigo = txtCodigo.Text;
                    re.nombre = txtnombre.Text;
                    re.precio = Convert.ToSingle(txtPrecio.Text);

                    re.categoria = new CategoriaRepuestos();
                    re.categoria.id = Convert.ToInt32(dwCategorias.SelectedItem.Value);

                    ren.altaRepuesto(re);
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('REPUESTO AGREGADO');window.location ='MenuPrincipal.aspx';", true);
                }

                else if(repu != null)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('CODIGO REPETIDO');window.location ='AltaRepuesto.aspx';", true);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}