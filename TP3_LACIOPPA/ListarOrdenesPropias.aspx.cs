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
    public partial class ListarOrdenesPropias : System.Web.UI.Page
    {
        public List<Reparaciones> lista3 { get; set; }
        public List<Reparaciones> lista4 { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ReparacionesNegocio rpn = new ReparacionesNegocio();
            lblidtecnico.Visible = false;
            lblidtecnico.Text = (string)Session["IDTecnico"].ToString();

            lista3 = rpn.listarRep3(lblidtecnico.Text);
            lista4 = rpn.listarRep4(lblidtecnico.Text);
            
        }
    }
}