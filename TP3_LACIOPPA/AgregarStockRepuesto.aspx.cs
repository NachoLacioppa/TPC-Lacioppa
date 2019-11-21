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
    public partial class AgregarStockRepuesto : System.Web.UI.Page
    {
        public List<Repuestos> listarRepuestos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnAgregarStock_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscarRepuesto_Click(object sender, EventArgs e)
        {
            RepuestosNegocio rn = new RepuestosNegocio();
            listarRepuestos = rn.listarRepuestos();
        }
        //RepuestosNegocio rn = new RepuestosNegocio();
        //listarRepuestos = rn.listarRepuestos();

    }
}