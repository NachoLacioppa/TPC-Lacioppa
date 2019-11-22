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
    public partial class ModificarTecnico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PerfilesTecnicosNegocio negocio = new PerfilesTecnicosNegocio();
                dwPerfil.DataTextField = "nombre";
                dwPerfil.DataValueField = "id";
                dwPerfil.DataSource = negocio.listarPerfiles();
                dwPerfil.DataBind();
            }
        }

        protected void btnModificarCliente_Click(object sender, EventArgs e)
        {
            Tecnicos tec = new Tecnicos();
            TecnicoNegocio tecn = new TecnicoNegocio();

            tec.usuario = txtusuario.Text;
            tec.nombre = txtnombre.Text;
            tec.apellido = txtApellido.Text;
            tec.dni = txtDNI.Text;
            tec.sueldo = Convert.ToSingle(txtsueldo.Text);
            tec.perfil = new PerfilesTecnicos();
            tec.perfil.id = Convert.ToInt32(dwPerfil.SelectedItem.Value);

            tecn.ModificarTecnicos(tec);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('TECNICO MODIFICADO');window.location ='MenuPrincipal.aspx';", true);

        }

        protected void btnBuscarTecn_Click(object sender, EventArgs e)
        {
            TecnicoNegocio tecn = new TecnicoNegocio();
            Tecnicos tec = new Tecnicos();

            tec = tecn.BuscarUsuario(txtBuscarUsuario.Text);

            txtusuario.Text = tec.usuario;
            txtnombre.Text = tec.nombre;
            txtApellido.Text = tec.apellido;
            txtDNI.Text = tec.dni.ToString();
            txtsueldo.Text = tec.sueldo.ToString();
            dwPerfil.SelectedItem.Value = tec.perfil.id.ToString();
        }
    }
}