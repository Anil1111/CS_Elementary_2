using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    interface IController
    {
        void workWithCommand(int command);
    }
    public class Controller : IController
    {
        View view = new View();
        WorkWithDB workWithDB = new WorkWithDB();
        public Controller()
        {
            view.Connection(workWithDB.ConnectionToDB(view.Server, view.Host, view.UserName, view.Password));
            workWithCommand(view.getCommand(Convert.ToInt32(Console.ReadLine())));
        }
        public void workWithCommand(int command)
        {
            List<Abonent> abonents = workWithDB.ReadAll();
            switch (command)
            {
                case 1:
                    abonents = workWithDB.ReadAll();//Выводим из БД данные
                    view.printMessage(abonents);//Вывод таблици абонентов в консоль
                    break;
                case 2:                   
                    abonents.Add(view.newAbonent());
                    //Дописать метод записи в БД
                    abonents = workWithDB.ReadAll();
                    view.printMessage(abonents);
                    break;
                case 3:


                    break;
                case 4:


                    break;
                default:
                    Console.WriteLine("Неверный выбор");
                    Console.ReadLine();
                    break;

            }

        }

    }
}
