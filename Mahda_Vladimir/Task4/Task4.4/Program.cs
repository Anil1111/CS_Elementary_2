using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4._4.Classes;

namespace Task4._4
{
    class Program
    {
        public static int InputUsersKey()
        {
            int key;
            do
            {
                if (!Int32.TryParse(Console.ReadLine(), out key))
                {
                    Console.WriteLine("Ошибка ввода");
                    Console.WriteLine("Введите целое число от 0 до 2-х");
                }
                else if ((key < 0) || (key>2))
                {
                    Console.WriteLine("Введите целое число от 0 до 2-х");
                }
                else
                {
                    return key;
                }
            } while (true);
        }
        public enum version
        {
            Base, Pro, Expert
        }

        static void Main(string[] args)
        {
            int key;
            DocumentWorker documentWorker;

            Console.WriteLine("Введите ключ пользователя");
            Console.WriteLine("0 - базовый, 1 - Pro, 2 - Expert");
            key = InputUsersKey();

            if (key == (int)version.Base)
            {
                documentWorker = new DocumentWorker();
            }
            else if (key == (int)version.Pro)
            {
                documentWorker = new ProDocumentWorker();
            }
            else
            {
                documentWorker = new ExpertDocumentWorker();
            }

            documentWorker.Show();
            Console.ReadKey();
        }
    }
}
