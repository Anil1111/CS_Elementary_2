using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2_1 Определить класс с именем Order содержащую следующие поля:
//- расчетный счет плательщика(формат уточнить в Интернете);
//- расчетный счет получателя;
//- перечисляемая сумма в грн.
//методы:
//- ввод данных в массив из n элементов в типа Order;
//- упорядочить по убыванию перечисляемой суммы;
//- вывод информации о тех плательщиках, перечисляемая сумма которых не меньше суммы, введенной пользователем.

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int count = 2;
            Orders orders = new Orders();
            int payerAccount = 0;
            int beneficiaryAccount = 0;
            double transferredAmount = 0;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(i + 1 + " order");
                Order.InputUsersData(out payerAccount, out beneficiaryAccount, out transferredAmount);
                Order order = new Order(payerAccount, beneficiaryAccount, transferredAmount);
                orders.InputUsersDataInListOrders(order);
            }
            orders.PrintAll();
            Console.WriteLine(new string ('-', 30));
            orders.PrintSortedOrdersByDescendingAmount();
            Console.WriteLine(new string('-', 30));
            Console.Write("Input condition : ");
            double userCondition = Convert.ToDouble(Console.ReadLine());
            orders.PrintOrdersMoreUserAmount(userCondition);

            Console.ReadKey();

        }
    }
}
