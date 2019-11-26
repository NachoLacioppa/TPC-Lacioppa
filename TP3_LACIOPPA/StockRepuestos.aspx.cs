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
    public partial class StockRepuestos : System.Web.UI.Page
    {
        public List<Repuestos> listarRepuestosStock { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        protected void btnBuscarRepuesto_Click(object sender, EventArgs e)
        {

            Repuestos re = new Repuestos();
            RepuestosNegocio rn = new RepuestosNegocio();

            dgvListarRepuestos.DataSource = rn.listarRepuestoStock(txtBuscarRepuesto.Text);
            dgvListarRepuestos.DataBind();

        }
    }
}

