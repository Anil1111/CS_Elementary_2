using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3Task2
{
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
           private long idNumber;
            string lastName;
            string firstName;
            string midleName;
            string address;
            long cardNumber;
            int cardDebet;
            int cardCredit;
            int intercityTalkTimeHours;
            int intercityTalkTimeMin;
            int intercityTalkTimeSec;

            int cityTalkTimeHours;
            int cityTalkTimeMin;
            int cityTalkTimeSec;

            public long IdNumber { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string MidleName { get; set; }
            public string Address { get; set; }
            public long CardNumber { get; set; }
            public int CardDebet { get; set; }
            public int CardCredit { get; set; }
            public int IntercityTalkTimeHours { get; set; }
            public int IntercityTalkTimeMin { get; set; }
            public int IntercityTalkTimeSec { get; set; }
            public int CityTalkTimeHours { get; set; }
            public int CityTalkTimeMin { get; set; }
            public int CityTalkTimeSec { get; set; }
           

            public Abonent(long idNumber, string lastName, string firstName, string midleName, string address, long cardNumber,
                int cardDebet, int cardCredit, int intercityTalkTimeHours, int intercityTalkTimeMin, int intercityTalkTimeSec,
                int cityTalkTimeHours, int cityTalkTimeMin, int cityTalkTimeSec)
            {
                IdNumber = idNumber;
                LastName = lastName;
                FirstName = firstName;
                MidleName = midleName;
                Address = address;
                CardNumber = cardNumber;
                CardDebet = cardDebet;
                CardCredit = cardCredit;
                IntercityTalkTimeHours = intercityTalkTimeHours;
                IntercityTalkTimeMin = intercityTalkTimeMin;
                IntercityTalkTimeSec = intercityTalkTimeSec;
                CityTalkTimeHours = cityTalkTimeHours;
                CityTalkTimeMin = cityTalkTimeMin;
                CityTalkTimeSec = cityTalkTimeSec;
            }

       }

        class Abonents
        {
            public List<Abonent> abonents;
            public Abonents()
            {
                abonents = new List<Abonent>();
            }
            public void inputAbontData(Abonent newAbonent)
            {
                abonents.Add(newAbonent);
            }

            public void Print()
            {
                foreach(var a in abonents)
                {
                    Console.WriteLine($"{a.LastName} {a.FirstName} {a.MidleName}");
                    Console.WriteLine($"ИНН->{ a.IdNumber}--Карта->{ a.CardNumber}--Дебет->{ a.CardDebet}--Кредит->{ a.CardCredit}");
                    Console.WriteLine($"Время междугородных разговоров->{a.IntercityTalkTimeHours}:{a.IntercityTalkTimeMin}:{a.IntercityTalkTimeMin}");
                    Console.WriteLine($"Время городских разговоров->{a.CityTalkTimeHours}:{a.CityTalkTimeMin}:{a.CityTalkTimeMin}");
                    Console.WriteLine();
                }
               
            }

        }


        class Program
        {
            static void Main(string[] args)
            {
                Abonent abonent1 = new Abonent(3476678863,"Федоров","Александр","Иванович","Осенняя 10",4546567666685786,1000,5000,
                    10,10,55,1,55,32);
                Abonent abonent2 = new Abonent(3476674463, "Сур", "Алекей", "Иванович", "Украинская 10", 6546567607685786, 100, 500,
                    16, 13, 48, 1, 20, 32);
                Abonent abonent3 = new Abonent(3455678863, "Чернова", "Анна", "Петровна", "Мамона 167", 4544567606685786, 300, 7,
                    34, 45, 55, 4, 25, 32);
                Abonent abonent4 = new Abonent(2476678860, "Алексеева", "Анастасия", "Викторовна", "Тихая 89", 6546567699685786, 10, 700,
                    15, 42, 55, 6, 15, 32);

                Abonents abonents = new Abonents();
                abonents.inputAbontData(abonent1);
                abonents.inputAbontData(abonent2);
                abonents.inputAbontData(abonent3);
                abonents.inputAbontData(abonent4);

                abonents.Print();
                Console.ReadLine();
            }
        }
    }
}
