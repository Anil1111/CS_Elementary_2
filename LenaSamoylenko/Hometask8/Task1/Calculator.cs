using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public delegate double myDelegate();
    static class Calculator
    {
        private static double x;
        private static double y;

        public static double X => x;
        public static double Y => y;

        static Calculator()
        {
            Console.WriteLine("Put x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Put y");
            y = Convert.ToDouble(Console.ReadLine());
        }

        #region Plus
        private static double Plus()
        {
            Console.WriteLine("+:");
            return (x + y);
        }

        public static void PrintPlus()
        {
            var p = new myDelegate(Calculator.Plus);
            Console.WriteLine(p.Invoke()+"\n");
        }
        #endregion

        #region Minus
        private static double Minus()
        {
            Console.WriteLine("-:");
            return (x - y);
        }

        public static void PrintMinus()
        {
            var m = new myDelegate(Calculator.Minus);
            Console.WriteLine(m.Invoke()+"\n");
        }
        #endregion

        #region Multiply
        private static double Multiply()
        {
            Console.WriteLine("*:");
            return (x * y);
        }

        public static void PrintMultiply()
        {
            var mt = new myDelegate(Calculator.Multiply);
            Console.WriteLine(mt.Invoke()+"\n");
        }
        #endregion

        #region Devide
        private static double Devide()
        {
            Console.WriteLine("/:");
            return (x / y);
        }

        public static void PrintDevide()
        {
            var d = new myDelegate(Calculator.Devide);
            Console.WriteLine(d.Invoke()+"\n");
        }
        #endregion
    }
}
