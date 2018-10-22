using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which type of document you wanna use?");
            string reader = Console.ReadLine();
            switch (reader)
            {
                case "doc":
                    DOCHandler doc = new DOCHandler();
                    break;
                case "xml":
                    XMLHandler xml = new XMLHandler();
                    break;
                case "txt":
                    TXTHandler txt = new TXTHandler();
                    break;
                default:
                    Console.WriteLine("Unknown format");
                    break;

            }
            Console.ReadLine();
        }
    }
}
