using System;
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
            datos.setearQuery("SELECT t.USUARIO, t.NOMBRE,t.APELLIDO,t.DNI, pt.NOMBRE AS 'PERFIL' from TECNICOS as t inner join PERFILES_TECNICOS as pt on pt.id = t.id where t.ESTADO = 1");
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
                aux.perfil.nombre = datos.lector["perfil"].ToString();
                lista.Add(aux);
            }
            return lista;
            //datos.cerrarConexion();
        }
    }
}
