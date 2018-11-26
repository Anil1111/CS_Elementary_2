using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using GraphicEditor.Figures;

namespace GraphicEditor
{
    public partial class Form1 : Form
    {

        public Bitmap bmp { get; set; }
        Figure figure = null;

        public Form1()
        {
            InitializeComponent();
            figure = new Line(pictureBox1);
            Event();
        }

        private string filter = "JPEG File(*.jpg)|*.jpg|" +
                "GIF File(*.gif)|*.gif|" +
                "Bitmap File(*.bmp)|*.bmp|" +
                "TIF File(*.tif)|*.tif|" +
                "PNG File(*.png)|*.png";

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filter;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string name = openFileDialog.FileName;
                pictureBox1.InitialImage = Image.FromFile(name);
                bmp = new Bitmap(pictureBox1.InitialImage);
                pictureBox1.Image = bmp;
            }

        }

        private void newPict_Click(object sender, EventArgs e)
        {
            this.pictureBox1.BackColor = System.Drawing.Color.White;
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить картинку как ...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter = filter;
            savedialog.ShowHelp = true;

            
            // If selected, save
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                // Get the user-selected file name
                string fileName = savedialog.FileName;
                // Get the extension
                string strFilExtn =
                    fileName.Remove(0, fileName.Length - 3);
                // Save file
                switch (strFilExtn)
                {
                    case "bmp":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }

        private void line_Click(object sender, EventArgs e)
        {
            figure = new Line(pictureBox1);
        }

        private void polyline_Click(object sender, EventArgs e)
        {
            figure = new Polyline(pictureBox1);
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            figure = new Circle(pictureBox1);
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            figure = new GraphicEditor.Figures.Rectangle(pictureBox1);
            
         }

        private void Event()
        {
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(figure.pb_MouseDown);
            this.pictureBox1.MouseMove += new MouseEventHandler(figure.pb_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(figure.pb_MouseUp);
            //this.pictureBox1.MouseUp += new MouseEventHandler((object sender, MouseEventArgs e) => { pictureBox1.Refresh(); });
        }
    }
}
