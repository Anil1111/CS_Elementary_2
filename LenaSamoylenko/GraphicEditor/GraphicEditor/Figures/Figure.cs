using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Drawing;

namespace GraphicEditor
{
    abstract class Figure
    {
        public PictureBox pictureBox;
        protected int a = 0, b = 0;
        bool IsPressed;
        protected Bitmap myBitmap;
        Brush brush;
        Pen p;
        Graphics gr;


        public Figure(PictureBox pb)
        {
            pictureBox = pb;
            brush = new SolidBrush(pictureBox.BackColor);
            p = new Pen(Color.Blue);

        }

        public virtual void pb_MouseUp(object sender, MouseEventArgs e)
        {
            IsPressed = false;
        }

        public virtual void pb_MouseDown(object sender, MouseEventArgs e)
        {
            IsPressed = true;
            a = e.X;
            b = e.Y;
        }

        public void pb_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsPressed)
            {

                myBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
                gr = Graphics.FromImage(myBitmap);
               
                gr.DrawRectangle(p, a, b, e.X - a, e.Y - b);
                pictureBox.Image = myBitmap;

            }
        }
    }
}
