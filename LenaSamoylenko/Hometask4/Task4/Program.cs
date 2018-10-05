using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static protected DocumentWorker workWithDocument;
        static public DocumentWorker WorkWithDocument { get { return workWithDocument; } set { workWithDocument = value; } }
        static void Main(string[] args)
        {
            Dictionary<string, string> key = new Dictionary<string, string>()
            {
                ["Pro"] = "1234567890",
                ["Exp"] = "0987654321",
                ["UsuallUser"] = ""
            };
            string inputKey = Helper.Query("Hello, put the key, please");
   
            if (inputKey == key["Pro"])
            {
                workWithDocument = new ProDocumentWorker();
                workWithDocument.OpenDocument();
                workWithDocument.EditDocument();
                workWithDocument.SaveDocument();
            }
            else if (inputKey == key["Exp"])
            {
                workWithDocument = new ExpertDocumentWorker();
                workWithDocument.OpenDocument();
                workWithDocument.EditDocument();
                workWithDocument.SaveDocument();
            }
            else if (inputKey == key["UsuallUser"])
            {
                workWithDocument = new DocumentWorker();
                workWithDocument.OpenDocument();
                workWithDocument.EditDocument();
                workWithDocument.SaveDocument();
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();


        }


        static class Helper
        {

            internal static string Query(string message1)
            {
                Console.WriteLine(message1);
                string inputKey = Console.ReadLine();
                return inputKey;
            }


        }

    }
}