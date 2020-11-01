using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Gestion.Modelo
{
    class Conexion
    {
        string cadenaConexion
        {
            get;
            set;
        }

        MySqlConnection conexionBd
        {
            get;
            set;
        }

        public string InicializarCadena()
        {
            string server = "localhost";
            string db = "db_libros";
            string user = "root";
            string password = "root";
            string data = null;

            string cadenaConexion = "Database=" + db + "; Server=" + server + "; User Id=" + user + "; Password=" + password;

            return cadenaConexion;
        }

        public MySqlConnection CrearConexion()
        {
            string cadenaConexion = InicializarCadena();

            string consulta = "SHOW DATABASES";

            MySqlCommand comando = new MySqlCommand(consulta);

            MySqlConnection conexionBd = new MySqlConnection(cadenaConexion);

            try
            {
                comando.Connection = conexionBd;
                conexionBd.Open();
                //MessageBox.Show("Conexión realizada.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido conectar con la base de datos. Error: " + ex.Message);
            }
            finally
            {
                conexionBd.Close();
            }

            return conexionBd;

        }
    }
}
