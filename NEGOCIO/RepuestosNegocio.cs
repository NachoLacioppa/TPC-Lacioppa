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

                aux.codigo = datos.lector["Codigo"].ToString();
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
        public bool bajaRepuestos(Repuestos aux)
        {
            AccesoDatos data = new AccesoDatos();
            data.prepareStatement("update repuestos set estado = 0 where codigo = '" + aux.codigo + "'");
            data.ejecutarAccion();
            data.cerrarConexion();

            if (data.getAffectedRows() <= 0)
            {
                return false;
            }
            return true;
        }
        public Repuestos ValidarCodigo(string cod)
        {
            AccesoDatos datos = new AccesoDatos();
            Repuestos re = new Repuestos();

            datos.setearQuery("Select codigo, estado from Repuestos where codigo = @codigo");
            datos.agregarParametro("codigo", cod);
            datos.ejecutarLector();
            if (datos.lector.Read())
            {
                re.codigo = datos.lector.GetString(0);
                re.estado = datos.lector.GetBoolean(1);
            }
            else
            {
                re = null;
            }
            return re;
        }
        public Repuestos BuscarCodigo(string aux)
        {
            //INSTANCIO LA LISTA
            List<Repuestos> lista = new List<Repuestos>();
            //DECLARO EL OBJETO
            Repuestos re = new Repuestos();
            //INSTANCIO LA CONECCION A LA BASE
            AccesoDatos datos = new AccesoDatos();
            //TIRO LA QUERY
            datos.setearQuery("select codigo, nombre, cantidad, precio, idcategoria, estado from Repuestos where estado = 1 and codigo = '" + aux + "'");
            //EJECUTO EL LECTOR
            datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)

            while (datos.lector.Read())
            {
                re.codigo = datos.lector["Codigo"].ToString();
                re.nombre = datos.lector["Nombre"].ToString();
                re.cantidad = Convert.ToInt32(datos.lector["Cantidad"].ToString());
                re.precio = Convert.ToSingle(datos.lector["Precio"].ToString());
                re.categoria = new CategoriaRepuestos();
                re.categoria.id = Convert.ToInt32(datos.lector["idCategoria"].ToString());
                re.estado = Convert.ToBoolean(datos.lector["Estado"].ToString());
            }
            return re;
        }
        public bool ModificarRepuesto(Repuestos aux)
        {
            AccesoDatos data = new AccesoDatos();
            data.prepareStatement("update repuestos set codigo = @codigo, nombre = @nombre, cantidad = @cantidad, precio = @precio, idcategoria = @idcategoria where codigo = '" + aux.codigo + "'");
            data.agregarParametro("codigo", aux.codigo);
            data.agregarParametro("nombre", aux.nombre);
            data.agregarParametro("cantidad", aux.cantidad);
            data.agregarParametro("precio", aux.precio);
            data.agregarParametro("idcategoria", aux.categoria.id);
            
            data.ejecutarAccion();
            data.cerrarConexion();

            if (data.getAffectedRows() <= 0)
            {
                return false;
            }
            return true;
        }
        public List<Repuestos> listarRepuestoStock(string aux)
        {
            //INSTANCIO LA LISTA
            List<Repuestos> lista = new List<Repuestos>();
            //DECLARO EL OBJETO
            Repuestos re = new Repuestos();
            //INSTANCIO LA CONECCION A LA BASE
            AccesoDatos datos = new AccesoDatos();
            //TIRO LA QUERY
            datos.setearQuery("select CODIGO, NOMBRE, CANTIDAD from Repuestos where estado = 1 and codigo = '" + aux + "'");
            //EJECUTO EL LECTOR
            datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)

            while (datos.lector.Read())
            {
                re.codigo = datos.lector["Codigo"].ToString();
                re.nombre = datos.lector["Nombre"].ToString();
                re.cantidad = Convert.ToInt32(datos.lector["Cantidad"].ToString());

                lista.Add(re);

            }
            return lista;
        }

    }
}
