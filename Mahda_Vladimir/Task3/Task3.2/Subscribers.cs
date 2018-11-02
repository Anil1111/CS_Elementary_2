using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2
{
    class Subscribers
    {
        List<Subscriber> subscribers;
        List<Subscriber> tempSubscribers;

        public Subscribers()
        {
            subscribers = new List<Subscriber>();
            tempSubscribers = new List<Subscriber>();
        }

        public void AddSubscriber(Subscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Show()
        {
            foreach (Subscriber subscriber in subscribers)
            {
                subscriber.ShowSubscriber();
            }
        }
        /// <summary>
        /// Показывает абонентов, наговоривших по городскому телефону 
        /// более введеного количества секунд
        /// </summary>
        public void ShowCityTalksTimeLimit()
        {
            int timeLimit = -1;
            Console.Write("Input city talks time limit in seconds: ");
            do
            {
                if (!Int32.TryParse(Console.ReadLine(), out timeLimit))
                {
                    Console.WriteLine("Input error, try one more time");
                }
            } while (timeLimit < 0);
            tempSubscribers = subscribers.FindAll(x => x.SubscriberCityTalksTime > timeLimit).ToList();
            ShowListSubscribers($"Subscribers who talked on the landline more than {timeLimit} seconds", tempSubscribers);
        }
        /// <summary>
        ///Показывает абонентов, которые
        ///пользовались междугородной связью
        /// </summary>
        public void ShowLongDistanceTalksSubscribers()
        {
            tempSubscribers = subscribers.FindAll(x => x.SubscriberLongDistanceTalksTime > 0).ToList();
            ShowListSubscribers("Subscribers who used long-distance communication", tempSubscribers);
        }
        /// <summary>
        /// Список абонентов в алфавитном порядке
        /// </summary>
        public void ShowAlphabetSortedSubscribers()
        {
            tempSubscribers = subscribers.OrderBy(x => x.SubscriberLastName).ToList();
            ShowListSubscribers("List of subscribers in alphabetical order", tempSubscribers);
        }
        /// <summary>
        /// Вспомогательная функция печати списка абонентов
        /// </summary>
        /// <param name="message">заголовок</param>
        /// <param name="subscribers">список абонентов</param>
        public static void ShowListSubscribers(string message, List<Subscriber> subscribers)
        {
            if (subscribers.Count > 0)
            {
                Console.WriteLine(new string('*', 50));
                Console.WriteLine(message);
                Console.WriteLine(new string('*', 50));
                foreach (var subscriber in subscribers)
                {
                    subscriber.ShowSubscriber();
                }
            }
            else
            {
                Console.WriteLine("There are no subscribers that match your request");
            }
        }
    }
}
