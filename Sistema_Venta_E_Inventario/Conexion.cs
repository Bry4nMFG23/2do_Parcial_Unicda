using System.Configuration;
using System.Data.SqlClient;

namespace Sistema_Venta_E_Inventario
{
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;

        public static SqlConnection abrirConexion()
        {
            SqlConnection conexion = new SqlConnection(cadena);
            return conexion;
        }


    }
}
