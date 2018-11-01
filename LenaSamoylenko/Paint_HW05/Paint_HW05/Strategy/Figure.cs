using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Paint_HW05
{
    abstract class Figure
    {
        Color CurrentColor = Color.Black;
        bool isPressed = false;
        Point CurrentPoint;
        Point PrevPoint;
        Graphics g;

        public Color CurrentCOLOR { get => CurrentColor; set => CurrentColor = value; }
        public Graphics G { get => g; set => g = value; }

        public virtual void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

        public virtual void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            CurrentPoint = e.Location;
        }

        public virtual void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                PrevPoint = CurrentPoint;
                CurrentPoint = e.Location;
                Pen p = new Pen(CurrentCOLOR);
                g.DrawLine(p, PrevPoint, CurrentPoint);
            }

        }

    }
}
