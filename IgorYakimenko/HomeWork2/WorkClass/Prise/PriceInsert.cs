using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prise
{
    class PriceInsert
    {
        readonly string txtnameProduct = "Введите название товара: ";                         //Поля для чтения "меню"
        readonly string txtnameShop = "Введите название магазина, в котором продается товар: ";
        readonly string txtpriceProduct = "Введите стоимость товара в грн.: ";


        public CPrise[] InsertNewRec(CPrise[] prise_, int id_, int i)
        {
            prise_[i] = new CPrise();

            Console.WriteLine(new string(' ', 40) + "Введите данные по {0}-му товару", i + 1);
            Console.Write(txtnameProduct);
            prise_[i].nameProduct = Console.ReadLine();

            Console.Write(txtnameShop);
            prise_[i].nameShop = Console.ReadLine();

            Console.Write(txtpriceProduct);
            prise_[i].priceProduct = Convert.ToDouble(Console.ReadLine());

            return prise_;
        }
    }
}
