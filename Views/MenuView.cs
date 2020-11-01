using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Views
{
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        public delegate void buttonAction(int valor);

        public event buttonAction ClickButton;

        private void BttnSalir_Click(object sender, EventArgs e)
        {
            ClickButton(0);
        }

        private void BttnBuscar_Click(object sender, EventArgs e)
        {
            ClickButton(1);
        }

        private void BttnVisualizar_Click(object sender, EventArgs e)
        {
            ClickButton(2);
        }
    }
}
