using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerClass
{
    class WorkerInput
    {
        public static Worker[] GetInputData()
        {
            Console.WriteLine("Please, insert number of workers");
            int n = int.Parse(Console.ReadLine());
            Worker[] workerArray = new Worker[n];
            for (int i = 0; i < workerArray.Length; i++)
            {
                workerArray[i] = new Worker();
            }
            Console.WriteLine(@"Please, insert data about workers in this format: ""Surname and initials, position, year of employment""");
            for (int i = 0; i < workerArray.Length; i++)
            {
                string temp = Console.ReadLine();
                string[] substrings = temp.Split(',');
                workerArray[i].WorkerSurnameAndInitials = substrings[0];
                workerArray[i].WorkerPosition = substrings[1];
                workerArray[i].WorkerYearOfEmployment = int.Parse(substrings[2]);
            }
            return workerArray;
        }
    }
}
