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
            datos.setearQuery("select nombre, apellido, dni, direccion, localidad, telefono, mail from Clientes where estado = 1");
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

        public Clientes ValidarDNI(string dnicliente)
        {
            AccesoDatos datos = new AccesoDatos();
            Clientes cli = new Clientes();

            datos.setearQuery("Select id, dni, estado from Clientes where dni = @dni and estado = 1");
            datos.agregarParametro("dni", dnicliente);
            datos.ejecutarLector();
            if (datos.lector.Read())
            {
                cli.id = datos.lector.GetInt32(0);
                cli.dni = datos.lector.GetString(1);
                cli.estado = datos.lector.GetBoolean(2);
            }
            else
            {
                cli = null;
            }
            return cli;
        }
        public Clientes BuscarDNI(string aux)
        {
            //INSTANCIO LA LISTA
            List<Clientes> lista = new List<Clientes>();
            //DECLARO EL OBJETO
            Clientes cli = new Clientes();
            //INSTANCIO LA CONECCION A LA BASE
            AccesoDatos datos = new AccesoDatos();
            //TIRO LA QUERY
            datos.setearQuery("select id, nombre, apellido, dni, direccion, localidad, telefono, mail from Clientes where estado = 1 and dni = '" + aux + "'");
            //EJECUTO EL LECTOR
            datos.ejecutarLector();

            //MIENTRAS EL LECTOR LEA, DEVULVE LOS DATOS (DEBE COINSIDIR CON LA QUERY)

            while (datos.lector.Read())
            {

                cli.id = Convert.ToInt32(datos.lector["id"]);
                cli.nombre = datos.lector["Nombre"].ToString();
                cli.apellido = datos.lector["Apellido"].ToString();
                cli.dni = datos.lector["DNI"].ToString();
                cli.direccion = datos.lector["Direccion"].ToString();
                cli.localidad = datos.lector["Localidad"].ToString();
                cli.telefono = datos.lector["Telefono"].ToString();
                cli.mail = datos.lector["Mail"].ToString();


            }
            return cli;

        }

        public bool ModificarCliente(Clientes aux)
        {
            AccesoDatos data = new AccesoDatos();
            data.prepareStatement("update clientes set nombre = @nombre, apellido = @apellido, dni = @dni, direccion = @direccion, localidad = @localidad, telefono = @telefono, mail = @mail where dni = '" + aux.dni + "'");
            data.agregarParametro("@nombre",aux.nombre);
            data.agregarParametro("@apellido",aux.apellido);
            data.agregarParametro("@dni",aux.dni);
            data.agregarParametro("@direccion",aux.direccion);
            data.agregarParametro("@localidad",aux.localidad);
            data.agregarParametro("@telefono",aux.telefono);
            data.agregarParametro("@mail",aux.mail);
            data.ejecutarAccion();
            data.cerrarConexion();

            if (data.getAffectedRows() <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
