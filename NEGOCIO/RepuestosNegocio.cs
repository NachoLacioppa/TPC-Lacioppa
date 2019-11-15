using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using NEGOCIO;

namespace NEGOCIO
{
   public class RepuestosNegocio
    {
        public List<Repuestos> listarRepuestos()
        {
            //INSTANCIO LA LISTA
            List<Repuestos> lista = new List<Repuestos>();
            //DECLARO EL OBJETO
            Repuestos aux;
            //INSTANCIO LA CONECCION A LA BASE
            AccesoDatos datos = new AccesoDatos();
            //TIRO LA QUERY
            //datos.setearQuery("select codigo, nombre, cantidad, precio from repuestos where estado = 1");
            datos.setearQuery("select r.CODIGO,r.NOMBRE,r.CANTIDAD,r.PRECIO,cr.NOMBRE as 'CATEGORIA' from REPUESTOS as r inner join CATEGORIAS_REPUESTOS as cr on Cr.iD = R.IDCATEGORIA where r.ESTADO = 1");
            //EJECUTO EL LECTOR
            datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)

            while (datos.lector.Read())
            {
                aux = new Repuestos();

                aux.codigo = Convert.ToInt64(datos.lector["Codigo"].ToString());
                aux.nombre = datos.lector["Nombre"].ToString();
                aux.cantidad = Convert.ToInt32(datos.lector["Cantidad"].ToString());
                aux.precio = Convert.ToSingle(datos.lector["Precio"].ToString());
                aux.categoria = new CategoriaRepuestos();
                aux.categoria.nombre = datos.lector["CATEGORIA"].ToString();
                lista.Add(aux);
            }
            return lista;
            //datos.cerrarConexion();
        }
        public bool altaRepuesto(Repuestos aux)
        {
            AccesoDatos data = new AccesoDatos();
            try
            {
                data.prepareStatement("insert into repuestos values (@codigo, @nombre, @cantidad, @precio, @idcategoria, 1)");
                data.agregarParametro("@codigo", aux.codigo);
                data.agregarParametro("@nombre", aux.nombre);
                data.agregarParametro("@cantidad", aux.cantidad);
                data.agregarParametro("@precio", aux.precio);
                data.agregarParametro("@idcategoria", aux.categoria.id);

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
    }
}
