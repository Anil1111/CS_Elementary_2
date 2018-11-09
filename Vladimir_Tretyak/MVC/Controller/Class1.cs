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
        List<Abonent> abonentsController = new List<Abonent>();
        public Controller()
        {
            view.Connection(workWithDB.ConnectionToDB(view.Server, view.Host, view.UserName, view.Password));
            workWithCommand(view.getCommand(Convert.ToInt32(Console.ReadLine())));
        }
        public void workWithCommand(int command)
        {         
            switch (command)
            {
                case 1:
                    abonentsController = workWithDB.ReadAll();//Выводим из БД данные
                    view.printMessage(abonentsController);//Вывод таблици абонентов в консоль
                    break;
                case 2:
                    abonentsController = workWithDB.ReadAll();//Читаем базу в список
                    abonentsController.Add(view.newAbonent());//Добавляем нового абонента
                    workWithDB.WriteInDB(abonentsController);//Вызываем метод записи в базу      
                 
                    view.printMessage(abonentsController);

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
