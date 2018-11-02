using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Hillel
{
    class Persons
    {
        public List<Person> persons;//
        public Persons()//
        {
            persons = new List<Person>();//
        }
        public void inputUserData(Person newPrise)//Добавляем элементы в список типа Prise
        {
            persons.Add(newPrise);
        }
    }
}
