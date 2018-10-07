using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerClass
{
    class Program
    {
        static void Main(string[] args)
        {
            OutPutInformation(InputInfornation());

            Console.ReadKey();
        }

        private static Worker[] InputInfornation()
        {
            int id_ = 1;
            Console.Write("Введите кол-во сотрудников: ");
            id_ = Convert.ToInt16(Console.ReadLine());

            Console.Clear();

            AddWorker workerInsert = new AddWorker();

            Worker[] workerAdd = new Worker[id_]; //массив для новых платежек
            Worker[] workerShow = new Worker[id_]; //возвращаемый массив для работы (сортировка, поиск)

            for (int i = 0; i < id_; i++)
            {
                workerShow = workerInsert.InsertWorker(workerAdd, id_, i); // Добавляю в массив платежей
            }

            return workerShow;
        }

        private static void OutPutInformation(Worker[] workerShow)
        {
            Console.WriteLine();
            Console.Write("Введите стаж работы: ");
            double inputStag = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(new string('-', 30) + "Упорядочивание по алфавиту фамилии работников;:" + new string('-', 30));
            foreach (var element in new SortWorker().SotrWork(workerShow, inputStag)) // вывожу отсортированный результат
            {
                Console.WriteLine(@"ФИО работника: {0}", element.famWorker);
                Console.WriteLine(@"Стаж работника: {0} г.", element.stagWork);
            }
        }
    }
}
