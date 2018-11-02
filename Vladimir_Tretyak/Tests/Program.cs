using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// Напишите телефонную книгу с использованием какой-нибудь реляционной СУБД, например, 
// SQLite, MySQL или PostgreSQL.Но и обычном файле также можно.Телефонная книга — это приложение,
// которое хранит информацию о ваших знакомых и способах, которыми можно связаться с ними.
// Вы можете создавать, редактировать и удалять людей, а также различные их контакты — телефоны, скайпы, адреса блогов и так далее.
// Протокол работы программы записать в файл логирования.Добавить возможность поиска и фильтрования информации. Было бы не плохо, 
// если бы Вы работу с БД скрыли за "оберткой".

namespace Test_Hillel
{
    class Program
    {    
        static void Main(string[] args)
        {
            Person person1 = new Person("Ivanov","Ivan","+30973231245","IvIvanov","lessons.com");
            Person person2 = new Person("Petrov", "Petr","+30673231245", "PetrPet", "webdesign.com");
            Person person3 = new Person("Rudakova", "Anna","+30664567820", "RudAnn", "englishclub.com");

            // массив для сериализации
            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);        
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                // сериализуем весь массив people
                formatter.Serialize(fs, people);
                Console.WriteLine("Объект сериализован");
            }

            // десериализация
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                List<Person> deserilizePeople = (List<Person>)formatter.Deserialize(fs);
                foreach (Person p in deserilizePeople)
                {
                    Console.WriteLine("Фамилия: {0}, Имя:{1}, Телефон:{2}, Скайп:{3}, Вебсайт:{4}", p.LastName, p.FirstName,p.PhoneNumber,p.Skype,p.WebSite);
                }
            }
            Console.ReadLine();
        }
    }
}
