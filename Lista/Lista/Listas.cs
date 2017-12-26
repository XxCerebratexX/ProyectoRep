using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista
{
    public partial class listasVentana : Form
    {
        public listasVentana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevaLista op = new nuevaLista();
            op.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listasVentana_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void nuevoVideo_Click(object sender, EventArgs e)
        {

        }
    }
}
