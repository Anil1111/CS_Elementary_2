using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task3
{
    partial class Prises
    {
        public List<Prise> prises;//Создаем список для записи товаров типа Prise
        public Prises()//Конструктор 
        {
            prises = new List<Prise>();//выделяем память для списка
        }
        public void inputUserData(Prise newPrise)//Добавляем элементы в список типа Prise
        {
            prises.Add(newPrise);
        }

        public void PrintIsSort()//Сортируем список по алфавиту
        {
            var isSorted = from pr in prises
                           orderby pr.ProductName
                           select pr;

            foreach (var p in isSorted)
            {
                Console.WriteLine($"{p.ProductName}");//Выводим наименования всех товаров 
            }
        }
        public void Print()
        {
            string temp = Console.ReadLine();
            foreach (var str in prises)
            {
                if (str.ProductName == temp)
                {
                    Console.WriteLine($"{str.ProductName}--{str.NameOfshop}--{str.CostOfgoods}грн.");
                }
            }
        }
    }
}
