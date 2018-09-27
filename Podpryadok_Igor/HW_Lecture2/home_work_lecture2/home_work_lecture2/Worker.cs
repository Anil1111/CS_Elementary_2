using System;
using System.Collections.Generic;
using System.Text;

namespace home_work_lecture2
{
    class Worker
    {
        public string nameFO;
        public string job;
        public int startWork;
        private string firstName;
        private string lastName;
        private string otchestvo;

        public void zapisWorker()
        {
            Console.WriteLine("Введите Фамилию:");
            lastName = Console.ReadLine();
            nameFO += lastName;
            nameFO += " ";
            Console.WriteLine("Введите Имя");
            firstName = Console.ReadLine();
            firstName= firstName.Remove(1);
            firstName += ".";
            nameFO += firstName;
            Console.WriteLine("Введите Отчество:");
            otchestvo = Console.ReadLine();
            otchestvo = otchestvo.Remove(1);
            otchestvo += ".";
            nameFO += otchestvo;
            Console.WriteLine("Введите должность:");
            job = Console.ReadLine();
            Console.WriteLine("Введите год начала работы:");
            startWork = Convert.ToInt32(Console.ReadLine());
        }

        public int CompareTo(object w)//Sortirovka s pomoshiy interfeisa
        {
            Worker or = w as Worker;
            if (or != null)
                return this.nameFO.CompareTo(or.nameFO);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}
