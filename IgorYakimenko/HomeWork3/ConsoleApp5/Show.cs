using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Show
    {
        public IOrderedEnumerable<Enrollee> ShowStudent(List<Enrollee> order_, float avgGrade_)
        {
            var selectedorder = from t in order_ // определяем каждый объект из teams как t
                                where t.Grade >= avgGrade_
                                orderby t.Surname, t.Name, t.MiddleName // упорядочиваем по fio
                                select t; // выбираем объект

            return selectedorder;
        }
    }
}
