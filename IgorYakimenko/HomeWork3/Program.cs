using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {



       /*  1 - составить описание класса для представления времени.
         Предусмотреть возможности установки времени и изменения его отдельных полей (час, минута, секунда) с проверкой допустимости вводимых значений. 
         в случае недопустимых значений полей выбрасываются исключения.
         создать методы изменения времени на заданное количество часов, минут и секунд.*/

        static void Main(string[] args)
        {

            string hh = string.Empty;
            string mi = string.Empty;
            string si = string.Empty;

            Console.Write("Введите час: ");
            hh = Console.ReadLine();

            Console.Write("Введите минуты: ");
            mi = Console.ReadLine();

            Console.Write("Введите секунды: ");
            si = Console.ReadLine();

            GetSetTime gettim = new GetSetTime(hh,mi,si);

            gettim.ShowTime();

            Console.WriteLine();
            

            gettim.ShowTime(gettim.HH, gettim.MI, gettim.SI);

            Console.WriteLine();

            Console.Write(new string('-',50));
            
            Console.WriteLine();

            Console.Write("Введите час: ");
            hh = Console.ReadLine();

            Console.Write("Введите минуты: ");
            mi = Console.ReadLine();

            Console.Write("Введите секунды: ");
            si = Console.ReadLine();

            GetSetTime gettim1 = new GetSetTime(hh, mi, si);
            Console.WriteLine();
            gettim1.TimeAdd();


            Console.ReadKey();
        }
    }
}
