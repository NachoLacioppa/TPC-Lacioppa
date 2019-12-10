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
    public partial class BajaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Clientes dni;

        protected void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            //Clientes cli = new Clientes();
            ClienteNegocio clin = new ClienteNegocio();

            dni = clin.ValidarDNI(txtBusquedaCliente.Text);
            //no existe
            if(dni == null)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO EXISTE UN CLIENTE CON ESE DNI');window.location ='BajaCliente.aspx';", true);
            }
            //ya esta eliminado
            else if (dni.estado == false)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('CLIENTE YA ELIMINADO');window.location ='BajaCliente.aspx';", true);
            }
            //existe y actualiza estado a cero
            else if (dni.estado == true)
            {
                clin.bajaCliente(dni);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('CLIENTE ELIMINADO!!!');window.location ='BajaCliente.aspx';", true);
                
            }
        }
    }
}