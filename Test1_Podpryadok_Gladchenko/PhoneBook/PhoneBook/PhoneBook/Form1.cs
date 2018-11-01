using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
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
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
            btn_save.Enabled = false;
            nameBox.Enabled = false;
            phoneBox.Enabled = false;
            emailBox.Enabled = false;
            skypeBox.Enabled = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            btn_update.Enabled = true;
            nameBox.Enabled = true;
            phoneBox.Enabled = true;
            emailBox.Enabled = true;
            skypeBox.Enabled = true;
        }
    }
}
