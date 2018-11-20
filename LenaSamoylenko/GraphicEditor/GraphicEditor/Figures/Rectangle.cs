using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GraphicEditor.Figures
{
    internal class Rectangle : Figure
    {
        public Rectangle(PictureBox pb) : base(pb)
        {
        }

        public override void pb_MouseUp(object sender, MouseEventArgs e)
        {
            myBitmap = new Bitmap(this.pictureBox.Width, this.pictureBox.Height);
            var fig = Graphics.FromImage(myBitmap);

            Pen p = new Pen(Color.Green);
            fig.DrawRectangle(p, a, b, e.X - a, e.Y - b);
            pictureBox.Image = myBitmap;

        }
    }
}
