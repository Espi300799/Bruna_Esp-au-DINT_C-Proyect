using System;
using System.Collections.Generic;
using System.Text;
using Gestion.Views;
using Gestion.Modelo;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Gestion.Controlador
{
    class SearchController
    {
        SearchView sw;
        Model model;

        public SearchController()
        {
            sw = new SearchView();
            model = new Model();
            sw.ClickButton += SearchListeners;
            sw.ShowDialog();
        }

        public void SearchListeners(int valor)
        {
            if (valor == 0)
            {
                Retroceder();                
            }
            else if (valor == 1)
            {
                FillDataGrid();
            }
            else if (valor == 2)
            {
                EliminarAlumno();
            }
        }

        public void FillDataGrid()
        {
            string dni = sw.TextBoxDNI.Text;
            DataSet dataSet = new DataSet();
            MySqlDataAdapter dataAdapter = model.GetAlumno(dni);
            dataAdapter.Fill(dataSet);

            dataSet.Tables[0].Columns.Remove("registro");

            sw.DataGridView1.DataSource = dataSet.Tables[0];
        }

        public void EliminarAlumno()
        {
            string dni = sw.TextBoxDNI.Text;
            model.DeleteAlumno(dni);
        }

        public void Retroceder()
        {
            sw.Hide();
            new Controller();
        }
    }
}
