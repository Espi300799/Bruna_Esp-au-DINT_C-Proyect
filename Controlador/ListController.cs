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
    public class ListController
    {
        Views.ListView lw;
        Model model;

        public ListController()
        {
            lw = new Views.ListView();
            model = new Model();
            lw.ClickButton+=ListListeners;
            FillDataGrid();
            lw.ShowDialog();
        }

        public void ListListeners(int valor)
        {
            if (valor == 0)
            {
                lw.Hide();
                new Controller();
            }
        }

        public void FillDataGrid()
        {
            DataSet dataSet = new DataSet();
            MySqlDataAdapter dataAdapter = model.GetAllAlumnos();
            dataAdapter.Fill(dataSet);

            dataSet.Tables[0].Columns.Remove("registro");

            lw.GetDataGridView.DataSource = dataSet.Tables[0];
        }
    }
}
