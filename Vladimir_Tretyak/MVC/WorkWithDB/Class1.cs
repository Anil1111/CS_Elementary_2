using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVC
{
    public class WorkWithDB
    {
        List<Abonent> abonentsDB = new List<Abonent>();
        public bool ConnectionToDB(string server, string host, string user, string password)
        {
            //Вызываем метод модели для подключения к бд и передаем ему в аргументы server,host,user,password
            //метод модели должен вернуть нам bool;
            return true;//вместо true вставить метод модели;  
        }
        public List<Abonent>ReadAll()
        {
            //Тестовые данные 
            //Abonent person1 = new Abonent("Ivanov", "Ivan", "+30973231245", "IvIvanov", "lessons.com", "ivIv@i.ua");
            Abonent person1 = new Abonent();
            person1.LastName = "Ivanov";
            person1.FirstName = "Ivan";
            person1.PhoneNumber = "+30973231245";
            person1.Skype = "IvIvanov";
            person1.Telegram = "lessons.com";
            person1.EMail = "ivIv@i.ua";
            abonentsDB.Add(person1);


            //Abonent person2 = new Abonent("Petrov", "Petr", "+30673231245", "PetrPet", "webdesign.com", "petrPet@i.ua");
            //Abonent person3 = new Abonent("Rudakova", "Anna", "+30664567820", "RudAnn", "englishclub.com", "RudAnn@i.ua");




            // массив для сериализации
            //List<Abonent> people = new List<Abonent>();


            //people.Add(person2);
            //people.Add(person3);        
            return abonentsDB;//Вернём список из БД
        }

        public void WriteInDB(List<Abonent> abonentsDB)
        {
            this.abonentsDB = abonentsDB;
        }


    }
}
