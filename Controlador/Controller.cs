using System;
using System.Collections.Generic;
using System.Text;
using Gestion.Views;
using Gestion.Modelo;
using System.Windows.Forms;
using System.Net.WebSockets;

namespace Gestion.Controlador
{
    public class Controller
    {
        MenuView mw;
        Model model;
        
        public Controller()
        {
            mw = new MenuView();
            model = new Model();
            mw.ClickButton += Listeners;
            mw.ShowDialog();
        }

        public void Listeners(int valor)
        {

            if (valor == 0)
            {
                Application.Exit();

            } 
            else if (valor == 1)
            {
                OpenSearch();
            } 
            else if (valor == 2)
            {
                OpenList();
            }
        }

        public void OpenList()
        { 
            mw.Hide();
            ListController cont = new ListController();
        }

        public void OpenSearch()
        {
            mw.Hide();
            SearchController cont = new SearchController();
        }

        
    }
}
