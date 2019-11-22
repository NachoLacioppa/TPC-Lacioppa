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
    public partial class AgregarPerfilesTecnicos : System.Web.UI.Page
    {
        public List<PerfilesTecnicos> listarperfiles { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            PerfilesTecnicosNegocio ptn = new PerfilesTecnicosNegocio();
            listarperfiles = ptn.listarPerfiles();
        }

        protected void btnperfilTecnico_Click(object sender, EventArgs e)
        {
            PerfilesTecnicos pt = new PerfilesTecnicos();
            PerfilesTecnicosNegocio ptn = new PerfilesTecnicosNegocio();

            pt.nombre = txtPerfil.Text;

            ptn.altaPerfilTecnico(pt);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('PERFIL AGREGADO');window.location ='AgregarPerfilesTecnicos.aspx';", true);
        }
    }
}