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
            Worker worker = new Worker();
            //Worker[] workerArray = new Worker[] { new Worker("HerringhtonBR", "Aniki", 1995), new Worker("BoyND", "Dungeon master", 2005), new Worker("MarkWF", "Boss of this gym", 2003) };
            Worker[] workerArray = WorkerInput.GetInputData();
            for (int i = 0; i < workerArray.Length; i++)
            {
                Console.WriteLine(workerArray[i].ToString());
            }
                Console.WriteLine();
            WorkerSurnameSort.SortWorkerArrayBySurname(ref workerArray);
            for (int j = 0; j < workerArray.Length; j++)
            {
                Console.WriteLine(workerArray[j].ToString());
            }
                Console.WriteLine();
            WorkerYearOfEmploymentConditionPrint.PrintWorkersWithYearOfEmploymentCondition(workerArray);     
                Console.ReadKey();
            }
        }
    }

