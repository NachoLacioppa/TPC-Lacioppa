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
    public partial class AltaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            ClienteNegocio clientenegocio = new ClienteNegocio();

            cli.nombre = txtnombre.Text;
            cli.apellido = txtApellido.Text;
            cli.dni = txtDNI.Text;
            cli.direccion = txtDireccion.Text;
            cli.localidad = txtLocalidad.Text;
            cli.telefono = txtTelefono.Text;
            cli.mail = txtMail.Text;

            clientenegocio.altaCliente(cli);

            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('CLIENTE AGREGADO');window.location ='MenuPrincipal.aspx';", true);

        }
    }
}