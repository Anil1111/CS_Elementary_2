using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prise
{
    class Program
    {
        static void Main(string[] args)
        {
            int id_ = 1;
            Console.Write("Введите кол-во товара: ");
            id_ = Convert.ToInt16(Console.ReadLine());

            Console.Clear();

            PriceInsert priceInsert = new PriceInsert();

             CPrise[] produktAdd = new CPrise[id_]; //массив для новых ...
             CPrise[] produktShow = new CPrise[id_]; //возвращаемый массив для работы (сортировка, поиск)

            for (int i = 0; i < id_; i++)
            {
                produktShow = priceInsert.InsertNewRec(produktAdd, id_, i); // Добавляю в массив ...
            }

            Console.WriteLine();
            Console.Write("Введите названиям товаров: ");
            string inputProduct_ = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(new string('-', 30) + "Упорядочивание в алфавитном порядке по названиям товаров:" + new string('-', 30));
            foreach (var element in new SortPrice().SotrSearch(produktShow, inputProduct_)) // вывожу отсортированный результат
            {
                Console.WriteLine(@"Название магазина: {0}", element.nameShop);
                Console.WriteLine(@"Название товара: {0}", element.nameProduct);
                Console.WriteLine(@"Стоимость товара в грн. : {0}", element.priceProduct);
            }

            Console.ReadKey();
        }
    }
}
