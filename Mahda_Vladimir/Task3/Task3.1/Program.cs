using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Составить описание класса для представления времени.Предусмотреть возможности 
//установки времени и изменения его отдельных полей (час, минута, секунда) с
//проверкой допустимости вводимых значений. В случае недопустимых значений полей 
//выбрасываются исключения.Создать методы изменения времени на заданное количество 
//часов, минут и секунд.

namespace Task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyTime time = new MyTime();
                time.ShowMyTime();
                Console.WriteLine("Change hour to 12 :)");
                time.Hour = 12;
                time.ShowMyTime();
                time.SetMyTime();
                Console.WriteLine("Add 3 hours using function Add3Hours()");
                time.Add3Hours();
                time.ShowMyTime();
                Console.WriteLine("Add 10 minutes using function Add10Minutes()");
                time.Add10Minutes();
                time.ShowMyTime();
                Console.WriteLine("Add 30 seconds using function Add30Seconds()");
                time.Add30Seconds();
                time.ShowMyTime();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }        
            Console.ReadKey();
        }
    }
}
