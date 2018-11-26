using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookView
{
    public partial class InsertData : Form
    {
        private HelpProj.InsertDialogData data;
        internal HelpProj.InsertDialogData Data => data;

        public InsertData()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            var data = new HelpProj.InsertDialogData(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text), textBox6.Text);
            Close();
        }
    }
}
