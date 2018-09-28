using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderClass
{
    class OrderTranzactionSumConditionPrint
    {
        public static void PrintOrdersWithSumCondition(Order[] orderArray)
        {
            Console.WriteLine("Insert sum to filter");
            try
            {
                int sum = int.Parse(Console.ReadLine());
                for (int i = 0; i < orderArray.Length; i++)
                {
                    if (orderArray[i].TranzactionSum >= sum)
                        Console.WriteLine(("Payer account " + orderArray[i].PayerAccount + " Beneficiary account " + orderArray[i].BeneficiaryAccount + " Tranzaction sum " + orderArray[i].TranzactionSum).ToString());
                }
            }
            catch
            {
                Console.WriteLine("Insert a number please\n");
            }
            
        }
    }
}
