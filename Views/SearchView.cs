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
    public partial class SearchView : Form
    {
        public SearchView()
        {
            InitializeComponent();
        }

        public delegate void buttonAction(int valor);

        public event buttonAction ClickButton;

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            ClickButton(1);
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            ClickButton(2);
        }

        private void bttnAtras_Click(object sender, EventArgs e)
        {
            ClickButton(0);
        }
    }
}
