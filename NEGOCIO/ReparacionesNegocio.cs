using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class ReparacionesNegocio
    {
        public long BuscarOrden()
        {
            AccesoDatos datos = new AccesoDatos();
            long orden = 0;
            try
            {
                //datos.setearQuery("SELECT TOP 1 ORDEN FROM REPARACIONES ORDER BY ORDEN DESC");
                datos.setearQuery("SELECT TOP 1 ORDEN FROM REPARACIONES ORDER BY ORDEN DESC");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    orden = datos.lector.GetInt64(0);
                }
                return orden + 1;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public bool NuevaReparacion(Reparaciones aux)
        {
            AccesoDatos data = new AccesoDatos();
            try
            {

                data.prepareStatement("insert into REPARACIONES values (@orden, @idcliente, @idequipo, @idtecnico, 1, @problema, @fecha_entrada , null, null, null)");
                data.agregarParametro("@orden", aux.orden);
                data.agregarParametro("@idcliente", aux.cliente.id);
                data.agregarParametro("@idequipo", aux.equipo.id);
                data.agregarParametro("@idtecnico", aux.tecnico.ID);
                data.agregarParametro("@problema", aux.problema);
                aux.fecha_entrada = DateTime.Now;
                data.agregarParametro("@fecha_entrada", aux.fecha_entrada);
 
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
        public bool Repuestos_x_reparaciones(Reparaciones repa, Repuestos repu)
        {
            AccesoDatos data = new AccesoDatos();
            try
            {

                data.prepareStatement("insert into REPUESTOS_POR_REPARACIONES values (@idreparaciones, @idrepuesto)");
                data.agregarParametro("@idreparaciones", repa.id);
                data.agregarParametro("@idrepuesto", repu.id);

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

            public bool FinalizarReparacion(Reparaciones aux)
            {
            AccesoDatos data = new AccesoDatos();
            data.prepareStatement("update reparaciones set idestado = 2, informe = @informe, precio = @precio, fecha_salida = @fecha_salida where id = @aux");
            //data.agregarParametro("cantidad", aux.cantidad);
            data.agregarParametro("@aux", aux.id);
            data.agregarParametro("@informe", aux.informe);
            data.agregarParametro("@precio", aux.presupuesto);
            aux.fecha_salida = DateTime.Now;
            data.agregarParametro("@fecha_salida", aux.fecha_salida);
           
            data.ejecutarAccion();
            data.cerrarConexion();

            if (data.getAffectedRows() <= 0)
            {
                return false;
            }
            return true;
        }


        //BUSCA EL EQUIPO Y EL TECNICO
        public Reparaciones BuscarReparacion2(string aux)
        {
            //INSTANCIO LA LISTA
            List<Reparaciones> lista = new List<Reparaciones>();
            //DECLARO EL OBJETO
            Reparaciones rep = new Reparaciones();
            //INSTANCIO LA CONECCION A LA BASE
            AccesoDatos datos = new AccesoDatos();
            //TIRO LA QUERY
            datos.setearQuery("SELECT R.ID, R.ORDEN, CLI.NOMBRE, CLI.APELLIDO, CLI.TELEFONO, EQ.NUMEROSERIE AS 'NUMERO DE SERIE' ,EQ.MARCA, EQ.MODELO, TEC.USUARIO AS 'TECNICO', R.FECHA_ENTRADA AS 'ENTRADA', R.PROBLEMA, ER.NOMBRE AS 'ESTADO' FROM REPARACIONES AS R INNER JOIN CLIENTES AS CLI ON R.IDCLIENTE = CLI.ID INNER JOIN EQUIPOS AS EQ ON R.IDEQUIPO = EQ.ID INNER JOIN TECNICOS AS TEC ON R.IDTECNICO = TEC.ID INNER JOIN ESTADOS_REPARACION AS ER ON R.IDESTADO = ER.ID WHERE R.IDESTADO = 1 AND R.ORDEN = @AUX");
            datos.agregarParametro("@AUX",aux);
            //EJECUTO EL LECTOR
            datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)

            while (datos.lector.Read())
            {
                rep.cliente = new Clientes();
                rep.cliente.nombre = datos.lector["NOMBRE"].ToString();
                rep.cliente.apellido = datos.lector["APELLIDO"].ToString();
                rep.cliente.telefono = datos.lector["TELEFONO"].ToString();

                rep.equipo = new Equipos();
                rep.equipo.numeroserie = datos.lector["NUMERO DE SERIE"].ToString();
                rep.equipo.marca = datos.lector["MARCA"].ToString();
                rep.equipo.modelo = datos.lector["MODELO"].ToString();

                rep.tecnico = new Tecnicos();
                rep.tecnico.usuario = datos.lector["TECNICO"].ToString();

                rep.fecha_entrada = Convert.ToDateTime(datos.lector["ENTRADA"]);
                rep.problema = datos.lector["PROBLEMA"].ToString();
                rep.id = Convert.ToInt32(datos.lector["ID"]);

                rep.estados = new EstadosReparacion();
                rep.estados.nombre = datos.lector["ESTADO"].ToString();
                
            }
            return rep;

        }
        public Reparaciones BuscarReparacion_ESPESIFICA_REPARACION(string aux)
        {
            //INSTANCIO LA LISTA
            List<Reparaciones> lista = new List<Reparaciones>();
            //DECLARO EL OBJETO
            Reparaciones rep = new Reparaciones();
            //INSTANCIO LA CONECCION A LA BASE
            AccesoDatos datos = new AccesoDatos();
            //TIRO LA QUERY
            datos.setearQuery("select r.id, r.orden, cli.nombre, cli.apellido, cli.telefono, eq.numeroserie, eq.marca, eq.modelo, tec.usuario, r.fecha_entrada, r.problema, r.idestado from reparaciones as r INNER JOIN CLIENTES AS CLI ON R.IDCLIENTE = CLI.ID INNER JOIN EQUIPOS AS EQ ON R.IDEQUIPO = EQ.ID INNER JOIN TECNICOS AS TEC ON R.IDTECNICO = TEC.ID where r.orden = @AUX");
            datos.agregarParametro("@AUX", aux);
            //EJECUTO EL LECTOR
            datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)

            while (datos.lector.Read())
            {
                rep.fecha_entrada = Convert.ToDateTime(datos.lector["fecha_entrada"]);
                rep.problema = datos.lector["PROBLEMA"].ToString();
                rep.id = Convert.ToInt32(datos.lector["ID"]);
                rep.orden = Convert.ToInt32(datos.lector["ORDEN"]);

                rep.cliente = new Clientes();
                rep.cliente.nombre = datos.lector["NOMBRE"].ToString();
                rep.cliente.apellido = datos.lector["APELLIDO"].ToString();
                rep.cliente.telefono = datos.lector["TELEFONO"].ToString();

                rep.equipo = new Equipos();
                rep.equipo.numeroserie = datos.lector["numeroserie"].ToString();
                rep.equipo.marca = datos.lector["MARCA"].ToString();
                rep.equipo.modelo = datos.lector["MODELO"].ToString();

                rep.tecnico = new Tecnicos();
                rep.tecnico.usuario = datos.lector["usuario"].ToString();

                rep.estados = new EstadosReparacion();
                rep.estados.id = Convert.ToInt32(datos.lector["idestado"]);

            }
            return rep;
        }

        public Reparaciones BuscarReparacion_ESPESIFICA_FINALIZADO(string aux)
        {
            //INSTANCIO LA LISTA
            List<Reparaciones> lista = new List<Reparaciones>();
            //DECLARO EL OBJETO
            Reparaciones rep = new Reparaciones();
            //INSTANCIO LA CONECCION A LA BASE
            AccesoDatos datos = new AccesoDatos();
            //TIRO LA QUERY
            datos.setearQuery("SELECT R.ID, R.ORDEN, CLI.NOMBRE, CLI.APELLIDO, CLI.TELEFONO, EQ.NUMEROSERIE, EQ.MARCA,EQ.MODELO, TEC.USUARIO, R.FECHA_ENTRADA, R.PROBLEMA, R.IDESTADO, R.PRECIO, R.FECHA_SALIDA, R.INFORME FROM REPARACIONES AS R INNER JOIN CLIENTES AS CLI ON R.IDCLIENTE = CLI.ID INNER JOIN EQUIPOS AS EQ ON R.IDEQUIPO = EQ.ID INNER JOIN TECNICOS AS TEC ON R.IDTECNICO = TEC.ID WHERE R.IDESTADO = 2 AND R.ORDEN = @AUX");
            datos.agregarParametro("@AUX", aux);
            //EJECUTO EL LECTOR
            datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)

            while (datos.lector.Read())
            {
                rep.fecha_entrada = Convert.ToDateTime(datos.lector["fecha_entrada"]);
                rep.problema = datos.lector["PROBLEMA"].ToString();
                rep.informe = datos.lector["INFORME"].ToString();
                rep.presupuesto = Convert.ToSingle(datos.lector["precio"]);
                rep.fecha_salida = Convert.ToDateTime(datos.lector["fecha_salida"]);
                rep.id = Convert.ToInt32(datos.lector["ID"]);
                rep.orden = Convert.ToInt32(datos.lector["ORDEN"]);

                rep.cliente = new Clientes();
                rep.cliente.nombre = datos.lector["NOMBRE"].ToString();
                rep.cliente.apellido = datos.lector["APELLIDO"].ToString();
                rep.cliente.telefono = datos.lector["TELEFONO"].ToString();

                rep.equipo = new Equipos();
                rep.equipo.numeroserie = datos.lector["numeroserie"].ToString();
                rep.equipo.marca = datos.lector["MARCA"].ToString();
                rep.equipo.modelo = datos.lector["MODELO"].ToString();

                rep.tecnico = new Tecnicos();
                rep.tecnico.usuario = datos.lector["usuario"].ToString();

                rep.estados = new EstadosReparacion();
                rep.estados.id = Convert.ToInt32(datos.lector["idestado"]);

            }
            return rep;
        }

        //LISTA REPARACIONES FINALIZADAS
        public List<Reparaciones> listarRep2()
            {
            //INSTANCIO LA LISTA
            List<Reparaciones> lista = new List<Reparaciones>();
            //DECLARO EL OBJETO
            Reparaciones aux;
            //INSTANCIO LA CONECCION A LA BASE
            AccesoDatos datos = new AccesoDatos();
            //TIRO LA QUERY
            datos.setearQuery("SELECT R.ORDEN, CLI.NOMBRE, CLI.APELLIDO, CLI.TELEFONO, EQ.MARCA, EQ.MODELO, R.PROBLEMA, R.INFORME, R.FECHA_ENTRADA, R.FECHA_SALIDA FROM REPARACIONES AS R INNER JOIN CLIENTES AS CLI ON R.IDCLIENTE = CLI.ID INNER JOIN ESTADOS_REPARACION AS ER ON R.IDESTADO = ER.ID INNER JOIN EQUIPOS AS EQ ON R.IDEQUIPO = EQ.ID WHERE ER.ID = 2");
            //EJECUTO EL LECTOR
            datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)

            while (datos.lector.Read())
            {
                aux = new Reparaciones();
                aux.cliente = new Clientes();
                aux.equipo = new Equipos();

                aux.orden = Convert.ToInt64(datos.lector["ORDEN"]);
                aux.cliente.nombre = datos.lector["NOMBRE"].ToString();
                aux.cliente.apellido = datos.lector["APELLIDO"].ToString();
                aux.cliente.telefono = datos.lector["TELEFONO"].ToString();
                aux.equipo.marca = datos.lector["MARCA"].ToString();
                aux.equipo.modelo = datos.lector["MODELO"].ToString();
                aux.problema = datos.lector["PROBLEMA"].ToString();
                aux.informe = datos.lector["INFORME"].ToString();
                aux.fecha_entrada = Convert.ToDateTime(datos.lector["FECHA_ENTRADA"]);
                aux.fecha_salida = Convert.ToDateTime(datos.lector["FECHA_SALIDA"]);

                lista.Add(aux);
            }
            return lista;
            //datos.cerrarConexion();
        }


        //LISTA REPARACIONES EN REPARACION
        public List<Reparaciones> listarRep1()
        {
            //INSTANCIO LA LISTA
            List<Reparaciones> lista = new List<Reparaciones>();
            //DECLARO EL OBJETO
            Reparaciones aux;
            //INSTANCIO LA CONECCION A LA BASE
            AccesoDatos datos = new AccesoDatos();
            //TIRO LA QUERY
            datos.setearQuery("SELECT R.ORDEN, CLI.NOMBRE, CLI.APELLIDO, CLI.TELEFONO, EQ.MARCA, EQ.MODELO, R.PROBLEMA, R.FECHA_ENTRADA FROM REPARACIONES AS R INNER JOIN CLIENTES AS CLI ON R.IDCLIENTE = CLI.ID INNER JOIN ESTADOS_REPARACION AS ER ON R.IDESTADO = ER.ID INNER JOIN EQUIPOS AS EQ ON R.IDEQUIPO = EQ.ID WHERE ER.ID = 1");
            //EJECUTO EL LECTOR
            datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)

            while (datos.lector.Read())
            {
                aux = new Reparaciones();
                aux.cliente = new Clientes();
                aux.equipo = new Equipos();

                aux.orden = Convert.ToInt64(datos.lector["ORDEN"]);
                aux.cliente.nombre = datos.lector["NOMBRE"].ToString();
                aux.cliente.apellido = datos.lector["APELLIDO"].ToString();
                aux.cliente.telefono = datos.lector["TELEFONO"].ToString();
                aux.equipo.marca = datos.lector["MARCA"].ToString();
                aux.equipo.modelo = datos.lector["MODELO"].ToString();
                aux.problema = datos.lector["PROBLEMA"].ToString();
                aux.fecha_entrada = Convert.ToDateTime(datos.lector["FECHA_ENTRADA"]);

                lista.Add(aux);
            }
            return lista;
            //datos.cerrarConexion();
        }


        //VALIDA ORDEN EN REPARACION
        public Reparaciones ValidarOrden(string ord)
        {
            AccesoDatos datos = new AccesoDatos();
            Reparaciones re = new Reparaciones();

            datos.setearQuery("select id, idestado, orden from reparaciones where orden = @orden and idestado = 1");
            datos.agregarParametro("@orden", ord);
            datos.ejecutarLector();
            if (datos.lector.Read())
            {
                re.id = datos.lector.GetInt32(0);
                re.estados = new EstadosReparacion();
                re.estados.id = datos.lector.GetInt32(1);
                re.orden = datos.lector.GetInt64(2);
            }
            else
            {
                re = null;
            }
            return re;
        }

        public Reparaciones ValidarOrden1(string ord)
        {
            AccesoDatos datos = new AccesoDatos();
            Reparaciones re = new Reparaciones();

            datos.setearQuery("select id, idestado, orden from reparaciones where orden = @orden and idestado = 2");
            datos.agregarParametro("@orden", ord);
            datos.ejecutarLector();
            if (datos.lector.Read())
            {
                re.id = datos.lector.GetInt32(0);
                re.estados = new EstadosReparacion();
                re.estados.id = datos.lector.GetInt32(1);
                re.orden = datos.lector.GetInt64(2);
            }
            else
            {
                re = null;
            }
            return re;
        }

       
    }
}

