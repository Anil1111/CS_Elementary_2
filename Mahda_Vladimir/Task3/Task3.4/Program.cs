using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3._4.Classes;

//Разработать систему «Интернет-магазин». Товаровед добавляет информацию о Товаре.Клиент делает
//и оплачивает Заказ на Товары.Товаровед регистрирует Продажу и может занести неплательщика в
//«черный список».

namespace Task3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Milk = new Product("Milk", 20, "Fresh milk", 10);
            Product Egg = new Product("Egg", 1.5, "Eggs", 120);
            Product Pork = new Product("Pork", 100, "Meat", 30);
            Product Beef = new Product("Beef", 120, "Meat", 10);

            Products productsInStore = new Products();

            Merchandise Gapka = new Merchandise("Gapka");
            Clients clients = new Clients();

            //добавляем продукты в магазин
            Gapka.AddProduct(Milk, productsInStore);
            Gapka.AddProduct(Egg, productsInStore);
            Gapka.AddProduct(Pork, productsInStore);
            Gapka.AddProduct(Beef, productsInStore);
            Products.ShowProducts("<-- Products in store -->", productsInStore.listProducts);

            //создаем новых клментов
            Client Petro = new Client("Petro", 1024, "Zhitomir", false);
            Client Dmitro = new Client("Dmitro", 150, "Rivne", false);
            Gapka.AddClient(Petro, clients.ListClients);
            Gapka.AddClient(Dmitro, clients.ListClients);
            clients.ShowClients();

            //создаем новый заказ
            Products prodInOrder = new Products();
            Product MilkToOrder = new Product("Milk", 20, "Fresh milk", 1);
            Product PorktoOrder = new Product("Pork", 100, "Meat", 1.5);
            if (Gapka.AddProductToProductList(MilkToOrder, productsInStore))
            {
                prodInOrder.listProducts.Add(MilkToOrder);
            }
            if (Gapka.AddProductToProductList(PorktoOrder, productsInStore))
            {
                prodInOrder.listProducts.Add(PorktoOrder);
            }
            Products.ShowProducts("<-- Products in order -->", prodInOrder.listProducts);
            Order order1 = new Order(Petro, prodInOrder.listProducts, false, false);
            order1.ShowOrder();

            //регистрируем заказ и по возможности выполняем
            if (Gapka.IsSalesRegistration(order1))
            {
                Console.WriteLine("<--- Sales complete --->");
                Products.ShowProducts("<-- Products in store -->", productsInStore.listProducts);
            }
            else
            {
                Console.WriteLine("<--- Order cancelled --->");
            }
            Petro.ShowClient();

            //второй заказ
            Order order2 = new Order(Dmitro, prodInOrder.listProducts, false, false);
            order2.ShowOrder();

            if (Gapka.IsSalesRegistration(order2))
            {
                Console.WriteLine("<--- Sales complete --->");               
                Products.ShowProducts("<-- Products in store -->", productsInStore.listProducts);
            }
            else
            {
                Console.WriteLine($"<--- Order cancelled ({order2.Client.ClientName} hasn't enought money)--->");
            }
            Dmitro.ShowClient();

            Console.ReadKey();
        }
    }
}
