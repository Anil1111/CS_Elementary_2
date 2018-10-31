using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._4.Classes
{
    public class Order
    {
        static int orderNumber = 0;
        private Client client;
        private List<Product> listProducts;
        private bool isPaid;
        private bool isCompleted;

        public Order(Client client, List<Product> listProducts, bool isPaid, bool isCompleted)
        {
            orderNumber++;
            this.client = client;
            this.listProducts = listProducts;
            this.isPaid = isPaid;
            this.isCompleted = isCompleted;
        }

        public int OrderNumber { get => orderNumber; }
        //public List<Product> listProducts
        public bool IsPaid { get => isPaid; set => isPaid = value; }
        public bool IsCompleted { get => isCompleted; set => isCompleted = value; }
        public List<Product> ListProducts { get => listProducts; }
        public Client Client { get => client; }

        public void ShowOrder()
        {
            Console.WriteLine($"Order number {orderNumber} | Customer: {Client.ClientName} | Paid: {IsPaid} | Completed: {IsCompleted}");
            Products.ShowProducts("products in order:", ListProducts);
        }
    }
}
