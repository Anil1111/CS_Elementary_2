using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Subscriber> subscriber = new List<Subscriber>();
            Subscriber sub1 = new Subscriber(123456789012, "Oleg", "Bublic", "Petrovich", "Lenina, 10", 234578905671, 10000, 10000, 2, 0, 17, 1, 20, 34);
            AddSubscriber(subscriber, sub1);
            Subscriber sub2 = new Subscriber(785656789122, "Mark", "Koval", "Vladimirovich", "Gagarina, 34", 963478905671, 20000, 20000, 4, 12, 57, 3, 12, 15);
            AddSubscriber(subscriber, sub2);
            Subscriber sub3 = new Subscriber(785656789122, "Evgeniy", "Levin", "Vladimirovich", "Gagarina, 4", 963478905671, 20000, 20000, 0, 0, 0, 3, 12, 15);
            AddSubscriber(subscriber, sub3);

            Console.WriteLine("all subscriber");
            Program.PrintAllSubscriber(subscriber);
            Console.WriteLine("with using etalontime");
            PutEtalonTime(subscriber);
            Console.WriteLine("Order by");
            OrderubScriber(subscriber);
            Console.WriteLine("use call in country");
            subscribersWhichUsingCallInCountry(subscriber);
            Console.ReadKey();
        }


        public static void AddSubscriber(List<Subscriber> list, Subscriber sub1)
        {
            list.Add(sub1);
        }

        private static void Print(Subscriber sub)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t" + sub.TimeCallInCountry.ToString("hh:mm:ss") + "\t" + sub.TimeCallInCity.ToString("hh:mm:ss"),
            sub.INN1, sub.SecondName, sub.FirstName, sub.Patronymic, sub.Adress, sub.CreditCard, sub.Debet, sub.Credit);
        }

        public static void PrintAllSubscriber(List<Subscriber> list)
        {
            foreach (Subscriber sub in list)
            {
                Print(sub);
            }
        }
        public static void PutEtalonTime(List<Subscriber> list)
        {
            int etalonHours, etalonMinutes, etalonSeconds;
            List<Subscriber> helpList = new List<Subscriber>();
            Console.WriteLine("Put your etalon time\nHours");
            bool hours = int.TryParse(Console.ReadLine(), out etalonHours);
            Console.WriteLine("Minutes");
            bool minutes = int.TryParse(Console.ReadLine(), out etalonMinutes);
            Console.WriteLine("Seconds");
            bool seconds = int.TryParse(Console.ReadLine(), out etalonSeconds);
            foreach (Subscriber s in list)
            {
                if (s.TimeCallInCity.Hour > etalonHours || s.TimeCallInCity.Hour == etalonHours && (s.TimeCallInCity.Minute > etalonMinutes || (s.TimeCallInCity.Minute == etalonMinutes && s.TimeCallInCity.Second >= etalonSeconds)))
                {
                    helpList.Add(s);
                }
            }
            OrderubScriber(helpList);
        }
        private static void OrderubScriber(List<Subscriber> list)
        {
            List<Subscriber> helpList = new List<Subscriber>();
            helpList = list.OrderBy(o => o.SecondName).ToList();
            PrintAllSubscriber(helpList);
        }

        public static void subscribersWhichUsingCallInCountry(List<Subscriber> list)
        {
            foreach (Subscriber s in list)
            {
                if (s.TimeCallInCountry.Hour != 0 || s.TimeCallInCountry.Minute != 0 || s.TimeCallInCountry.Second != 0)
                {
                    Print(s);
                }
            }
        }





    }

}
