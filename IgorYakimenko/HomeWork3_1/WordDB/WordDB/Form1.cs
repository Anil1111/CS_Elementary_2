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

namespace WordDB
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        MySqlDataAdapter dataAdapter;
        DataSet ds;

        string datasource = "localhost";
        string port = "3306";
        string username = "root";
        string password = "123456";

        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string connectionString = String.Format($"datasource={datasource};port={port};username={username};password={password};");

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    string query = textBox1.Text;

                    dataAdapter = new MySqlDataAdapter(query, connection);

                    connection.Open();

                    ds = new DataSet();
                    dataAdapter.Fill(ds, "brand");
                    dataGridView1.DataSource = ds.Tables["brand"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
