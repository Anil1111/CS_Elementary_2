using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Hometask7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool operationBeggin = true;

            while (operationBeggin)
            {
                WorkWithFile firstSeance = new WorkWithFile();
                //firstSeance.ExecuteOperationCreate();
                //firstSeance.ExecuteOperationChange();
                firstSeance.ExecuteOperationOpen();
                firstSeance.ExecuteOperationSave();

                //пример C:\1.xml

                Console.WriteLine("Do you wan to continue true/false");
                try
                {
                    operationBeggin = Convert.ToBoolean(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error with the answer");
                    break;
                }
            }

            Console.ReadKey();

        }

    }
}

