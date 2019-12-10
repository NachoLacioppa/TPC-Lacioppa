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
    public partial class BuscarOrden : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Ocultar_en_reparacion()
        {
            lblinformefinal.Visible = false;
            txtInforme.Visible = false;
            lblRepuestosUsados.Visible = false;
            dwRepuestosUsados.Visible = false;
            lblpf.Visible = false;
            lblPreciofinal.Visible = false;
        }
        public void Mostrar_Finalizado()
        {
            lblinformefinal.Visible = true;
            txtInforme.Visible = true;
            lblRepuestosUsados.Visible = true;
            dwRepuestosUsados.Visible = true;
            lblpf.Visible = true;
            lblPreciofinal.Visible = true;
        }

        public List<Reparaciones> lista { get; set; }
        public Reparaciones ORDEN;
        protected void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            Reparaciones rep = new Reparaciones();
            ReparacionesNegocio repn = new ReparacionesNegocio();

            if (string.IsNullOrEmpty(txtBuscarOrden.Text))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO INGRESO NADA EN LA BUSQUEDA');window.location ='BuscarOrden.aspx';", true);
            }

           //HACER UNA FUNCION O VARIAS QUE LISTE DEPENDE EL ESTADO DE LA REPARACION Y EVALUAR SI EL
           //TXTIDESTADO = 1 ESTA EN REPARACION SI ES = 2 ESTA FINALIZADO 

        }
    }
}