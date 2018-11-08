using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contacts;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkWithData workWithData = new WorkWithMySql($"datasource=localhost;database=contacts_book;port=3306;username=root;password=123456;");

            DataTable dt = new DataTable();
            dt = workWithData.SearchRecord("");

            dataGridView1.DataSource = dt;
         

        }
    }
}
