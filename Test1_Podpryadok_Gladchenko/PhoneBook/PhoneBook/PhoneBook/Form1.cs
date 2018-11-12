using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP;
using MySql.Data.MySqlClient;

namespace PhoneBook
{    
    public partial class Form1 : Form
    {
        MVP.Crud crud = new Crud();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MVP.Connect connect = new Connect();
                dataGridView.DataSource = connect.Connecting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            btn_save.Enabled = true;
            nameBox.Enabled = true;
            phoneBox.Enabled = true;
            emailBox.Enabled = true;
            skypeBox.Enabled = true;
            btn_delate.Enabled = false;
            btn_search.Enabled = false;
            SearchBox.Enabled = false;
            
            crud.Add();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
            btn_save.Enabled = false;
            nameBox.Enabled = false;
            phoneBox.Enabled = false;
            emailBox.Enabled = false;
            skypeBox.Enabled = false;
            btn_delate.Enabled = false;
            btn_search.Enabled = true;
            SearchBox.Enabled = true;

            crud.Save();

            CleanForm();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            btn_delate.Enabled = true;
            nameBox.Enabled = true;
            phoneBox.Enabled = true;
            emailBox.Enabled = true;
            skypeBox.Enabled = true;
            btn_save.Enabled = true;
            btn_search.Enabled = false;
            SearchBox.Enabled = false;

            crud.Search();

            SearchBox.Text = "";
        }

        private void btn_delate_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
            btn_save.Enabled = false;
            nameBox.Enabled = false;
            phoneBox.Enabled = false;
            emailBox.Enabled = false;
            skypeBox.Enabled = false;
            btn_delate.Enabled = false;
            btn_search.Enabled = true;
            SearchBox.Enabled = true;

            crud.Delate();

            CleanForm();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void CleanForm()
        {
            nameBox.Text = "";
            phoneBox.Text = "";
            emailBox.Text = "";
            skypeBox.Text = "";
            SearchBox.Text = "";
        }
    }
}
