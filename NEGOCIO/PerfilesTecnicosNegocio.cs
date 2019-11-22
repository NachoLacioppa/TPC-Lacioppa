using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
   public class PerfilesTecnicosNegocio
    {
        public List<PerfilesTecnicos> listarPerfiles()
        {
            //INSTANCIO LA LISTA
            List<PerfilesTecnicos> lista = new List<PerfilesTecnicos>();
            //DECLARO EL OBJETO
            PerfilesTecnicos aux;
            //INSTANCIO LA CONECCION A LA BASE
            AccesoDatos datos = new AccesoDatos();
            //TIRO LA QUERY
            datos.setearQuery("select nombre, id from PERFILES_TECNICOS where estado = 1");
            //EJECUTO EL LECTOR
            datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)

            while (datos.lector.Read())
            {
                aux = new PerfilesTecnicos();

                aux.id = Convert.ToInt32(datos.lector["id"]);
                aux.nombre = datos.lector["Nombre"].ToString();


                lista.Add(aux);

            }
            return lista;
            //datos.cerrarConexion();
        }
        public bool altaPerfilTecnico(PerfilesTecnicos aux)
        {

            AccesoDatos data = new AccesoDatos();
            data.prepareStatement("INSERT INTO PERFILES_TECNICOS VALUES (@NOMBRE,1)");
            data.agregarParametro("@nombre", aux.nombre);
            data.ejecutarAccion();
            data.cerrarConexion();

            if (data.getAffectedRows() <= 0)
            {
                return false;
            }
            else return true;
        }

    }
}
