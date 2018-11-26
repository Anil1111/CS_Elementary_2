using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneBookPresenter;



namespace PhoneBookView
{
    public partial class PhoneBook : Form, IPhoneBookView
    {
        private MainPresenter presenter;
        public PhoneBook()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter = new MainPresenter(textBox1.Text, textBox2.Text);
            var con = presenter.ButtonConnection();
            label1.Text = con.Item1;
            label3.Text = presenter.ReturnDatabases();
            label3.Visible = con.Item2;
            label5.Text = presenter.ReturnUserName();
            label5.Visible = con.Item3;

            Refresh();

        }

        private void selectAll_Click(object sender, EventArgs e)
        {
            //presenter.selectAll();
            dataGridView1.DataSource = presenter.SelectAll();
            dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.DataSource = (new DataSet()).Tables["address"];


            dataGridView1.Refresh();
        }



        private void UpdateData(object sender, EventArgs e)
        {
            presenter.UpdateCell(dataGridView1.CurrentCellAddress.Y, dataGridView1.CurrentRow);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void addRow_Click(object sender, EventArgs e)
        {
            var form = new InsertData();
            form.ShowDialog();
            presenter.InputRow(form.Data);
        }
    }
}
