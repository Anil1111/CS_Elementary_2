using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._4.Classes
{
    public class Client
    {
        private string clientName;
        private double clientBalance;
        private bool isBlackMark;
        private string clientAddress;

        public Client(string clientName, double clientBalance, string clientAddress, bool isBlackMark = false)
        {
            this.clientName = clientName;
            this.clientBalance = clientBalance;
            this.clientAddress = clientAddress;
            this.isBlackMark = isBlackMark;
        }

        public string ClientName { get => clientName;}
        public double ClientBalance { get => clientBalance; set => clientBalance = value; }
        public bool IsBlackMark { get => isBlackMark; set => isBlackMark = value; }
        public string ClientAddress { get => clientAddress; set => clientAddress = value; }

        //public Order SetOrder(List<Product>products)
        //{
        //    Order order = new Order();
        //    return Order;
        //}

        public void ShowClient()
        {
            Console.WriteLine(new string('*', 70));
            Console.WriteLine($"Client: {ClientName} | Balance: {ClientBalance} | BlackMark: {IsBlackMark}");
            Console.WriteLine(new string('*', 70));
        }
    }
}
