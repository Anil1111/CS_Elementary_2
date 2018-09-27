using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerClass
{
    class WorkerSurnameSort
    {
        public static void SortWorkerArrayBySurname(ref Worker[] workerArray)
        {
            List<Worker> workerList = workerArray.ToList().OrderBy(x => x.WorkerSurnameAndInitials).ToList();
            workerArray = workerList.ToArray();
            Console.WriteLine("Array of workers was sorted by surname\n");
        }
    }
}
