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

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        MVP.Crud crud = new Crud();
        public Form1()
        {
            InitializeComponent();
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

            crud.Save();
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

            crud.Search();
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

            crud.Delate();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
