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
            workWithCommand(view.Connection(workWithDB.ConnectionToDB(view.Server, view.Host, view.UserName, view.Password)));
        }
        public void workWithCommand(int command)
        {         
            switch (command)
            {
                case 1:
                    abonentsController = workWithDB.ReadAll();//Выводим из БД данные
                    view.printMessage(abonentsController);//Вывод таблици абонентов в консоль
                    workWithCommand(view.getCommand());
                    break;
                case 2:
                    abonentsController = workWithDB.ReadAll();//Читаем базу в список
                    abonentsController.Add(view.newAbonent());//Добавляем нового абонента
                    workWithDB.WriteInDB(abonentsController);//Вызываем метод записи в базу      
                    abonentsController = workWithDB.ReadAll();//Тестово читаем БД
                    view.printMessage(abonentsController);
                    workWithCommand(view.getCommand());
                    break;
                case 3:
                    abonentsController = workWithDB.ReadAll();
                    String[] words = view.searchForChange().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string lastName = words[0];
                    string firstName = words[1];
                    List<Abonent> changeAbonentsController=new List<Abonent>();
                    foreach (Abonent ab in abonentsController)
                    {
                        if (ab.LastName == lastName || ab.FirstName == firstName)
                        {
                            changeAbonentsController.Add(ab);
                        }
                    }
                    if (changeAbonentsController.Count > 0)
                    {
                        view.printMessage(changeAbonentsController);
                        view.ChangeAbonent();
                    }
                    else
                        view.printMessage("Абонент не найден");
                    break;
                case 4:


                    break;
                default:
                    view.printMessage("Неверный выбор");                                  
                    break;

            }

        }

    }
}
