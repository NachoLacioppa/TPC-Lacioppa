using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace NEGOCIO
{
    public class AccesoDatos
    {
        public SqlDataReader lector { get; set; }
        public SqlConnection conexion { get; }
        public SqlCommand comando { get; set; }
        private int affectedRows;
        
        public AccesoDatos()
        {
            conexion = new SqlConnection("data source=localhost\\SQLEXPRESS; initial catalog=LACIOPPA_DB; integrated security=sspi");
            comando = new SqlCommand();
            comando.Connection = conexion;
            affectedRows = 0;
        }

        public void setearQuery(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void prepareStatement(string statement)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = statement;
        }
        public SqlDataReader getReader()
        {
            return lector;
        }

        public int getAffectedRows()
        {
            return affectedRows;
        }

        public void agregarParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void ejecutarLector()
        {
            conexion.Open();
            lector = comando.ExecuteReader();
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public void ejecutarAccion()
        {
            conexion.Open();
            comando.ExecuteNonQuery();
        }
        
        
        
       
    }
    //public DataSet Consulta(string palabra)
    //{
    //    string strcon = "data source=localhost\\SQLEXPRESS; initial catalog=LACIOPPA_DB; integrated security=sspi";
    //    SqlConnection con = new SqlConnection(strcon);
    //    con.Open();
    //    SqlCommand cmd = new SqlCommand(palabra, con);
    //    SqlDataAdapter da = new SqlDataAdapter(cmd);
    //    DataSet ds = new DataSet();
    //    da.Fill(ds);
    //    con.Close();
    //    return ds; 
    //}

}
