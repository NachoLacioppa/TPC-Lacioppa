﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMINIO;
using NEGOCIO;

namespace TP3_LACIOPPA
{
    public partial class ModificarRepuestos : System.Web.UI.Page
    {
        int validacion = 0;
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
                validacion = (int)Session["PerfilTecnico"];
                if (validacion == 3)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO TIENE PERMISO');window.location ='MenuPrincipal.aspx';", true);
                }
                if (!IsPostBack)
                {
                    CategoriaRepuestosNegocios negocio = new CategoriaRepuestosNegocios();
                    dwCategorias.DataTextField = "nombre";
                    dwCategorias.DataValueField = "id";
                    dwCategorias.DataSource = negocio.listarCategorias();
                    dwCategorias.DataBind();
                }
            }
           
        }

        protected void btnBuscarRepuesto_Click(object sender, EventArgs e)
        {
            RepuestosNegocio ren = new RepuestosNegocio();
            Repuestos re = new Repuestos();

            re = ren.BuscarCodigo(txtBuscarRepuesto.Text);


            txtcod.Text = re.codigo;
            txtnombre.Text = re.nombre;
            //txtcantidad.Text = re.cantidad.ToString();
            txtprecio.Text = re.precio.ToString();
            dwCategorias.SelectedItem.Value = re.categoria.id.ToString();

        }

        protected void btnModificarRepuesto_Click(object sender, EventArgs e)
        {
            Repuestos re = new Repuestos();
            RepuestosNegocio ren = new RepuestosNegocio();

            if (string.IsNullOrEmpty(txtcod.Text))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('CODIGO NULO');window.location ='ModificarRepuestos.aspx';", true);
            }

            re.codigo = txtcod.Text;
            re.nombre = txtnombre.Text;
            //re.cantidad = Convert.ToInt32(txtcantidad.Text);
            re.precio = Convert.ToSingle(txtprecio.Text);
            re.categoria = new CategoriaRepuestos();
            re.categoria.id = Convert.ToInt32(dwCategorias.SelectedItem.Value);

            ren.ModificarRepuesto(re);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('REPUESTO MODIFICADO');window.location ='MenuPrincipal.aspx';", true);
        }
    }
}