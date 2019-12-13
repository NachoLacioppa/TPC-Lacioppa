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
    public partial class BajaRepuestos : System.Web.UI.Page
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
                if (validacion == 3)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO TIENE PERMISO');window.location ='MenuPrincipal.aspx';", true);
                }
            }
        }

        public Repuestos codigo;
        protected void btnEliminarRepuesto_Click(object sender, EventArgs e)
        {
            RepuestosNegocio ren = new RepuestosNegocio();

            //dni = clin.ValidarDNI(txtBusquedaCliente.Text);
            codigo = ren.ValidarCodigo(txtBusquedaRepuesto.Text);
            //no existe
            if (codigo == null)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO EXISTE UN REPUESTOS CON ESE CODIGO');window.location ='BajaCliente.aspx';", true);
            }
            //ya esta eliminado
            else if (codigo.estado == false)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('REPUESTO YA ELIMINADO');window.location ='BajaCliente.aspx';", true);
            }
            //existe y actualiza estado a cero
            else if (codigo.estado == true)
            {
                ren.bajaRepuestos(codigo);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert(' ELIMINADO!!!');window.location ='BajaCliente.aspx';", true);

            }
        }
    }
}