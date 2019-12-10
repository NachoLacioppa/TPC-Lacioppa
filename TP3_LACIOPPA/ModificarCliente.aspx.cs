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
    public partial class ModificarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnModificarCliente.Enabled = false;
        }

       
        protected void btnBuscarClienteMod_Click(object sender, EventArgs e)
        {
            ClienteNegocio clin = new ClienteNegocio();
            Clientes cli = new Clientes();

            cli = clin.BuscarDNI(txtBuscarMod.Text);

            txtnombre.Text = cli.nombre;
            txtApellido.Text = cli.apellido;
            txtDNI.Text = cli.dni;
            txtDireccion.Text = cli.direccion;
            txtLocalidad.Text = cli.localidad;
            txtTelefono.Text = cli.telefono;
            txtMail.Text = cli.mail;

            btnModificarCliente.Enabled = true;

        }


        protected void btnModificarCliente_Click1(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            ClienteNegocio clin = new ClienteNegocio();

            if (string.IsNullOrEmpty(txtDNI.Text))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('DNI NULO');window.location ='ModificarCliente.aspx';", true);
            }

            cli.nombre = txtnombre.Text;
            cli.apellido = txtApellido.Text;
            cli.dni = txtDNI.Text;
            cli.direccion = txtDireccion.Text;
            cli.localidad = txtLocalidad.Text;
            cli.telefono = txtTelefono.Text;
            cli.mail = txtMail.Text;

            clin.ModificarCliente(cli);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('CLIENTE MODIFICADO');window.location ='MenuPrincipal.aspx';", true);
        }
    }
}