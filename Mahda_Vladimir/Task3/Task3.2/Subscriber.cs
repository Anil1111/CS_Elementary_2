using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task3._2
{
    class Subscriber
    {
        private long subscriberIdentificationNumber;
        private string subscriberLastName;
        private string subscriberFirstName;
        private string subscriberMiddleName;
        private string subscriberAddress;
        private long subscriberCreditCardNumber;
        private double subscriberDebet;
        private double subscriberCredit;
        private int subscriberCityTalksTime;
        private int subscriberLongDistanceTalksTime;

        public long SubscriberIdentificationNumber { get => subscriberIdentificationNumber; set => subscriberIdentificationNumber = value; }
        public string SubscriberLastName { get => subscriberLastName; set => subscriberLastName = value; }
        public string SubscriberFirstName { get => subscriberFirstName; set => subscriberFirstName = value; }
        public string SubscriberMiddleName { get => subscriberMiddleName; set => subscriberMiddleName = value; }
        public string SubscriberAddress { get => subscriberAddress; set => subscriberAddress = value; }
        public long SubscriberCreditCardNumber { get => subscriberCreditCardNumber; set => subscriberCreditCardNumber = value; }
        public double SubscriberDebet { get => subscriberDebet; set => subscriberDebet = value; }
        public double SubscriberCredit { get => subscriberCredit; set => subscriberCredit = value; }
        public int SubscriberCityTalksTime { get => subscriberCityTalksTime; set => subscriberCityTalksTime = value; }
        public int SubscriberLongDistanceTalksTime { get => subscriberLongDistanceTalksTime; set => subscriberLongDistanceTalksTime = value; }

        public Subscriber(long subscriberIdentificationNumber, string subscriberLastName, string subscriberFirstName, string subscriberMiddleName, string subscriberAddress, long subscriberCreditCardNumber, double subscriberDebet, double subscriberCredit, int subscriberCityTalksTime, int subscriberLongDistanceTalksTime)
        {
            this.subscriberIdentificationNumber = subscriberIdentificationNumber;
            this.subscriberLastName = subscriberLastName;
            this.subscriberFirstName = subscriberFirstName;
            this.subscriberMiddleName = subscriberMiddleName;
            this.subscriberAddress = subscriberAddress;
            this.subscriberCreditCardNumber = subscriberCreditCardNumber;
            this.subscriberDebet = subscriberDebet;
            this.subscriberCredit = subscriberCredit;
            this.subscriberCityTalksTime = subscriberCityTalksTime;
            this.subscriberLongDistanceTalksTime = subscriberLongDistanceTalksTime;
        }

        public void setSubscriberLastName(string value)
        {
            SubscriberLastName = value;
        }
        public string getSubscriberLastName()
        {
            return subscriberLastName;
        }

        public void ShowSubscriber()
        {
            Console.WriteLine($"Last name: {SubscriberLastName, 0-15}| First name: {SubscriberFirstName,0 - 15}| Middle name: {SubscriberMiddleName, 0-15}| INN: {SubscriberIdentificationNumber}");
            Console.WriteLine($"Address: {SubscriberAddress,0 - 30}| Credit card: {SubscriberCreditCardNumber,0 - 20}| Debet:{SubscriberDebet, 0-7}| Credit: {SubscriberCredit, 0-7}");
            Console.WriteLine($"City talks time: {SubscriberCityTalksTime,0 - 5} seconds| Long distance talks time: {SubscriberLongDistanceTalksTime,0 - 5} seconds");
            Console.WriteLine(new string('-', 100));
        }
    }
}
