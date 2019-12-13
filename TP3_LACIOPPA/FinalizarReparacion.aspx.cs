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
    public partial class FinalizarReparacion : System.Web.UI.Page
    {
        double acum;
        double acumTotal;
        double ManoObra;
        string validacion1 = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            validacion1 = (string)Session["UsuarioTecnico"];
            if (validacion1 == null)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('PRIMERO LOGUEATE');window.location ='login.aspx';", true);
            }
            else
            {
                acum = Convert.ToDouble(Session["AcumRepuesto"]);
                acumTotal = Convert.ToDouble(Session["PresupuestoTotal"]);
                btnFinalizarOrden.Enabled = false;
                btnAgregarRepuesto.Enabled = false;
                lblVerificaRepuesto.Visible = false;


                if (!IsPostBack)
                {
                    Session["ListaRepuestos"] = null;
                    btnFinalizarOrden.Enabled = false;
                    btnAgregarRepuesto.Enabled = false;
                    lblVerificaRepuesto.Visible = false;
                }
            }
        }
        public List<Reparaciones> lista { get; set; }
        public Reparaciones repa;
        protected void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            Reparaciones rep = new Reparaciones();
            ReparacionesNegocio repn = new ReparacionesNegocio();

            //if (string.IsNullOrEmpty(txtCodigoRep.Text))
            //{
            //    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO INGRESO NADA');window.location ='FinalizarReparacion.aspx';", true);
            //}

            repa = repn.ValidarOrden(txtOrden.Text);

            if (repa != null)
            {
                rep = repn.BuscarReparacion2(txtOrden.Text);
                txtIDReparacion.Text = Convert.ToInt32(rep.id).ToString();

                txtNombreCli.Text = rep.cliente.nombre;
                txtApellidoCli.Text = rep.cliente.apellido;
                txtTelefonoCli.Text = rep.cliente.telefono;

                txtSN.Text = rep.equipo.numeroserie;
                txtMarca.Text = rep.equipo.marca;
                txtModelo.Text = rep.equipo.modelo;

                txtUser.Text = rep.tecnico.usuario;
                txtFechaIng.Text = Convert.ToDateTime(rep.fecha_entrada).ToString();
                txtEstado.Text = rep.estados.nombre;
                txtProblema.Text = rep.problema;

                btnAgregarRepuesto.Enabled = true;
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('REPARACION NO ENCONTRADA O FINALIZADA');window.location ='FinalizarReparacion.aspx';", true);
            }
        }

        protected void btnBuscarRepuesto_Click(object sender, EventArgs e)
        {
            Repuestos repu = new Repuestos();
            RepuestosNegocio repun = new RepuestosNegocio();

           
                repu = repun.BuscarCodigo2(txtCodigoRep.Text);
                txtIDRepuesto.Text = Convert.ToInt32(repu.id).ToString();
                txtNompreRep.Text = repu.nombre;
                txtPrecioRepuesto.Text = Convert.ToSingle(repu.precio).ToString();
                btnAgregarRepuesto.Enabled = true;
            
        }
        //List<Repuestos> listaRepuestos2 = new List<Repuestos>();
        protected void btnAgregarRepuesto_Click(object sender, EventArgs e)
        {
            Repuestos rp = new Repuestos();
            RepuestosNegocio rpn = new RepuestosNegocio();

            Reparaciones rep = new Reparaciones();
            ReparacionesNegocio repn = new ReparacionesNegocio();

            if (string.IsNullOrEmpty(txtCodigoRep.Text))
            {
                lblVerificaRepuesto.Visible = true;
            }
            else
            {
                rp = rpn.listarRepuestosReparacion(txtIDRepuesto.Text)[0];

                List<Repuestos> lista;
                if (Session["ListaRepuestos"] == null)
                {
                    lista = new List<Repuestos>();
                    lista.Add(rp);
                    Session["ListaRepuestos"] = lista;
                    gvDatosRepuestos.DataSource = lista;
                    gvDatosRepuestos.Visible = true;
                    gvDatosRepuestos.DataBind();
                    acum = acum + Convert.ToDouble(txtPrecioRepuesto.Text);
                    //Session["AcumRepuesto"]
                    Session.Add("AcumRepuesto", acum);
                }
                else
                {
                    lista = (Session["ListaRepuestos"] as List<Repuestos>);
                    lista.Add(rp);
                    gvDatosRepuestos.DataSource = lista;
                    gvDatosRepuestos.Visible = true;
                    gvDatosRepuestos.DataBind();
                    acum = acum + Convert.ToDouble(txtPrecioRepuesto.Text);
                    Session.Add("AcumRepuesto", acum);
                }

                txtPrecioAcumulativoRepuestos.Text = Convert.ToDouble(acum).ToString();

                if (acum > 0)
                {
                    //GUARDAR EN LA TABLA REPUESTOS X REPARACIONES
                    rep.id = Convert.ToInt32(txtIDReparacion.Text);
                    rp.id = Convert.ToInt32(txtIDRepuesto.Text);
                    repn.Repuestos_x_reparaciones(rep, rp);
                }
            }

        
        }

        protected void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            if (acum == 0)
            {
                ManoObra = Convert.ToDouble(txtPrecioManoObra.Text);
                acumTotal = 0 + ManoObra;
                Session.Add("PresupuestoTotal", acumTotal);
                txtPrecioTotal.Text = Convert.ToDouble(acumTotal).ToString();
                btnFinalizarOrden.Enabled = true;
            }
            else
            {
                ManoObra = Convert.ToDouble(txtPrecioManoObra.Text);
                acumTotal = acum + ManoObra;
                Session.Add("PresupuestoTotal", acumTotal);
                txtPrecioTotal.Text = Convert.ToDouble(acumTotal).ToString();
                btnFinalizarOrden.Enabled = true;
            }
        }

        protected void btnFinalizarOrden_Click(object sender, EventArgs e)
        {
            Reparaciones rp = new Reparaciones();
            ReparacionesNegocio rpn = new ReparacionesNegocio();

            rp.id = Convert.ToInt32(txtIDReparacion.Text);
            rp.informe = txtInforme.Text;
            rp.presupuesto = Convert.ToSingle(txtPrecioTotal.Text);

            rpn.FinalizarReparacion(rp);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('REPARACION FINALIZADA');window.location ='MenuPrincipal.aspx';", true);
        }
    }
}