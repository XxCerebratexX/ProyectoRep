﻿using System;
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
    public partial class nuevaLista : Form
    {
        public nuevaLista()
        {
            InitializeComponent();
        }

        private void nuevaLista_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guardar_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
