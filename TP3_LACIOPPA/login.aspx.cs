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
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["UsuarioTecnico"] = null;
            Session["IDTecnico"] = null;
            Session["PerfilTecnico"] = null;
            lblValidado.Visible = false;
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            //Tecnicos tec = new Tecnicos();
            TecnicoNegocio tecn = new TecnicoNegocio();
            Tecnicos tec1 = new Tecnicos();
            tec1 = tecn.ValidarUser(txtUsuario.Text, txtPass.Text);
            if(tec1 == null)
            {
                lblValidado.Visible = true;
            }
            else if (tec1 != null)
            {
                Session["IDTecnico"] = tec1.ID;
                Session["UsuarioTecnico"] = tec1.usuario;
                Session["PerfilTecnico"] = tec1.perfil.id;
                Session.Add("IDTecnico", tec1.ID);
                Session.Add("PerfilTecnico",tec1.perfil.id);
                Session.Add("UsuarioTecnico", tec1.usuario);
                Response.Redirect("~/MenuPrincipal.aspx");
            }
        }
    }
}