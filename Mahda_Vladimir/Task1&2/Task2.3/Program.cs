using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Определить класс с именем Price содержащую следующие поля:
//- название товара;
//- название магазина, в котором продается товар;
//- стоимость товара в грн.
//методы:
//- ввод данных в массив из n элементов в типа Price;
//- упорядочить в алфавитном порядке по названиям товаров;
//- вывод информации о товаре, название которого ввел пользователь.

namespace Task2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Prices prices = new Prices();

            Price price1 = new Price("Milk", "Varus", 25.5);
            Price price2 = new Price("Bread", "ATB", 9.9);
            Price price3 = new Price("Eggs", "Silpo", 32.2);
            Price price4 = new Price("Eggs", "Varus", 30.2);

            prices.AddDataToList(price1);
            prices.AddDataToList(price2);
            prices.AddDataToList(price3);
            prices.AddDataToList(price4);

            prices.PrintAllProducts();
            Console.WriteLine(new string('-', 55));
            prices.PrintPricesSortedByAlphabet();
            Console.WriteLine(new string('-', 55));
            prices.PrintUsersPrices();

            Console.ReadKey(); ;
        }
    }
}
