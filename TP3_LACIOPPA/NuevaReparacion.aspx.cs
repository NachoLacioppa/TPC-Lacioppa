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
    public partial class NuevaReparacion : System.Web.UI.Page
    {
        //Equipos eq = new Equipos();
        //EquipoNegocio eqn = new EquipoNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            Reparaciones rep = new Reparaciones();
            ReparacionesNegocio repn = new ReparacionesNegocio();
            txtOrden.Text = repn.BuscarOrden().ToString();

            //Equipos eq = new Equipos();
            //EquipoNegocio eqn = new EquipoNegocio();
            //txtidequipo.Text = eqn.BuscarIDEquipo().ToString();

            if (!IsPostBack)
            {
                TecnicoNegocio negocio = new TecnicoNegocio();
                dwTecnico.DataTextField = "Usuario";
                dwTecnico.DataValueField = "id";
                dwTecnico.DataSource = negocio.listarUsers();
                dwTecnico.DataBind();
            }

        }

        protected void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            ClienteNegocio clin = new ClienteNegocio();

            cli = clin.BuscarDNI(txtCliente.Text);
            txtidcliente.Text = cli.id.ToString();
            txtNombre.Text = cli.nombre;
            txtApellido.Text = cli.apellido;
            txtTelefono.Text = cli.telefono;
        }

        protected void btnBuscarEquipo_Click(object sender, EventArgs e)
        {
            Equipos eq = new Equipos();
            EquipoNegocio eqn = new EquipoNegocio();

            eq = eqn.BuscarCodigo(txtNumeroSerie.Text);
            txtidequipo.Text = eqn.BuscarIDEquipo().ToString();
            txtidequipo.Text = Convert.ToInt32(eq.id).ToString();
            txtMarca.Text = eq.marca;
            txtModelo.Text = eq.modelo;
        }

        public Equipos sn;
        protected void btnCargarReparacion_Click(object sender, EventArgs e)
        {
            try
            {
                Reparaciones re = new Reparaciones();
                ReparacionesNegocio ren = new ReparacionesNegocio();

                EquipoNegocio eqn = new EquipoNegocio();

                re.orden = Convert.ToInt64(txtOrden.Text);

                re.cliente = new Clientes();
                re.cliente.id = Convert.ToInt32(txtidcliente.Text);
                re.cliente.dni = txtCliente.Text;

                sn = eqn.ValidarSN(txtNumeroSerie.Text);
                if (sn == null)
                {
                    Equipos eq = new Equipos();

                    txtidequipo.Text = eqn.BuscarIDEquipo().ToString();
                    eq.numeroserie = txtNumeroSerie.Text;
                    eq.marca = txtMarca.Text;
                    eq.modelo = txtModelo.Text;

                    eqn.altaEquipo(eq);
                }

                re.equipo = new Equipos();
                re.equipo.id = Convert.ToInt32(txtidequipo.Text);
                re.equipo.numeroserie = txtNumeroSerie.Text;
                re.equipo.marca = txtMarca.Text;
                re.equipo.modelo = txtModelo.Text;

                re.problema = txtProblema.Text;

                re.tecnico = new Tecnicos();
                re.tecnico.ID = Convert.ToInt32(dwTecnico.SelectedItem.Value);

                ren.NuevaReparacion(re);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NUEVA REPARACION CONFIRMADA');window.location = 'MenuPrincipal.aspx';", true);              
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}