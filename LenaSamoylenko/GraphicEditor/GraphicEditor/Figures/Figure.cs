using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GraphicEditor
{
     abstract class Figure
    {
        protected PictureBox pictureBox;
        protected int a = 0, b = 0;
        protected Bitmap myBitmap;

        public Figure(PictureBox pb)
        {
            pictureBox = pb;
        }

        public virtual void pb_MouseUp(object sender, MouseEventArgs e)
        {
            myBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            var fig = Graphics.FromImage(myBitmap);

            Pen p = new Pen(Color.Green);
            fig.DrawRectangle(p, a, b, e.X - a, e.Y - b);
            pictureBox.Image = myBitmap;

        }

        public virtual void pb_MouseDown(object sender, MouseEventArgs e)
        {
            a = e.X;
            b = e.Y;
            
        }

        void pb_MouseMove(object sender, MouseEventArgs e)
        {
            // toolStripStatusLabel1.Text = "X = " + e.X + "Y = " + e.Y;
        }

    }
}
