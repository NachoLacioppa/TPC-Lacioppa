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
    public partial class BusquedaTecnicos : System.Web.UI.Page
    {
        public List<Tecnicos> listarTecnicos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            TecnicoNegocio ten = new TecnicoNegocio();
            listarTecnicos = ten.listarTecnicos();
        }
    }
}