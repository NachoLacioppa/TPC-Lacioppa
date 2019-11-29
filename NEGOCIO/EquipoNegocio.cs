using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class EquipoNegocio
    {
        public Equipos BuscarCodigo(string aux)
        {
            //INSTANCIO LA LISTA
            List<Equipos> lista = new List<Equipos>();
            //DECLARO EL OBJETO
            Equipos eq = new Equipos();
            //INSTANCIO LA CONECCION A LA BASE
            AccesoDatos datos = new AccesoDatos();
            //TIRO LA QUERY
            datos.setearQuery("SELECT MARCA, MODELO FROM EQUIPOS WHERE NUMEROSERIE = " + "'" + aux + "'");
            //EJECUTO EL LECTOR
            datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)

            while (datos.lector.Read())
            {
                eq.marca = datos.lector["MARCA"].ToString();
                eq.modelo = datos.lector["MODELO"].ToString();
            }
            return eq;
        }
        public bool altaEquipo(Equipos aux)
        {
            AccesoDatos data = new AccesoDatos();
            try
            {
                data.prepareStatement("insert into equipos values (numeroserie = @numeroserie , marca = @marca , modelo = @modelo)");
                data.agregarParametro("@numeroserie", aux.numeroserie);
                data.agregarParametro("@marca", aux.marca);
                data.agregarParametro("@modelo", aux.modelo);
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
        public Equipos ValidarSN(string sn)
        {
            AccesoDatos datos = new AccesoDatos();
            Equipos eq = new Equipos();

            datos.setearQuery("select numeroserie from equipos where NUMEROSERIE = @NUMEROSERIE");
            datos.agregarParametro("NUMEROSERIE", sn);
            datos.ejecutarLector();
            if (datos.lector.Read())
            {
                eq.numeroserie = datos.lector.GetString(0);
            }
            else
            {
                eq = null;
            }
            return eq;
        }
    }
}
