using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Paint_HW05.Context
{
    class WorkWithFigures:Figure
    {
        private Figure _figureType;

        public Figure FigureType => _figureType;
        public WorkWithFigures(Figure figureType)
        {
            _figureType = figureType;
        }

        //virtual void FirstPoint(object sender, PaintEventArgs e);
    }
}
