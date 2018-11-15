using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace MVC
{
    interface IView
    {
        
        void printMessage<T>(T text);
        int getCommand();
    }
    public class View:IView
    {
        #region Поля
        private string host;
        private string server;
        private string userName;
        private string password;
        private bool connection = false;
        private int choiceOfaction = 0;
        #endregion
        #region Свойства View
        public string Host
        {
            get
            {
                return host;
            }

            set
            {
                host = value;
            }
        }

        public string Server
        {
            get
            {
                return server;
            }

            set
            {
                server = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public bool Connection1
        {
            get
            {
                return connection;
            }

            set
            {
                connection = value;
            }
        }

        public int ChoiceOfaction
        {
            get
            {
                return choiceOfaction;
            }

            set
            {
                choiceOfaction = value;
            }
        }
        #endregion
        #region  Конструктор          
        public View()
        {
            Authorization();         
        }
        #endregion
        #region Диалоги подключения к БД
        private void Authorization()
        {
            Console.WindowWidth = 85;//Увеличим ширину консоли 
            Console.WriteLine("Введите хост:");
            Host = Console.ReadLine();
            Console.WriteLine("Введите сервер:");
            Server = Console.ReadLine();
            Console.WriteLine("Введите логин: ");
            UserName = Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            Password = Console.ReadLine();
        }
       
        public int Connection(bool connection)
        {
            if (connection == true)
            {
                Console.WriteLine("Соединение с БД установлено");
                return getCommand(); 
            }
            else
            {
                Console.WriteLine("Соединение с БД не установлено, повторите ввод:");
                Authorization();
                return 0;
            }
        }
        #endregion
        #region Вывод инфо. в консоль 
        public void printMessage(List<Abonent> abonenet)
        {
            ConsoleTable.From(abonenet).Write();
            Console.ReadLine();
        }

        public void printMessage<T>(T text)
        {
            Console.WriteLine(text);
            Console.ReadLine();
        }
        #endregion
        #region Диалоги записи нового абонента
        public Abonent newAbonent()
        {       
            Abonent abonent=new Abonent();    
            Console.WriteLine("Введите фамилию нового абонента:");
            abonent.LastName = Console.ReadLine();
            Console.WriteLine("Введите имя нового абонента:");
            abonent.FirstName= Console.ReadLine();
            Console.WriteLine("Введите номер телефона нового абонента:");
            abonent.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Введите ник Скайп нового абонент:");
            abonent.Skype = Console.ReadLine();
            Console.WriteLine("Введите ник Телеграм нового абонента");
            abonent.Telegram = Console.ReadLine();
            Console.WriteLine("Введите электронную почту нового абонента");
            abonent.EMail = Console.ReadLine();
            return abonent;
        }
        #endregion
        #region Диалог редактирования абонента
        public string searchForChange()
        {
            Console.WriteLine("Для поиска и коррекции данных введите  фамилию и имя абонента ");
            string lastNameAndFirstName=Console.ReadLine();
            return lastNameAndFirstName;
        }

        public void ChangeAbonent()
        {

        }

        #endregion
        #region Команда для выполнения операции
        public int getCommand()
        {          
            Console.WriteLine("Выберите что вы хотите сделать:");
            Console.WriteLine("Нажмите:\n 1-для просмотра всех контактов\n 2-для ввода нового\n 3-для редактирования\n 4-для удаления");
            int commandOfoperation = Convert.ToInt32(Console.ReadLine());
            return commandOfoperation ;
        }
        #endregion
    }
}
