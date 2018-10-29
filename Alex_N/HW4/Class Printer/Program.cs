using System;

namespace Class_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer test = new Printer();
            do
            {
                Console.Clear();
                Console.WriteLine($"Выберите цвет и введите предложение:\n1-Красный\n2-Зеленый\n3-Синий\n4-Обычный");

                switch (Console.ReadLine())
                {
                    case "1":
                        test = new PrinterRed(); //апкаст дай бох ему здоровья
                        PrinterRed redOutput = (PrinterRed)test;//даункаст без апкаста никуда
                        redOutput.Print(Console.ReadLine());
                        break;
                    case "2":
                        test = new PrinterGreen();
                        PrinterGreen greenOutput = (PrinterGreen)test;
                        greenOutput.Print(Console.ReadLine());
                        break;
                    case "3":
                        test = new PrinterBlue();
                        PrinterBlue blueOutput = (PrinterBlue)test;
                        blueOutput.Print(Console.ReadLine());
                        break;
                    case "4":
                        test = new Printer(); //Думаю как-то так. Задача то была раздуплиться с приведениями. БУ!!!
                        test.Print(Console.ReadLine());
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("ВРЕВЕД!!! ТЫ ВВЕЛ КАКУЮ-ТО ДИЧЕ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\nЭСКАПЭ - ВЫХаДНАХ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);



            
        }
    }
}
