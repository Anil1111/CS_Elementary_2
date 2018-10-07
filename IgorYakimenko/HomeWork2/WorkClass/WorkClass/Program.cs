using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkClass
{
    class Program
    {
        static void Main(string[] args)
        {

            OutPutInformation(InputInfornation());
           
            Console.ReadKey();
        }

        private static Order[] InputInfornation()
        {

            int id_ = 1;
            Console.Write("Введите кол-во платежек: ");
            id_ = Convert.ToInt16(Console.ReadLine());

            Console.Clear();

            InsertOrder OrdInsert = new InsertOrder();

            Order[] orderAdd = new Order[id_]; //массив для новых платежек
            Order[] orderWork = new Order[id_]; //возвращаемый массив для работы (сортировка, поиск)

            for (int i = 0; i < id_; i++)
            {
                orderWork = OrdInsert.AddOrder(orderAdd, id_, i); // Добавляю в массив платежей
            }

            return orderWork;
        }

        private static void OutPutInformation(Order[] orderWork)
        {
            Console.WriteLine();
            Console.Write("Введите сумму: ");
            double inputSum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(new string('-', 30) + "Упорядоченные платежки по убыванию перечисляемой суммы:" + new string('-', 30));
            foreach (var element in new SortOrders().SotrOrder(orderWork, inputSum)) // вывожу отсортированный результат
            {
                Console.WriteLine(@"ФИО отправителя: {0}", element.NamePayer);
                Console.WriteLine(@"Сумма платежа: {0}", element.SummPayer);
            }

        }
    }
}