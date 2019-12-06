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
            datos.setearQuery("SELECT ID, MARCA, MODELO FROM EQUIPOS WHERE NUMEROSERIE = @sn");
            datos.agregarParametro("sn", aux);
            //EJECUTO EL LECTOR
            datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)

            while (datos.lector.Read())
            {
                eq.id = Convert.ToInt32(datos.lector["ID"]);
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
                data.prepareStatement("insert into equipos values (@numeroserie , @marca , @modelo)");
                //data.agregarParametro("@id",aux.id);
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

            datos.setearQuery("select id, numeroserie from equipos where NUMEROSERIE = @NUMEROSERIE");
            datos.agregarParametro("NUMEROSERIE", sn);
            datos.ejecutarLector();
            if (datos.lector.Read())
            {
                eq.id = datos.lector.GetInt32(0);
                eq.numeroserie = datos.lector.GetString(1);
            }
            else
            {
                eq = null;
            }
            return eq;
        }
        public int BuscarIDEquipo()
        {
            AccesoDatos datos = new AccesoDatos();
            int orden = 0;
            try
            {
                //datos.setearQuery("SELECT TOP 1 ORDEN FROM REPARACIONES ORDER BY ORDEN DESC");
                datos.setearQuery("SELECT TOP 1 ID FROM EQUIPOS ORDER BY ID DESC");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    orden = datos.lector.GetInt32(0);
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

        public List<Equipos> listar()
        {
            //INSTANCIO LA LISTA
            List<Equipos> lista = new List<Equipos>();
            //DECLARO EL OBJETO
            Equipos aux;
            //INSTANCIO LA CONECCION A LA BASE
            AccesoDatos datos = new AccesoDatos();
            //TIRO LA QUERY
            datos.setearQuery("SELECT NUMEROSERIE, MARCA, MODELO FROM EQUIPOS");
            //EJECUTO EL LECTOR
            datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)
            while (datos.lector.Read())
            {
                aux = new Equipos();

                aux.numeroserie = datos.lector["NUMEROSERIE"].ToString();
                aux.marca = datos.lector["MARCA"].ToString();
                aux.modelo = datos.lector["MODELO"].ToString();

                lista.Add(aux);
            }
            return lista;
            //datos.cerrarConexion();
        }

    }
}
