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
        string validacion1 = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            validacion1 = (string)Session["UsuarioTecnico"];
            if (validacion1 == null)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('PRIMERO LOGUEATE');window.location ='login.aspx';", true);
            }
            lblIngreseNumeroOrden.Visible = false;
            Ocultar_TODO();
        }

        public void Ocultar_TODO()
        {
            //REPARACION
            lblinformefinal.Visible = false;
            txtInforme.Visible = false;
            lblRepuestosUsados.Visible = false;
            dwRepuestosUsados.Visible = false;
            lblpf.Visible = false;
            lblPreciofinal.Visible = false;
            lblFechaSal.Visible = false;
            //FINALIZADO
            lblinformefinal.Visible = false;
            txtInforme.Visible = false;
            lblRepuestosUsados.Visible = false;
            dwRepuestosUsados.Visible = false;
            lblpf.Visible = false;
            lblPreciofinal.Visible = false;
            lblFechaSal.Visible = false;
        }
        public void Mostrar_reparacion()
        {
            lblinformefinal.Visible = true;
            txtInforme.Visible = true;
            lblRepuestosUsados.Visible = true;
            dwRepuestosUsados.Visible = true;
            lblpf.Visible = true;
            lblPreciofinal.Visible = true;
            lblFechaSal.Visible = true;

        }
        public void Mostrar_finalizado() 
        {
            lblinformefinal.Visible = true;
            txtInforme.Visible = true;
            lblRepuestosUsados.Visible = true;
            dwRepuestosUsados.Visible = true;
            lblpf.Visible = true;
            lblPreciofinal.Visible = true;
            lblFechaSal.Visible = true;
        }


        public List<Reparaciones> lista { get; set; }
        public Reparaciones rep_reparacion;
        public Reparaciones rep_finalizado;
        protected void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            Reparaciones rep = new Reparaciones();
            ReparacionesNegocio repn = new ReparacionesNegocio();

            Repuestos repu = new Repuestos();
            RepuestosNegocio repun = new RepuestosNegocio();
            

            if (string.IsNullOrEmpty(txtBuscarOrden.Text))
            {
                lblIngreseNumeroOrden.Visible = true;
            }

            //rep = repn.BuscarReparacion_ESPESIFICA(txtBuscarOrden.Text);
            rep_reparacion = repn.ValidarOrden(txtBuscarOrden.Text);
            rep_finalizado = repn.ValidarOrden1(txtBuscarOrden.Text);

            //orden en reparacion
            if(rep_reparacion != null && rep_finalizado == null)
            {
                Mostrar_reparacion();
                rep = repn.BuscarReparacion_ESPESIFICA_REPARACION(txtBuscarOrden.Text);
                txtIDESTADO.Text = Convert.ToInt32(rep.estados.id).ToString();
                txtIDORDEN.Text = Convert.ToInt32(rep.id).ToString();

                //CLIENTE
                lblCliNombre.Text = rep.cliente.nombre;
                lblCliApellido.Text = rep.cliente.apellido;
                lblCliTelefono.Text = rep.cliente.telefono;

                //equipo
                lblEqSN.Text = rep.equipo.numeroserie;
                lblEqMarca.Text = rep.equipo.marca;
                lblEqModelo.Text = rep.equipo.modelo;

                //tecnico, problema y fecha de ingreso
                lblTecasignado.Text = rep.tecnico.usuario;
                txtProblema.Text = rep.problema;
                lblFechaIng.Text = Convert.ToDateTime(rep.fecha_entrada).ToString();

            }
            //ORDEN FINALIZADA
            else if (rep_reparacion == null && rep_finalizado != null)
            {
                Mostrar_reparacion();
                Mostrar_finalizado();
                rep = repn.BuscarReparacion_ESPESIFICA_FINALIZADO(txtBuscarOrden.Text);

                txtIDESTADO.Text = Convert.ToInt32(rep.estados.id).ToString();
                txtIDORDEN.Text = Convert.ToInt32(rep.id).ToString();

                //CLIENTE
                lblCliNombre.Text = rep.cliente.nombre;
                lblCliApellido.Text = rep.cliente.apellido;
                lblCliTelefono.Text = rep.cliente.telefono;

                //equipo
                lblEqSN.Text = rep.equipo.numeroserie;
                lblEqMarca.Text = rep.equipo.marca;
                lblEqModelo.Text = rep.equipo.modelo;

                //tecnico, problema y fecha de ingreso
                lblTecasignado.Text = rep.tecnico.usuario;
                txtProblema.Text = rep.problema;
                lblFechaIng.Text = Convert.ToDateTime(rep.fecha_entrada).ToString();

                //informe, preciofinal, fecha salida
                lblFechaSal.Text = Convert.ToDateTime(rep.fecha_salida).ToString();
                txtInforme.Text = rep.informe;
                lblPreciofinal.Text = Convert.ToSingle(rep.presupuesto).ToString();

                //REPUESTOS USADOS
                List<Repuestos> lista;
                lista = new List<Repuestos>();
                lista = repun.listaRepuxRepa(txtIDORDEN.Text);
                lista.Add(repu);
                dwRepuestosUsados.DataSource = lista;
                dwRepuestosUsados.DataBind();

                //dwRepuestosUsados.Columns[0].Visible = false;

            }
            else if(rep_reparacion == null && rep_finalizado == null)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('ORDEN INEXSISTENTE');window.location ='BuscarOrden.aspx';", true);
            }



        }

        protected void dwRepuestosUsados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}