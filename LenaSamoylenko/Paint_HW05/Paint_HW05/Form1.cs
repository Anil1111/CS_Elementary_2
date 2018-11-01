using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint_HW05.Figures;


namespace Paint_HW05
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.White;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        
        private void button_Circle_Click(object sender, EventArgs e)
        {
            treeView1.Visible = true;
            treeView2.Visible = true;
            Figure circle = new Circle();
            
            
        }

        private void button_Rectangle_Click(object sender, EventArgs e)
        {
            treeView1.Visible = true;
            treeView2.Visible = true;
            Figure rectangle = new Figures.Rectangle();
        }

        private void button_Pencil_Click(object sender, EventArgs e)
        {
            treeView1.Visible = false;
            treeView2.Visible = false;
            Figure circle = new Pencil();

        }

        private void button_Line_Click(object sender, EventArgs e)
        {
            treeView1.Visible = false;
            treeView2.Visible = false;
            Figure circle = new Line();
        }
    }
}
