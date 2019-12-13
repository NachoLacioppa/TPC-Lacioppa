using DOMINIO;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TP3_LACIOPPA
{
    public partial class BusquedaCliente : System.Web.UI.Page
    {
        public List<Clientes> listaClientes { get; set; }
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
                //EN LA CARGA DE LA PAGINA LLAMO A LA LISTA DEL OBJ PRODUCTOS
                ClienteNegocio negocio = new ClienteNegocio();
                listaClientes = negocio.listar();
            }
        }
    }
}