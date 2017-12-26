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
            MySqlCommand cmdDB = new MySqlCommand(Query, conDb);
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
            String StrConn = "datasource=localhost;port=3306;username=root;password=ElGuajolot3;database=bdrep";
            ;
            String Query2 = "SELECT videos.Nombre AS NombreV, lista.Nombre AS NombreL FROM (videoslista INNER JOIN videos ON" +
            " videoslista.idVideos = videos.idVideos INNER JOIN lista ON videoslista.idLista = lista.idLista)" +
            " WHERE videoslista.idLista =(SELECT idLista FROM lista WHERE Nombre='" + Lista.Text + "');";
            MySqlConnection conDb = new MySqlConnection(StrConn);
            //MySqlCommand Command = new MySqlCommand(Query1, conDb);
            MySqlCommand cmdDB = new MySqlCommand(Query2, conDb);
            MySqlDataReader Reader;
            MySqlDataReader Reader1;
            try
            {
                conDb.Open();
                //Reader1 = Command.ExecuteReader();
                Reader = cmdDB.ExecuteReader();
                String sName1 = "";
                videosLista.Items.Clear();
                while (Reader.Read())
                {
                    sName1 = Reader.GetString("NombreV");
                    //string sName2 = Reader.GetString("NombreL");
                    videosLista.Items.Add(sName1);
                    //videosLista.Items.Add(sName2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void inicio_Click(object sender, EventArgs e)
        {

        }
    }
}

