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
    public partial class ModificarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscarClienteMod_Click(object sender, EventArgs e)
        {
            ClienteNegocio clin = new ClienteNegocio();
            Clientes cli = new Clientes();

            cli = clin.BuscarDNI(txtBuscarMod.Text);

            txtnombre.Text = cli.nombre;
            txtApellido.Text = cli.apellido;
            txtDNI.Text = cli.dni;
            txtDireccion.Text = cli.direccion;
            txtLocalidad.Text = cli.localidad;
            txtTelefono.Text = cli.telefono;
            txtMail.Text = cli.mail;

        }

        protected void btnModificarCliente_Click(object sender, EventArgs e)
        {

        }

        
    }
}