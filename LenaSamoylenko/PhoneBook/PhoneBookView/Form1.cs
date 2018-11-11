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
            presenter = new MainPresenter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserConnecting userConnecting = new UserConnecting();
            userConnecting.Show();
            //Добавить текст про сервер и бд
            label1.Text = "соединение установлено";
        }

        private void selectAll_Click(object sender, EventArgs e)
        {
            presenter.selectAll();
            
            dataGridView1.DataSource = (new DataSet()).Tables["address"];
            dataGridView1.Refresh();
        }
    }
}
