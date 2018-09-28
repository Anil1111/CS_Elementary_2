using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkRectangle
{
    class CRectangle
    {
        double side1{get;set;}
        double side2{get;set;}

        public double Area              //свойства поля "Площадь" - вычисляющий площадь прямоугольника
        {
            get
            {
                return side1 * side2;
            }
        }


        public double Perimeter         //свойства поля "Периметр" - вычисляющий периметр прямоугольника  
        {
            get
            {
               return (side1 + side2) * 2;
            }
        }

        public CRectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator() 
        {
            return Area;
        }

        public double PerimeterCalculator() 
        {
            return Perimeter;
        }
    }
 }
