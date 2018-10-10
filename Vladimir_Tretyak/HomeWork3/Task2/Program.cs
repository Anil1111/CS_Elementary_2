using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2 Класс Абонент: Идентификационный номер, Фамилия, Имя, Отчество, Адрес, Номер кредитной карточки, Дебет, Кредит, 
//    Время междугородных и городских переговоров;
//    Конструктор; Методы: установка значений атрибутов, получение значений атрибутов, вывод информации.
//    Создать массив объектов данного класса. 
//    Вывести сведения относительно абонентов,
//    у которых время городских переговоров превышает заданное.
//    Сведения относительно абонентов, которые пользовались междугородной связью. Список абонентов в алфавитном порядке.



namespace HW3Task2
{
    class Abonent
    {
        long idNumber;
        string lastName;
        string firstName;
        string midleName;
        string address;
        long cardNumber;
        int cardDebet;
        int cardCredit;
        IntercityTalkTime


        public long IdNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MidleName { get; set; }
        public string Address { get; set; }
        public long CardNumber { get; set; }
        public int CardDebet { get; set; }
        public int CardCredit { get; set; }    
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
