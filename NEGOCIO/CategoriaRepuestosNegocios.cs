using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;


namespace NEGOCIO
{
    public class CategoriaRepuestosNegocios
    {
        public List<CategoriaRepuestos> listarCategorias()
        {
            //INSTANCIO LA LISTA
            List<CategoriaRepuestos> lista = new List<CategoriaRepuestos>();
            //DECLARO EL OBJETO
            CategoriaRepuestos aux;
            //INSTANCIO LA CONECCION A LA BASE
            AccesoDatos datos = new AccesoDatos();
            //TIRO LA QUERY
            datos.setearQuery("select nombre from CATEGORIAS_REPUESTOS where estado = 1");
            //EJECUTO EL LECTOR
            datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)

            while (datos.lector.Read())
            {
                aux = new CategoriaRepuestos();

                aux.nombre = datos.lector["Nombre"].ToString();

                lista.Add(aux);

            }
            return lista;
            //datos.cerrarConexion();
        }
        public bool altaCategoriaRepuesto(CategoriaRepuestos aux)
        {

            AccesoDatos data = new AccesoDatos();
            data.prepareStatement("INSERT INTO CATEGORIAS_REPUESTOS VALUES (@NOMBRE,1)");
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
