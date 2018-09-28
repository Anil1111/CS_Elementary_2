using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class order
    {
        private Int16 AccPayer { get; set; }
        private string NamePayer { get; set; }
        private string AddressPayer { get; set; }
        private Int16 InnPayer { get; set; }
        private float SummPayer { get; set; }

        private Int16 AccRecipient { get; set; }
        private string NameRecipient { get; set; }
        private string AddressRecipient { get; set; }
        private Int16 InnRecipient { get; set; }
        private float SummRecipient { get; set; }


        //public void Transfer(float summP,float summR)
        //{

        //}

        public void PaymentOrder(Int16 AccPayer, Int16 AccRecipient, float SummPayer)
        {
            this.AccPayer = AccPayer;
            this.AccRecipient = AccRecipient;
            this.SummPayer = SummPayer; 
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            order order_ = new order();
            int i = 0;
            while (true)
            {
                Console.WriteLine("Введите платежку №{0}",i);
                //order_.PaymentOrder(
                if (Console.Read().ToString() == "Exit")
                {
                    break;
                }
            }

            //int[] masiv = { 1, 6, 0, 7, 5, 8, 3, 8, 5, 7, 4, 2, 4, 7, 3, 5, 7, 7, 4, 2, 9 };
            //for (int i = 0; i < masiv.Length; i++)
            //{
            //    Console.Write(masiv[i] + " ");
            //}

            //Array.Sort(masiv);
            ////Array.Reverse(masiv); 
            //Console.WriteLine();

            //for (int i = 0; i < masiv.Length; i++)
            //{
            //    Console.Write(masiv[i] + " ");
            //}
            //Console.Read();
        }
    }
}
