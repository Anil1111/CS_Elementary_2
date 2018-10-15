using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HW3Task2
{
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
           
            public void Show(Abonent ab)
            {
                Console.WriteLine($"{ab.LastName} {ab.FirstName} {ab.MidleName}");
                Console.WriteLine($"ИНН->{ ab.IdNumber}--Карта->{ ab.CardNumber}--Дебет->{ ab.CardDebet}--Кредит->{ ab.CardCredit}");
                Console.WriteLine($"Время междугородных разговоров->{ab.IntercityTalkTimeHours}:{ab.IntercityTalkTimeMin}:{ab.IntercityTalkTimeSec}");
                Console.WriteLine($"Время городских разговоров->{ab.CityTalkTimeHours}:{ab.CityTalkTimeMin}:{ab.CityTalkTimeSec}");
                Console.WriteLine();
            }
            public void Print()
            {
                foreach (var a in abonents)
                {
                    Show(a);             
                }
            }
            //Перевод в секунды
            public int TimeInSeconds(int hours,int min,int sec)
            {
                int seconds = hours * 3600+min*60 + sec;
                return seconds;
            }
            //Сравниваем и выводим абонентов превышевших время 
            public void PrintCityTalk(int TalkTimeHours,int TalkTimeMin,int TalkTimeSec)
            {
             int seconds = TimeInSeconds(TalkTimeHours, TalkTimeMin, TalkTimeSec);
                foreach (var abon in abonents)
                {
                    if (TimeInSeconds(abon.CityTalkTimeHours,abon.CityTalkTimeMin,abon.CityTalkTimeMin)>seconds)
                    {
                        Show(abon);
                    }                 
                }
            }

            public void PrintIntercityTalk()
            {
                //Сортировка в алфавитном порядке
                var result = from abonent in abonents
                             orderby abonent.LastName
                             select abonent;               
                foreach (var ab in result)
                {
                    if (TimeInSeconds(ab.IntercityTalkTimeHours,ab.IntercityTalkTimeMin,ab.IntercityTalkTimeSec)!=0)
                    {
                        Show(ab);
                    }                 
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Abonent abonent1 = new Abonent(3476678863, "Федоров", "Александр", "Иванович", "Осенняя 10", 4546567666685786, 1000, 5000,
                    10, 10, 55, 1, 55, 32);
                Abonent abonent2 = new Abonent(3476674463, "Сур", "Алексей", "Иванович", "Украинская 10", 6546567607685786, 100, 500,
                    16, 13, 48, 1, 20, 32);
                Abonent abonent3 = new Abonent(3455678863, "Чернова", "Анна", "Петровна", "Мамона 167", 4544567606685786, 300, 7,
                    0, 0, 0, 4, 25, 32);
                Abonent abonent4 = new Abonent(2476678860, "Алексеева", "Анастасия", "Викторовна", "Тихая 89", 6546567699685786, 10, 700,
                    0, 0, 0, 6, 15, 32);

                Abonents abonents = new Abonents();
                abonents.inputAbontData(abonent1);
                abonents.inputAbontData(abonent2);
                abonents.inputAbontData(abonent3);
                abonents.inputAbontData(abonent4);
                abonents.Print();

                Console.Write("Введите время городских разговоров абонента :\nЧасы-");
                int hours = Convert.ToInt32(Console.ReadLine());
                Console.Write("Минуты-");
                int min = Convert.ToInt32(Console.ReadLine());
                Console.Write("Секунды-");
                int sec = Convert.ToInt32(Console.ReadLine());
                abonents.PrintCityTalk(hours, min, sec);
                Console.WriteLine();
                Console.WriteLine("Абоненты использовавшие междугороднюю связь:");
                Console.ForegroundColor = ConsoleColor.Red;
                abonents.PrintIntercityTalk();
                Console.ReadLine();
            }
        }
    }
}
