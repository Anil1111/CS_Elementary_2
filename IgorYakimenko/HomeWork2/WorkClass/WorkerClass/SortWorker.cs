using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerClass
{
    class SortWorker
    {
        public IOrderedEnumerable<Worker> SotrWork(Worker[] worker__, double inputStag_)
        {
            var selectedorder = from t in worker__ // определяем каждый объект из teams как t
                                where t.stagWork >= inputStag_
                                orderby t.famWorker  // упорядочиваем по возрастанию
                                select t; // выбираем объект

            return selectedorder;
        }   
    }
}
