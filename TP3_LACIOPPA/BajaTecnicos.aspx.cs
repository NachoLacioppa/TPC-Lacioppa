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
    public partial class BajaTecnicos : System.Web.UI.Page
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
                if (validacion != 1)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO TIENE PERMISO');window.location ='MenuPrincipal.aspx';", true);
                }
            }
           
        }

        public Tecnicos us;
        protected void btnEliminarTecnico_Click(object sender, EventArgs e)
        {
            TecnicoNegocio tecn = new TecnicoNegocio();

            us = tecn.ValidarUsuario2(txtBuscaTecnico.Text);
            //no existe
            if (us == null)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO EXISTE UN TECNICO CON ESE USUARIO');window.location ='BajaCliente.aspx';", true);
            }
            //ya esta eliminado
            else if (us.estado == false)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('TECNICO YA ELIMINADO');window.location ='BajaCliente.aspx';", true);
            }
            //existe y actualiza estado a cero
            else if (us.estado == true)
            {
                tecn.bajaTecnicos(us);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('TECNICO ELIMINADO!!!');window.location ='BajaCliente.aspx';", true);

            }
        }
    }
}