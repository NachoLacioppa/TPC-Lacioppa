using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using System.Data.SqlClient;

namespace NEGOCIO
{
    public class ClienteNegocio
    {
        //FUNCION PARA LISTAR LOS DATOS DE LA BBDD
        public List<Clientes> listar()
        {
            //INSTANCIO LA LISTA
            List<Clientes> lista = new List<Clientes>();
            //DECLARO EL OBJETO
            Clientes aux;
            //INSTANCIO LA CONECCION A LA BASE
            AccesoDatos datos = new AccesoDatos();
            //TIRO LA QUERY
            datos.setearQuery("select nombre, apellido, dni, direccion, localidad, telefono, mail from Clientes");
            //EJECUTO EL LECTOR
            datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)

            while (datos.lector.Read())
            {
                aux = new Clientes();
               
                    aux.nombre = datos.lector["Nombre"].ToString();
                    aux.apellido = datos.lector["Apellido"].ToString();
                    aux.dni = datos.lector["DNI"].ToString();
                    aux.direccion = datos.lector["Direccion"].ToString();
                    aux.localidad = datos.lector["Localidad"].ToString();
                    aux.telefono = datos.lector["Telefono"].ToString();
                    aux.mail = datos.lector["Mail"].ToString();

                    lista.Add(aux);
                

            }
            return lista;
            //datos.cerrarConexion();
        }
        public bool altaCliente(Clientes aux)
        {

            AccesoDatos data = new AccesoDatos();
            data.prepareStatement("" +
                "INSERT INTO Clientes VALUES ('" + aux.nombre + "', '" + aux.apellido + "', '" + aux.dni + "', '" + aux.direccion + "', '" + aux.localidad + "', '" + aux.telefono + "', '" + aux.mail + "', 1)");
            data.ejecutarAccion();
            data.cerrarConexion();

            if (data.getAffectedRows() <= 0)
            {
                return false;
            }
            else return true;
        }
        public bool bajaCliente(Clientes aux)
        {
            AccesoDatos data = new AccesoDatos();
            data.prepareStatement("update clientes set estado = 0 where DNI = '" + aux.dni + "'");
            data.ejecutarAccion();
            data.cerrarConexion();

            if (data.getAffectedRows() <= 0)
            {
                return false;
            }
            return true;
        }

        public Clientes ValidarDNI (string dnicliente)
        {
            AccesoDatos datos = new AccesoDatos();
            Clientes cli = new Clientes();

            datos.setearQuery("Select dni, estado from Clientes where dni = @dni");
            datos.agregarParametro("dni", dnicliente);
            datos.ejecutarLector();
            if (datos.lector.Read())
            {
                cli.dni = datos.lector.GetString(0);
                cli.estado = datos.lector.GetBoolean(1);
            }
            else
            {
                cli = null;
            }
            return cli;
        } 
    }
}
