using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Subscriber
    {
        private long INN;
        private string firstName;
        private string secondName;
        private string patronymic;
        private string adress;
        private long creditCard;
        private double debet;
        private double credit;
        private DateTime timeCallInCountry;
        private DateTime timeCallInCity;

        public long INN1 { get { return INN; } set { INN = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string SecondName { get { return secondName; } set { secondName = value; } }
        public string Patronymic { get { return patronymic; } set { patronymic = value; } }
        public string Adress { get { return adress; } set { adress = value; } }
        public long CreditCard { get { return creditCard; } set { creditCard = value; } }
        public double Debet { get { return debet; } set { debet = value; } }
        public double Credit { get { return credit; } set { credit = value; } }

        public DateTime TimeCallInCountry { get { return timeCallInCountry; } set { timeCallInCountry = value; } }
        public DateTime TimeCallInCity { get { return timeCallInCity; } set { timeCallInCity = value; } }


        public Subscriber(long INN, string firstName, string secondName, string patronymic, string adress, long creditCard, double debet, double credit, int timeCallInCountryHours, int timeCallInCountryMinute, int timeCallInCountrySeconds, int timeCallInCityHours, int timeCallInCityMinute, int timeCallInCitySeconds)
        {
            this.INN1 = INN;
            this.firstName = firstName;
            this.secondName = secondName;
            this.patronymic = patronymic;
            this.adress = adress;
            this.creditCard = creditCard;
            this.debet = debet;
            this.credit = credit;
            TimeCallInCountry = TimeCallInCountry.AddHours(timeCallInCountryHours);
            TimeCallInCountry = TimeCallInCountry.AddMinutes(timeCallInCountryMinute);
            TimeCallInCountry = TimeCallInCountry.AddSeconds(timeCallInCountrySeconds);

            timeCallInCity = timeCallInCity.AddHours(timeCallInCityHours);
            timeCallInCity = timeCallInCity.AddMinutes(timeCallInCityMinute);
            timeCallInCity = timeCallInCity.AddSeconds(timeCallInCitySeconds);

        }
    }
}
