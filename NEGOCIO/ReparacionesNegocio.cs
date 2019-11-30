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

        //public Equipos ValidarSN(string sn)
        //{
        //    AccesoDatos datos = new AccesoDatos();
        //    Equipos eq = new Equipos();

        //    datos.setearQuery("select numeroserie from equipos where NUMEROSERIE = @NUMEROSERIE");
        //    datos.agregarParametro("NUMEROSERIE", sn);
        //    datos.ejecutarLector();
        //    if (datos.lector.Read())
        //    {
        //        eq.numeroserie = datos.lector.GetString(0);
        //    }
        //    else
        //    {
        //        eq = null;
        //    }
        //    return eq;
        //}

    }
}
