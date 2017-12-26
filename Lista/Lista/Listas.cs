using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lista
{
    public partial class listasVentana : Form
    {
        private DBConnect con = new DBConnect();
        public String Connection = "Server=localhost;Database=BDRep;Uid=root;Pwd=ElGuajolot3;";
        MySqlCommand cmd;
        private DataGridView dataGridView1 = new DataGridView();

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
            Nuevo_Video_Lista op = new Nuevo_Video_Lista();
            op.Show();
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Connection);
            con.Open();
            try
            {
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "SELECT * FROM Lista";
                MySqlDataAdapter adap = new MySqlDataAdapter(comm);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        private void inicio_Click(object sender, EventArgs e)
        {

        }
    }

}
