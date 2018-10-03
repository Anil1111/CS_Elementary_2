using System;

namespace Task3
{
    partial class Prises
    {
        class Program
        {
            static void Main(string[] args)
            {
                string prName = null;
                string nameShop = null;
                double cost = 0;
                Prises product = new Prises();
                //Цикл для записи новых элементов в список
                do
                {
                    Console.Clear();
                    Console.WriteLine("Введите название нового товара : ");
                    prName = Console.ReadLine();
                    Console.WriteLine("Введите название магазина : ");
                    nameShop = Console.ReadLine();
                    Console.WriteLine("Введите цену нового товара в грн. : ");
                    cost = Convert.ToDouble(Console.ReadLine());
                    Prise pr = new Prise(prName, nameShop, cost);
                    product.inputUserData(pr);
                    Console.WriteLine("Для окончания ввода нажмите Esc, для продолжения Enter");
                }

                while (Console.ReadKey().Key != ConsoleKey.Escape);
                Console.Clear();
                Console.WriteLine("Товары в наличии : ");
                product.PrintIsSort();
                Console.WriteLine("Введите название товара для получения доп. информации : ");
                product.Print();
                Console.ReadLine();
            }
        }
    }
}
