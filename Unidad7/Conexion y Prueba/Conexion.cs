using System;
using MySql.Data.MySqlClient;

namespace Unidad7
{
    public class Conexion
    {
        // Tu cadena de conexión centralizada
        private static string cadenaConexion = "Server=localhost;Port=3306;Database=tienda;Uid=root;Pwd=tNx92mlAw.;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}