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
    public partial class Nuevo_Video : Form
    {
        public Nuevo_Video()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guardarCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
