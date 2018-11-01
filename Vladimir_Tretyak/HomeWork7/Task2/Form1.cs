using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace Player
{
    public partial class Form1 : Form
    {
        Player pl = new Player();
        public Form1()
        {         
            InitializeComponent();          
        }

        private void button1_Click(object sender, EventArgs e)
        {                      
            pl.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            pl.Pause();
        }
        private void button4_Click(object sender, EventArgs e)
        {            
            pl.Stop();
        }      
        private void button3_Click(object sender, EventArgs e)
        {            
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы mp3|*.mp3";
            OPF.Multiselect = true;
         
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in OPF.FileNames)
                {
                    MessageBox.Show(file);
                }
                InitPlay.Wplayer.URL = OPF.FileName;//Читаем путь к файлу
                InitPlay.Wplayer.controls.stop();
            }          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pl.Record();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pl.StopRec();
        }
    }
}
