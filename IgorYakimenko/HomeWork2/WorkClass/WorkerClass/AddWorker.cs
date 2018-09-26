using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerClass
{
    class AddWorker
    {

        readonly string txtFamWorker = "Введите фамилию и инициалы работника: ";                         //Поля для чтения "меню"
        readonly string txtPostWorker = "Введите название занимаемой должности: ";
        readonly string txtYearStartWorker = "Введите год поступления на работу: ";


        public Worker[] InsertWorker(Worker[] worker_, int id_, int i)
        {
            worker_[i] = new Worker();

            Console.WriteLine(new string(' ', 40) + "Введите данные по {0} работнику" , i + 1);
            Console.Write(txtFamWorker);
            worker_[i].famWorker = Console.ReadLine();

            Console.Write(txtPostWorker);
            worker_[i].postWorker = Console.ReadLine();

            Console.Write(txtYearStartWorker);
            worker_[i].yearStartWork = Convert.ToInt16(Console.ReadLine());

            worker_[i].stagWork = System.DateTime.Now.Year - worker_[i].yearStartWork;  

            return worker_;
        }
    }
}
