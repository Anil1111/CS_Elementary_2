using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkPolygon
{
    class CFigure
    {
        CPoint Per1;
        CPoint Per2;
        CPoint Per3;
        CPoint Per4;
        CPoint Per5;
        CPoint[] points;

        public CFigure(CPoint per1, CPoint per2, CPoint per3)
        {
            this.Per1 = per1;
            this.Per2 = per2;
            this.Per3 = per3;            
        }

        public CFigure(CPoint per1, CPoint per2, CPoint per3, CPoint per4)
        {
            this.Per1 = per1;
            this.Per2 = per2;
            this.Per3 = per3;
            this.Per4 = per4;

        }

        public CFigure(CPoint per1, CPoint per2, CPoint per3, CPoint per4, CPoint per5)
        {
            this.Per1 = per1;
            this.Per2 = per2;
            this.Per3 = per3;
            this.Per4 = per4;
            this.Per5 = per5;
        }

        public double LengthSide(CPoint A, CPoint B) //рассчитываею длину стороны многоугольника
        {            
            return Math.Sqrt(Math.Pow(A.Pole1 - B.Pole1, 2) + Math.Pow(A.Pole2 - B.Pole2, 2));            
        }

        public void PerimeterCalculator() //рассчитыва периметр многоугольника
        {
            double perimeter = 0;
            string Naim = string.Empty;

            if (Per5 != null)
            {
                points = new CPoint[5];
                points[0] = Per1;
                points[1] = Per2;
                points[2] = Per3;
                points[3] = Per4;
                points[4] = Per5;
                Naim = "Пятиугольник";
            }
            else if (Per5 == null && Per4 != null)
            {
                points = new CPoint[4];
                points[0] = Per1;
                points[1] = Per2;
                points[2] = Per3;
                points[3] = Per4;
                Naim = "Прямоугольник";
            }
            else
            {
                points = new CPoint[3];
                points[0] = Per1;
                points[1] = Per2;
                points[2] = Per3;
                Naim = "Треугольник";
            }

            for (int i = 1; i < points.Length; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]);
            }
            perimeter += this.LengthSide(points[0], points[points.Length - 1]);

            Console.WriteLine(@"Название многоугольника : {0}", Naim);
            Console.WriteLine(@"Периметер многоугольника : {0}",perimeter);
        }

    }
}
