using System;
using System.IO;

// Создание/удаление файла.

namespace InputOutput
{
    class Program
    {
        static void Main()
        {
            // Создаем новый файл в корневом каталоге диска D:

            //new FileInfo(@"c:\bin\Test.txt").Create();

            var file = new FileInfo(@"c:\bin\Test.txt");

            FileStream stream = file.Create();

            //Выводим основную информацию о созданном файле.            
            Console.WriteLine("Full Name   : {0}", file.FullName);
            Console.WriteLine("Attributes  : {0}", file.Attributes.ToString());
            Console.WriteLine("CreationTime: {0}", file.CreationTime);

            Console.WriteLine("Нажмите любую клавишу для удаления файла.");
            Console.ReadKey();

            // Закрываем FileStream.
            stream.Close();

            // Удаляем файл.
            file.Delete();

            Console.WriteLine("Файл успешно удален.");

            // Delay.
            Console.ReadKey();
        }
    }
}
