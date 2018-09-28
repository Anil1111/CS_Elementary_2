using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderClass
{
    class OrderInput
    {
        public static Order[] GetInputOrderData()
        {
            Console.WriteLine("Please insert number of orders");
            int n = int.Parse(Console.ReadLine());
            Order[] orderArray = new Order[n];
            for (int i = 0; i < n; i++)
            {
                orderArray[i] = new Order();
            }
            Console.WriteLine(@"Please isert data about orders in this forman ""Payer's account, beneficiary's account, tranzaction sum""");
            for (int i = 0; i < orderArray.Length; i++)
            {
                string buf = Console.ReadLine();

                string[] temp = new string[3];
                temp = buf.Split(',');
                try
                {
                    orderArray[i].PayerAccount = int.Parse(temp[0]);
                    orderArray[i].BeneficiaryAccount = int.Parse(temp[1]);
                    orderArray[i].TranzactionSum = int.Parse(temp[2]);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error " + ex.Message);
                }
            }
            return orderArray;
        }
    }
}
