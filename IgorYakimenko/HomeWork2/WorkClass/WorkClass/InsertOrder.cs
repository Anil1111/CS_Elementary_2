using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkClass
{   
    class InsertOrder
    {
        
        readonly string txtPayer = "Введите счет отправителя: ";                         //Поля для чтения "меню"
        readonly string txtNamePayer = "Введите ФИО отправителя: ";
        readonly string txtAddressPayer = "Введите адрес отправителя: ";
        readonly string txtInnPayer = "Введите ИНН отправителя: ";
        readonly string txtRecipient = "Введите счет получателя: ";
        readonly string txtSummPayer = "Введите сумму получателя: ";        
             

        public Order[] AddOrder(Order[] order_, int id_, int i)
        {
           
            order_[i] = new Order();

            Console.WriteLine(new string(' ', 40) + "Введите платежку № {0}", i + 1);            
            Console.Write(txtPayer);            
            order_[i].AccPayer = Convert.ToInt16(Console.ReadLine());

            Console.Write(txtNamePayer);
            order_[i].NamePayer = Console.ReadLine();

            Console.Write(txtAddressPayer);
            order_[i].AddressPayer = Console.ReadLine();

            Console.Write(txtInnPayer);
            order_[i].InnPayer = Convert.ToInt16(Console.ReadLine());

            Console.Write(txtRecipient);
            order_[i].AccRecipient = Convert.ToInt16(Console.ReadLine());

            Console.Write(txtSummPayer);
            order_[i].SummPayer = Convert.ToDouble(Console.ReadLine());
            
            return order_;
        }
    }
}
