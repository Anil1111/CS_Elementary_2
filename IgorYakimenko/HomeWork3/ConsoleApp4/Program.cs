using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        //4 - Разработать систему «Интернет-магазин». Товаровед добавляет информацию о Товаре. 
        //    Клиент делает и оплачивает Заказ на Товары. 
        //    Товаровед регистрирует Продажу и может занести неплательщика в «черный список».
        static void Main(string[] args)
        {

            Int16 id = 1;
            Int16 idOrder = 1;
            string name = string.Empty;
            string fioClient = string.Empty;
            string nameOrder = string.Empty;
            Int16 count = 0;
            Int16 countOrder = 0;
            double unitPrice = 0;
            double priceOrder = 0;
            List<Merchandiser> merchandiserList = new List<Merchandiser>();

            Console.WriteLine("Нажмите Esc для окончания ввода:");
            Console.WriteLine();

            Console.WriteLine("Товаровед:");
            ConsoleKeyInfo input;
            do
            {
                Console.WriteLine(@"Введите данные по {0}-му товару: ", id);
                
                Console.Write("Нименование товара: ");
                name = Console.ReadLine();
                Console.Write("Кол-во товара: ");
                count = Convert.ToInt16(Console.ReadLine());

                Console.Write("Цена за единицу товара: ");
                unitPrice = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(new string('-', 50));

                Merchandiser merchandiser = new Merchandiser(id, name, count, unitPrice);
                merchandiserList.Add(merchandiser);
                
                id++;
                input = Console.ReadKey();
            } while (input.Key != ConsoleKey.Escape);

            List<Сlient> clientList = new List<Сlient>();

            Console.WriteLine("Нажмите Esc для окончания ввода:");
            Console.WriteLine();

            Console.WriteLine("Клиент:");
            do
            {
                Console.WriteLine(@"Введите данные по {0}-му заказу: ", idOrder);
                Console.Write("Фио клиента: ");
                fioClient = Console.ReadLine();
                Console.Write("Нименование товара: ");
                nameOrder = Console.ReadLine();
                Console.Write("Кол-во товара: ");
                countOrder = Convert.ToInt16(Console.ReadLine());

                Console.Write("Цена за единицу товара: ");
                priceOrder = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(new string('-', 50));

                Сlient client = new Сlient(idOrder, fioClient,nameOrder, countOrder, priceOrder);
                clientList.Add(client);

                idOrder++;
                input = Console.ReadKey();
            } while (input.Key != ConsoleKey.Escape);


            foreach (var element in clientList)
            {
                Console.WriteLine(@"Номер заказа {0}", element.IdOrder); 
                Console.WriteLine(@"Фио клиента {0}",element.Fio);
                Console.WriteLine(@"Наименование заказа {0}",element.Naim);
                Console.WriteLine(@"Сумма оплаты {0}", element.Price);
                Console.WriteLine(new string('-', 50));
            }

            List<Сlient> BlackclientList = new List<Сlient>();
            Console.WriteLine("Список ограничения:");
            fioClient = string.Empty;

            do
            {
                Console.Write(@"Выберите клиента для внесения в список ограничения: ");
                fioClient = Console.ReadLine();
                
                Console.WriteLine(new string('-', 50));

                Сlient Blackclient = new Сlient(0, fioClient, "", 0, 0);
                BlackclientList.Add(Blackclient);

                input = Console.ReadKey();
            } while (input.Key != ConsoleKey.Escape);

            Console.WriteLine("Клиенты попавшие в черный список:");
            foreach (var element in clientList)
            {
 
                Console.WriteLine(@"Фио клиента {0}", element.Fio);
                Console.WriteLine(new string('-', 50));
            }

            Console.ReadKey();
        }
    }
}
