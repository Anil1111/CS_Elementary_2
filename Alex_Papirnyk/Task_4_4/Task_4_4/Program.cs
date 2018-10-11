using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_4
{
    class Program
    {
       static public void Print(DocumentWorker doc)
        {
            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();
        }
        
        static void Main(string[] args)
        {
            DocumentWorker doc = new DocumentWorker();
            Console.WriteLine("Введите ключ");
            string inputKey = Console.ReadLine();
            if(inputKey=="pro")
            {
                doc = new ProDocumentWorker();
                Print(doc);

            }
            else if(inputKey == "exp")
            {
                doc = new ExpertDocumentWorker();
                Print(doc);
            }
            else
            {
                Print(doc);
            }
            Console.ReadLine();
        }
    }
}
