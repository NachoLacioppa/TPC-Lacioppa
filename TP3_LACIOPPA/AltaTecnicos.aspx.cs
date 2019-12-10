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
    public partial class AltaTecnicos : System.Web.UI.Page
    {
        //private List<PerfilesTecnicos> Lista;
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

        public Tecnicos tecu;
        public Tecnicos tecu2;
        protected void btnAgregarTecnico_Click(object sender, EventArgs e)
        {
            Tecnicos te = new Tecnicos();
            TecnicoNegocio ten = new TecnicoNegocio();

            if (string.IsNullOrEmpty(txtUSER.Text))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('USUARIO Y/O DNI NULOS');window.location ='MenuPrincipal.aspx';", true);
            }
            else
            {
                tecu = ten.ValidarUsuario1(txtDNI.Text);
                tecu2 = ten.ValidarUsuario2(txtUSER.Text);

                if (tecu != null || tecu2 != null)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('TECNICO EXISTENTE, VERIFIQUE USUARIO Y/O DNI');window.location ='AltaTecnicos.aspx';", true);
                }

                else if (tecu == null || tecu2 == null)
                {
                    te.usuario = txtUSER.Text;
                    te.contraseña = txtPASS.Text;

                    te.perfil = new PerfilesTecnicos();
                    te.perfil.id = Convert.ToInt32(dwPerfil.SelectedItem.Value);

                    te.nombre = txtnombre.Text;
                    te.apellido = txtapellido.Text;
                    te.dni = txtDNI.Text;
                    te.sueldo = Convert.ToSingle(txtsueldo.Text);

                    ten.altaTecnico(te);
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('TECNICO AGREGADO');window.location ='MenuPrincipal.aspx';", true);
                }
            }
        }
    }
}