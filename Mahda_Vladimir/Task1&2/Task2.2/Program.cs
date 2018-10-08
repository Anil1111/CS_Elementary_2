using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Определить класс с именем Worker, содержащую следующие поля:
//- фамилия и инициалы работника;
//- название занимаемой должности;
//- год поступления на работу.
//  методы:
//- ввод данных в массив из n элементов в типа Worker;
//- упорядочить по алфавиту фамилии работников;
//- вывод работников, чей стаж работы в фирме превышает значение, введенное   пользователем.

namespace Task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Workers workers = new Workers();

            Worker worker1 = new Worker("Ivanko P.P.", "manager", 2010);
            Worker worker2 = new Worker("Petrenko I.K.", "HR", 2015);
            Worker worker3 = new Worker("Gunko R.P.", "producer", 2012);

            workers.inputUserData(worker1);
            workers.inputUserData(worker2);
            workers.inputUserData(worker3);

            workers.showWorkers();
            Console.WriteLine(new string ('-', 59));
            workers.showWorkers(true);
            Console.WriteLine(new string('-', 59));
            workers.showWorkersWithExperience();

            Console.ReadKey();
        }
    }
}
