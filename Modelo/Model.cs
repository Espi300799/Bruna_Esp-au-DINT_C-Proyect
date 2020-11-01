using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Gestion.Modelo
{
    public class Model
    {
        Conexion DbConnection = new Conexion();
        MySqlConnection connector;

        public Model()
        {
            connector = DbConnection.CrearConexion();
            connector.Open();
        }

        public MySqlDataAdapter GetAllAlumnos()
        { 
            string select = "SELECT * FROM ALUMNOS";
            MySqlDataAdapter AllAlumnos = new MySqlDataAdapter(select, connector);
            return AllAlumnos;
        }

        public void DeleteAlumno(string dni)
        { 
            string select = "DELETE FROM ALUMNOS WHERE dni = '" + dni + "' ";
            MySqlCommand eliminarAlumno = new MySqlCommand(select, connector);
            eliminarAlumno.ExecuteNonQuery();
            MessageBox.Show("Alumno eliminado con exito");
        }

        public MySqlDataAdapter GetAlumno(string dni)
        {
            string select = "SELECT * FROM ALUMNOS WHERE dni = '" + dni + "' ";
            MySqlDataAdapter GetAlumno = new MySqlDataAdapter(select, connector);
            return GetAlumno;
        }
    }
}
