using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prise
{
    class SortPrice
    {
        public IOrderedEnumerable<CPrise> SotrSearch(CPrise[] price_, string inputProduct_)
        {
            var selectedorder = from t in price_ // определяем каждый объект из teams как t
                                where t.nameProduct == inputProduct_
                                orderby t.nameProduct  // упорядочиваем по возрастанию
                                select t; // выбираем объект

            return selectedorder;
        }   
    }
}
