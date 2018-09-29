using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkPolygon
{
    class Program
    {

        /*
       Создать классы Point и Figure. 
       Класс Point должен содержать два целочисленных поля и одно строковое поле. 
       Создать три свойства с одним методом доступа get. Создать пользовательский конструктор, в теле которого 
       проинициализируйте поля значениями аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point. 
       Создать два метода: double LengthSide(Point A, Point B), 
       который рассчитывает длину стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника. 
        
       Написать программу, которая выводит на экран название и периметр многоугольника.
        */

        static void Main(string[] args)
        {
            CPoint point = new CPoint(3,2,"длина");
            CPoint point1 = new CPoint(5, 4, "ширина");
            CPoint point2 = new CPoint(6, 1, "высота");

            CFigure figure = new CFigure(point, point1, point2);

            figure.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
