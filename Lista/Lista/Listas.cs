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
        
        
        public listasVentana()
        {
            InitializeComponent();
            fill_List();
        }

        void fill_List()
        {
            String StrConn = "datasource=localhost;port=3306;username=root;password=ElGuajolot3;database=bdrep";
            String Query = "SELECT * FROM lista;";
            MySqlConnection conDb = new MySqlConnection(StrConn);
            MySqlCommand cmdDB = new MySqlCommand(Query,conDb);
            MySqlDataReader Reader;
            try
            {
                conDb.Open();
                Reader = cmdDB.ExecuteReader();

                while (Reader.Read())
                {
                    string sName = Reader.GetString("Nombre");
                    Lista.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!");
            }
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
           
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            
        }
    }
}
