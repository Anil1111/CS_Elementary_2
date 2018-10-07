using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculat
{
    class Program
    {
        static string str;
        static int[] numbers = new int[3];
        static bool flagFrmat = false;

        public static void formatFault(string _str)
        {
            flagFrmat = false;//Обнуляем флаг ошибки ввода
            if (String.IsNullOrEmpty(_str)) flagFrmat = true;//Проверка строки на пустоту
            char[] array = _str.ToCharArray(); //Передаем строку в массив чаров   
            //Проверяем правильность ввода выражения     
            for (int e = 0; e < array.Length; e++)
            {
                if (!Char.IsNumber(array[e]) && array[e] != '-' && array[e] != '+' && array[e] != '*' && array[e] != '/')
                {
                    flagFrmat = true;
                    break;
                }
            }

            if (flagFrmat == true)
            {
                Console.WriteLine("Неверный ввод, повторите ппытку");
                _str = null;
            }
            else
            {
                str = _str;
                Separate_string();
                Operations();
            }
        }
        //Делим строку на символы и переводим их в формат int
        public static int[] Separate_string()
        {
            string[] separate = str.Split('-', '+', '*', '/');
            int i;
            for (i = 0; i < separate.Length; i++)
            {
                numbers[i] = Convert.ToInt32(separate[i]);
            }
            return numbers;
        }
        //Производим операции над числами
        public static void Operations()
        {
            int index_Add = 0;
            int index_Sub = 0;
            int index_Mul = 0;
            int index_Div = 0;

            char[] arr = str.ToCharArray();
            for (int f = 0; f < arr.Length; f++)//Определяем какие операции есть в выражении
            {
                if (arr[f] == '+')
                {
                    index_Add = f;
                }
                if (arr[f] == '-')
                {
                    index_Sub = f;
                }
                if (arr[f] == '*')
                {
                    index_Mul = f;
                }
                if (arr[f] == '/')
                {
                    index_Div = f;
                }
            }
            if (index_Add != 0 && index_Mul != 0)
            {
                if (index_Add < index_Mul)
                {
                    Console.WriteLine(
                    "Результат = " + (Addition(Multiply(numbers[1], numbers[2]), numbers[0])));
                }
                else
                {
                    Console.WriteLine(
                    "Результат = " + (Addition(Multiply(numbers[0], numbers[1]), numbers[2])));
                }
            }

            if (index_Sub != 0 && index_Mul != 0)
            {
                if (index_Sub < index_Mul)
                {
                    Console.WriteLine(
                    "Результат = " + (Subtraction(Multiply(numbers[1], numbers[2]), numbers[0])) * -1);
                }
                else
                {
                    Console.WriteLine(
                    "Результат = " + (Subtraction(Multiply(numbers[0], numbers[1]), numbers[2])));
                }
            }

            if (index_Add != 0 && index_Div != 0)
            {
                if (index_Add < index_Div)
                {
                    Console.WriteLine(
                    "Результат = " + (Addition(Division(numbers[1], numbers[2]), numbers[0])));
                }
                else
                {
                    Console.WriteLine(
                    "Результат = " + (Addition(Division(numbers[0], numbers[1]), numbers[2])));
                }
            }

            if (index_Sub != 0 && index_Div != 0)
            {
                if (index_Sub < index_Div)
                {
                    Console.WriteLine(
                    "Результат = " + (Subtraction(Division(numbers[1], numbers[2]), numbers[0])) * -1);
                }
                else
                {
                    Console.WriteLine(
                    "Результат = " + (Subtraction(Division(numbers[0], numbers[1]), numbers[2])));
                }
            }

        }
        //Методы расчета
        static int Multiply(int a, int b)
        {
            int result = a * b;
            return result;
        }
        static int Division(int a, int b)
        {
            int result = a / b;
            return result;
        }

        static int Addition(int a, int b)
        {
            int result = a + b;
            return result;
        }
        static double Subtraction(int a, int b)
        {
            double result = a - b;
            return result;
        }

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите строку для расчета: ");
                formatFault(Console.ReadLine());
            }
            while (flagFrmat == true);
            Console.ReadLine();

        }
    }
}
