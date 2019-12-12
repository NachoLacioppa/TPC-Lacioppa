﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class TecnicoNegocio
    {
        public List<Tecnicos> listarTecnicos()
        {
            //INSTANCIO LA LISTA
            List<Tecnicos> lista = new List<Tecnicos>();
            //DECLARO EL OBJETO
            Tecnicos aux;
            //INSTANCIO LA CONECCION A LA BASE
            AccesoDatos datos = new AccesoDatos();
            //TIRO LA QUERY
            //datos.setearQuery("select codigo, nombre, cantidad, precio from repuestos where estado = 1");
            datos.setearQuery("SELECT t.USUARIO, t.NOMBRE, t.APELLIDO, t.DNI, pt.NOMBRE AS 'PERFIL' from TECNICOS as t inner join PERFILES_TECNICOS as pt on pt.id = t.id where t.ESTADO = 1");
            //EJECUTO EL LECTOR
            datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)

            while (datos.lector.Read())
            {
                aux = new Tecnicos();

                aux.usuario = datos.lector["Usuario"].ToString();
                aux.nombre = datos.lector["Nombre"].ToString();
                aux.apellido = datos.lector["Apellido"].ToString();
                aux.dni = datos.lector["DNI"].ToString();
                aux.perfil = new PerfilesTecnicos();
                aux.perfil.nombre = datos.lector["PERFIL"].ToString();
                lista.Add(aux);
            }
            return lista;
            //datos.cerrarConexion();
        }
        public bool altaTecnico(Tecnicos aux)
        {
            AccesoDatos data = new AccesoDatos();
            try
            {
                data.prepareStatement("insert into Tecnicos values (@usuario, @contraseña, @idperfil, @nombre, @apellido, @dni, @sueldo, 1)");
                data.agregarParametro("usuario", aux.usuario);
                data.agregarParametro("contraseña", aux.contraseña);
                data.agregarParametro("idperfil", aux.perfil.id);
                data.agregarParametro("nombre", aux.nombre);
                data.agregarParametro("apellido", aux.apellido);
                data.agregarParametro("dni", aux.dni);
                data.agregarParametro("sueldo", aux.sueldo);

                data.ejecutarAccion();

                if (data.getAffectedRows() <= 0)
                {
                    return false;
                }
                else return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                data.cerrarConexion();
            }

        }
        public bool bajaTecnicos(Tecnicos aux)
        {
            AccesoDatos data = new AccesoDatos();
            data.prepareStatement("update tecnicos set estado = 0 where usuario = '" + aux.usuario + "'");
            data.ejecutarAccion();
            data.cerrarConexion();

            if (data.getAffectedRows() <= 0)
            {
                return false;
            }
            return true;
        }
        //VALIDAR DNI
        public Tecnicos ValidarUsuario1(string us)
        {
            AccesoDatos datos = new AccesoDatos();
            Tecnicos re = new Tecnicos();

            datos.setearQuery("Select usuario, dni, estado from tecnicos where DNI = @DNI");
            datos.agregarParametro("DNI", us);
            datos.ejecutarLector();
            if (datos.lector.Read())
            {
                re.usuario = datos.lector.GetString(0);
                re.dni = datos.lector.GetString(1);
                re.estado = datos.lector.GetBoolean(2);
            }
            else
            {
                re = null;
            }
            return re;
        }

        //VALIDAR USUARIO
        public Tecnicos ValidarUsuario2(string us)
        {
            AccesoDatos datos = new AccesoDatos();
            Tecnicos re = new Tecnicos();

            datos.setearQuery("Select usuario, dni, estado from tecnicos where usuario = @usuario");
            datos.agregarParametro("usuario", us);
            datos.ejecutarLector();
            if (datos.lector.Read())
            {
                re.usuario = datos.lector.GetString(0);
                re.dni = datos.lector.GetString(1);
                re.estado = datos.lector.GetBoolean(2);
            }
            else
            {
                re = null;
            }
            return re;
        }


        public Tecnicos BuscarUsuario(string aux)
        {
            //INSTANCIO LA LISTA
            List<Tecnicos> lista = new List<Tecnicos>();
            //DECLARO EL OBJETO
            Tecnicos tec = new Tecnicos();
            //INSTANCIO LA CONECCION A LA BASE
            AccesoDatos datos = new AccesoDatos();
            //TIRO LA QUERY
            datos.setearQuery("select usuario, nombre, apellido, dni, sueldo, idperfil from Tecnicos where estado = 1 and dni = '" + aux + "'");
            //EJECUTO EL LECTOR
            datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)

            while (datos.lector.Read())
            {
                tec.usuario = datos.lector["Usuario"].ToString();
                tec.nombre = datos.lector["Nombre"].ToString();
                tec.apellido = datos.lector["Apellido"].ToString();
                tec.dni = datos.lector["DNI"].ToString();
                tec.sueldo = Convert.ToSingle(datos.lector["sueldo"]);
                tec.perfil = new PerfilesTecnicos();
                tec.perfil.id = Convert.ToInt32(datos.lector["idperfil"]);

            }
            return tec;
        }
        public bool ModificarTecnicos(Tecnicos aux)
        {
            AccesoDatos data = new AccesoDatos();
            data.prepareStatement("update TECNICOS set usuario = @usuario, nombre = @nombre, apellido = @apellido, dni = @dni, sueldo = @sueldo, idperfil = @idperfil where dni = '" + aux.dni + "'");
            data.agregarParametro("@usuario", aux.usuario);
            data.agregarParametro("@nombre", aux.nombre);
            data.agregarParametro("@apellido", aux.apellido);
            data.agregarParametro("@dni", aux.dni);
            data.agregarParametro("@sueldo", aux.sueldo);
            data.agregarParametro("@idperfil", aux.perfil.id);

            data.ejecutarAccion();
            data.cerrarConexion();

            if (data.getAffectedRows() <= 0)
            {
                return false;
            }
            return true;
        }
        public List<Tecnicos> listarUsers()
        {
            //INSTANCIO LA LISTA
            List<Tecnicos> lista = new List<Tecnicos>();
            //DECLARO EL OBJETO
            Tecnicos aux;
            //INSTANCIO LA CONECCION A LA BASE
            AccesoDatos datos = new AccesoDatos();
            //TIRO LA QUERY
            //datos.setearQuery("select codigo, nombre, cantidad, precio from repuestos where estado = 1");
            datos.setearQuery("select ID , USUARIO from TECNICOS where ESTADO = 1");
            //EJECUTO EL LECTOR
            datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)

            while (datos.lector.Read())
            {
                aux = new Tecnicos();

                aux.usuario = datos.lector["Usuario"].ToString();
                aux.ID = Convert.ToInt32(datos.lector["ID"]);

                lista.Add(aux);
            }
            return lista;
        }

        public Tecnicos ValidarUser(string user, string pass)
        {
            AccesoDatos datos = new AccesoDatos();
            Tecnicos tec = new Tecnicos();

            datos.setearQuery("select id ,usuario, contraseña, idperfil from Tecnicos where usuario = @user and contraseña = @pass");
            datos.agregarParametro("@user", user);
            datos.agregarParametro("@pass", pass);
            datos.ejecutarLector();
            if (datos.lector.Read())
            {
                tec.ID = Convert.ToInt32(datos.lector["id"]);
                tec.usuario = datos.lector["usuario"].ToString();
                tec.contraseña = datos.lector["contraseña"].ToString();
                tec.perfil = new PerfilesTecnicos();
                tec.perfil.id = Convert.ToInt32(datos.lector["idperfil"]);
            }
            else
            {
                tec = null;
            }
            return tec;
        }
    }
}
