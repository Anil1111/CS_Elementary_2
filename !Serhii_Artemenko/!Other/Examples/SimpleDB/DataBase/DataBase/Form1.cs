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

namespace DataBase
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        MySqlDataAdapter dataAdapter;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string datasource = "localhost";
                string port = "3306";
                string username = "root";
                string password = "password";

                string connectionString = String.Format($"datasource={datasource};port={port};username={username};password={password};"); 

                connection = new MySqlConnection(connectionString);

                string query = textBox1.Text;

                dataAdapter = new MySqlDataAdapter(query, connection);
                
                connection.Open();

                ds = new DataSet();
                dataAdapter.Fill(ds, "books");
                dataGridView1.DataSource = ds.Tables["books"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_CloseConnection_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                label1.Text = "Not connected";
                label1.ForeColor = Color.Red;
                dataGridView1.Refresh();
            }
        }

        private void btn_OpenConnection_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                label1.Text = "Connected";
                label1.ForeColor = Color.Green;
                dataGridView1.Refresh();
            }
        }

    }
}
