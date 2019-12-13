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
        string validacion1 = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            validacion1 = (string)Session["UsuarioTecnico"];
            if (validacion1 == null)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('PRIMERO LOGUEATE');window.location ='login.aspx';", true);
            }

        }

        public Clientes dnicli;
        protected void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            ClienteNegocio clientenegocio = new ClienteNegocio();

            if (String.IsNullOrEmpty(txtDNI.Text))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('DNI NULO');window.location ='AltaCliente.aspx';", true);
            }
            else
            {
                dnicli =  clientenegocio.ValidarDNI(txtDNI.Text);
                if (dnicli == null)
                {
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
                else if (dnicli != null)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('DNI REPETIDO');window.location ='MenuPrincipal.aspx';", true);
                }
            }
        }
    }
}