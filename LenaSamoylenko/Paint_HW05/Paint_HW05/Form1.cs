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
using Paint_HW05.Context;


namespace Paint_HW05
{
    public partial class Form1 : Form
    {
        //Color CurrentColor = Color.Black;
        WorkWithFigures workWithFigures = null;
        //Graphics g;

        public Form1()
        {
            InitializeComponent();
            //workWithFigures.G = pictureBox1.CreateGraphics();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }


        private void button_Circle_Click(object sender, EventArgs e)
        {
            Figure circle = new Circle();

        }

        private void button_Rectangle_Click(object sender, EventArgs e)
        {
            Figure rectangle = new Figures.Rectangle();
        }

        private void button_Pencil_Click(object sender, EventArgs e)
        {
            workWithFigures.G = pictureBox1.CreateGraphics();
            Figure pencil = new Pencil();
            workWithFigures = new WorkWithFigures(pencil);
            //pencil.pictureBox1_MouseDown(sender, e);

        }

        private void button_Line_Click(object sender, EventArgs e)
        {
            Figure circle = new Line();
        }

        private void COLOR_Click(object sender, EventArgs e)
        {
            DialogResult D = colorDialog1.ShowDialog();
            if (D == System.Windows.Forms.DialogResult.OK)
            workWithFigures.CurrentCOLOR = colorDialog1.Color;
}

        
    }
}
