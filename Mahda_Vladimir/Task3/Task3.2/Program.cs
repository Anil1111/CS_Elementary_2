using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Класс Абонент: Идентификационный номер, Фамилия, Имя, Отчество, Адрес,
//Номер кредитной карточки, Дебет, Кредит, Время междугородных и городских
//переговоров; Конструктор; Методы: установка значений атрибутов, получение
//значений атрибутов, вывод информации.Создать массив объектов данного класса.
//Вывести сведения относительно абонентов, у которых время городских
//переговоров превышает заданное.Сведения относительно абонентов, которые
//пользовались междугородной связью. Список абонентов в алфавитном порядке.

namespace Task3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Subscriber Govorov = new Subscriber(11111111, "Govorov", "Panas", "Grigorovich", "m.Kyiv, Khreshchatic, 54", 1234123412341234, 1000, 0, 520, 0);
            Subscriber Petrenko = new Subscriber(22222222, "Petrenko", "Petro", "Mykolayovich", "m.Dnipro, Yavornickogo, 22", 4567465745674567, 0, 50, 30, 600);
            Subscriber Mamenko = new Subscriber(33333333, "Mamenko", "Igor", "Mykolayovich", "m.Rivne, Skovorody, 1", 7890789078907890, 125, 0, 240, 1200);
            Subscriber Valuev = new Subscriber(44444444, "Valuev", "Mykola", "Petrovich", "m.Zhitomyr, Skovorody, 17", 3214321432143214, 0, 100, 500, 1500);

            Subscribers subscribers = new Subscribers();
            subscribers.AddSubscriber(Govorov);
            subscribers.AddSubscriber(Petrenko);
            subscribers.AddSubscriber(Mamenko);
            subscribers.AddSubscriber(Valuev);
            subscribers.Show();

            subscribers.ShowCityTalksTimeLimit();

            subscribers.ShowLongDistanceTalksSubscribers();

            subscribers.ShowAlphabetSortedSubscribers();

            Console.ReadKey();
        }
    }
}
