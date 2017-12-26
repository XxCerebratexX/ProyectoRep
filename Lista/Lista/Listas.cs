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
            con = new DBConnect();
            List<string>[] Select()
            {
                string query = "SELECT * FROM tableinfo";

                //Create a list to store the result
                List<string>[] list = new List<string>[3];
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<string>();

                //Open connection
                if (con.OpenConnection() == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["id"] + "");
                        list[1].Add(dataReader["name"] + "");
                        list[2].Add(dataReader["age"] + "");
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                    //return list to be displayed
                    return list;
                }
                else
                {
                    return list;
                }
            }
        }
    }

}
