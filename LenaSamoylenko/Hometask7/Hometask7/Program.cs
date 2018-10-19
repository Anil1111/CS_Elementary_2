using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hometask7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<int, string> allFormats = new Dictionary<int, string>(3);
            allFormats.Add(1, "doc");
            allFormats.Add(2, "txt");
            allFormats.Add(3, "xml");
            bool operationBeggin = true;

            while (operationBeggin)
            {
                string fileLocation;
                int fileFormatInDictionary;
                try
                {
                    Console.WriteLine("Put your file location");
                    fileLocation = Console.ReadLine();
                    string fileFormat = fileLocation.Split('.').Last();

                    fileFormatInDictionary = ((allFormats.Where(f => f.Value == fileFormat)).Select(f => f.Key)).First();
                    //как-то организовать проверку на файловую систему, слешы там и все такое
                }
                catch
                {
                    Console.WriteLine("Error");
                    break;
                }

                //пример C:\Users\Admin\Documents\проба пера1.txt

                switch (fileFormatInDictionary)
                {
                    case 1:
                        DOCHandler user1 = new DOCHandler();
                        user1.Open(fileLocation);
                        break;
                    case 2:
                        TXTHandler user2 = new TXTHandler();
                        user2.Open(fileLocation);
                        break;
                    case 3:
                        XMLHandler user3 = new XMLHandler();
                        user3.Open(fileLocation);
                        break;
                    default:
                        Console.WriteLine("Some error");
                        break;
                }


                Console.ReadKey();


            }

        }
    }
}
