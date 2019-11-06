using DOMINIO;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TP3_LACIOPPA
{
    public partial class BusquedaCliente : System.Web.UI.Page
    {
        public List<Clientes> listaClientes { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //EN LA CARGA DE LA PAGINA LLAMO A LA LISTA DEL OBJ PRODUCTOS
            ClienteNegocio negocio = new ClienteNegocio();
            listaClientes = negocio.listar();

        }
    }
}