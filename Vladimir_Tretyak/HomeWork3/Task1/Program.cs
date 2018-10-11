using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1 - Составить описание класса для представления времени.Предусмотреть возможности установки времени
//    и изменения его отдельных полей (час, минута, секунда) с проверкой допустимости вводимых значений.
//    В случае недопустимых значений полей выбрасываются исключения.
//    Создать методы изменения времени на заданное количество часов, минут и секунд.



namespace Task1
{
    class Time
    {
        public void ShowDataTime()
        {
            DateTime date = new DateTime();
            Console.WriteLine(date);
        }
        public void SetDataTime()
        {
            try
            {
                Console.Write("Установите дату и время, Год:");
                int Year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Установите дату и время, Месяц:");
                int Month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Установите дату и время, День:");
                int Day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Установите дату и время, Часы:");
                int Hours = Convert.ToInt32(Console.ReadLine());
                Console.Write("Установите дату и время, Минуты:");
                int Min = Convert.ToInt32(Console.ReadLine());
                Console.Write("Установите дату и время, Секунды:");
                int Sec = Convert.ToInt32(Console.ReadLine());
                DateTime date = new DateTime(Year, Month, Day, Hours, Min, Sec);
                Console.WriteLine(date);
            }
            catch
            {
                Console.WriteLine("Неверный ввод");
                SetDataTime();
            }


        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            time.ShowDataTime();
            time.SetDataTime();
            Console.ReadLine();
        }
    }
}
