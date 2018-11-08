using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._4.Classes
{
    public class Merchandise
    {
        private string name;

        public Merchandise(string name)
        {
            this.name = name;
        }

        //Добавление нового товара
        public void AddProduct(Product product, Products products)
        {
            products.listProducts.Add(product);
        }

        //Добавление товара в список товаров для заказа
        public bool AddProductToProductList(Product product, Products products)
        {
            if (product.ProductQuantity <= products.listProducts.Find(x => x.ProductTitle == product.ProductTitle).ProductQuantity)
            {
                Console.WriteLine($"Product {product.ProductTitle} can be successfully added to products list");
                products.listProducts.Find(x => x.ProductTitle == product.ProductTitle).ProductQuantity -= product.ProductQuantity;
                return true;
            }
            else
            {
                Console.WriteLine($"Wrong {product.ProductTitle} quantity");
                return false;
            }

        }

        //Внесение/удаление из чернго списка
        public void SetBlackMark(Client client, bool mark)
        {
            client.IsBlackMark = mark;
        }

        //Добавление клиента в список клиентов
        public void AddClient(Client client, List<Client> clients)
        {
            if (!IsClientExists(client, clients))
            {
                clients.Add(client);
                Console.WriteLine($"Client {client.ClientName} successfully added");
            }
            else
            {
                Console.WriteLine($"Client {client.ClientName} already exists");
            }
        }

        //Проверка, существует ли клиент в базе
        public bool IsClientExists(Client client, List<Client> listClients)
        {
            foreach (Client clientInCollection in listClients)
            {
                if (clientInCollection.ClientName == client.ClientName) return true;
            }
            return false;
        }

        public bool IsSalesRegistration(Order order)
        {
            double orderPrice = 0;
            //считаем сумму заказа
            foreach (var product in order.ListProducts)
            {
                orderPrice += product.ProductQuantity * product.ProductPrice;
            }
            Console.WriteLine($"Order price is {orderPrice}");
            //если сумма заказа превышает баланс клиента
            if (orderPrice > order.Client.ClientBalance)
            {
                SetBlackMark(order.Client, true);   //ставим клиенту черную метку
                return false;
            }
            else
            {
                //уменьшаем сумму баланса клиента
                order.Client.ClientBalance -= orderPrice;
                order.IsPaid = true;
                order.IsCompleted = true;
                Console.WriteLine($"Order {order.OrderNumber} was paid and completed");
                return true;
            }
        }
    }
}
