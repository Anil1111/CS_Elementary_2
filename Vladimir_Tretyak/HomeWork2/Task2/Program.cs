using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Worker
    {
        public string last_Name;
        public string current_Position;
        public int year_of_Employment;
        public Worker InputData()
        {
            Console.WriteLine("Введите фамилию и инициалы работника: ");
            last_Name = Console.ReadLine();
            Console.WriteLine("Введите название должности: ");
            current_Position = Console.ReadLine();
            Console.WriteLine("Введите год поступления на работу: ");
            try
            {
                year_of_Employment = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неверный ввод! Нажмите Enter для повторения...");
                InputData();
            }
            Console.Clear();
            return new Worker();
        }
    }
    class Sorted
    {
        public List<Worker> sorted(List<Worker> workers)
        {
            var result = from worker in workers
                         orderby worker.last_Name
                         select worker;
            return result.ToList();
        }
    }
    class Work_experience
    {
        public void compare(List<Worker> worker)
        {
            Console.Write("Введите стаж работника - ");
            int yearNow = DateTime.Now.Year;
            int numberConsole = Convert.ToInt32(Console.ReadLine());
            foreach (Worker w in worker)
            {
                if (numberConsole < yearNow - w.year_of_Employment)
                {
                    Console.WriteLine(w.last_Name + " - " + w.current_Position + ", Поступил в - " + w.year_of_Employment);
                }
            }
        }
    }
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>();
            do
            {
                workers.Add(new Worker());
                workers[i].InputData();
                Console.WriteLine("Закончить ввод данных - Esc Продолжить - Enter");
                i++;
                continue;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            Sorted sort = new Sorted();
            List<Worker> workers_sort = sort.sorted(workers);
            Work_experience print = new Work_experience();
            print.compare(workers_sort);
            Console.ReadLine();
        }
    }
}