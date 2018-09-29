using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerClass
{
    class WorkerYearOfEmploymentConditionPrint
    {
        public static void PrintWorkersWithYearOfEmploymentCondition(Worker[] workerArray)
        {
            Console.WriteLine("Insert worker's year of employment to filter");
            try
            {
                int filterYear = int.Parse(Console.ReadLine());
                for (int i = 0; i < workerArray.Length; i++)
                {
                    if (workerArray[i].WorkerYearOfEmployment > filterYear)
                    {
                        Console.WriteLine(workerArray[i].ToString());
                    }
                }
            }
            catch
            {
                Console.WriteLine("Insert a number, please\n");
            }
       }
    }
}

