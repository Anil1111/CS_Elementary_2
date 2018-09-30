using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Task1
{
    class Order
    {
        public string acountRecipient;//Расчетный счет получателя
        public string acountPayer;//Расчетный счет плательщика
        public double transferredAmount;//Перечисляемая сумма                                
        public Order InputData()
        {
            Console.WriteLine("Введите новый расчетный счет плательщика: ");
            acountPayer = Console.ReadLine();
            Console.WriteLine("Введите новый расчетный счет получателя: ");
            acountRecipient = Console.ReadLine();
            Console.WriteLine("Введите переводимую сумму: ");
            transferredAmount = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            return new Order();
        }

        public static List<Order> Sorted(List<Order> array)
        {
            var sortedUsers = from u in array
                              orderby u.transferredAmount descending
                              select u;
            return new List<Order>();
        }
        public static void Print(List<Order> array)
        {
            double summa = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < array.Count; i++)
            {
                if (summa < array[i].transferredAmount)
                {
                    Console.WriteLine(array[i].acountPayer);
                    Console.WriteLine(array[i].transferredAmount);
                }
            }
        }

    }

    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            List<Order> arr = new List<Order>();
            do
            {
                arr.Add(new Order());
                arr[i].InputData();
                Console.WriteLine("Закончить ввод данных - Esc Продолжить - Enter");
                i++;
                continue;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("Для продолжения нажмите Enter");
            Order.Sorted(arr);         
            Console.ReadLine();
            Console.WriteLine("Введите сумму транзакции грн. для получения доп.информации: ");
            Order.Print(arr);                      
            Console.ReadLine();
        }
    }
}
