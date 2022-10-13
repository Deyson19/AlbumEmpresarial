using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlbumEmpresarial
{
    public class Conexion
    {
        public static MySqlConnection conexion()
        {
            string servidor, db, usuario, password, cadenaConexion;
            servidor = "127.0.0.1";
            db = "adminimagenes";
            usuario = "root";
            password = "";

            cadenaConexion = "Database=" + db + "; Data Source=" + servidor + 
                "; User Id= " + usuario + "; Password=" + password + "";

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Error al establecer la conexion" + ex.Message);
                return null;
            }
        }
    }
}
