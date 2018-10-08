using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(
                name: "Сергей",
                adress: "Мира, 12",
                balance: 100000,
                spent: 550
                );

            Console.WriteLine("Список товаров");
            Console.WriteLine();

            Dolls dolls = new Dolls(
                name: "Барби",
                price: 200,
                manufacturer: "Ukraine Toys",
                material: "резина"
                );

            Console.WriteLine("Кукла");
            Console.WriteLine("Название: " + dolls.Name);
            Console.WriteLine("Цена: " + dolls.Price);
            Console.WriteLine("Производитель: " + dolls.Manufacturer);
            Console.WriteLine("Материал: " + dolls.Material);
            Console.WriteLine(new string('-', 25));
            Console.WriteLine();

            Beyblade beyblade = new Beyblade(
                name: "Рюга",
                price: 300,
                manufacturer: "Ukraine Toys",
                power: 85
                );

            Console.WriteLine("Бейблэйд");
            Console.WriteLine("Название: " + beyblade.Name);
            Console.WriteLine("Цена: " + beyblade.Price);
            Console.WriteLine("Производитель: " + beyblade.Manufacturer);
            Console.WriteLine("Сила: " + beyblade.Power);
            Console.WriteLine(new string('-', 25));
            Console.WriteLine();

            Transformer transformer = new Transformer(
                name: "Оптимус Прайм",
                price: 550,
                manufacturer: "Ukraine Toys",
                classOfFighter: "Автобот"
                );

            Console.WriteLine("Трансформер");
            Console.WriteLine("Название: " + transformer.Name);
            Console.WriteLine("Цена: " + transformer.Price);
            Console.WriteLine("Производитель: " + transformer.Manufacturer);
            Console.WriteLine("Класс: " + transformer.ClassOfFighter);
            Console.WriteLine(new string('-', 25));
            Console.WriteLine();

            Product[] products = new Product[] {
                dolls,
                beyblade,
                transformer
            };

            Informer informer = new Informer();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Здравствуйте {user.Name} ваш баланс {user.Balance}");

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                }
                Console.WriteLine("Выберете номер товара и нажмите Enter:");

                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);

                if (productNumber >= 0 && productNumber < products.Length)
                {

                    if (products[productNumber].Price < user.Balance)
                    {
                        informer.Buy(user, products[productNumber]);
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }

                }
                else
                {
                    Console.WriteLine("Таких товаров нет");
                }
            }


            Console.ReadLine();
        }
    }
}
