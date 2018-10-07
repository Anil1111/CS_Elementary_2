using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        //5 - Разработать систему «Вступительные экзамены». Абитуриент регистрируется на Факультет, 
        //    сдает Экзамены. Преподаватель выставляет Оценку. Система подсчитывает средний бал и определяет 
        //    Абитуриента, зачисленного в учебное заведение.

        static void Main(string[] args)
        {
            int numberStudent = 1;
            string surname = string.Empty;
            string name = string.Empty;
            string middleName = string.Empty;
            string faculty = string.Empty;
            Int16 grade = 0;
            List<Enrollee> enrolleeList = new List<Enrollee>();


            Console.WriteLine("Нажмите Esc для окончания ввода:");
            Console.WriteLine();
            ConsoleKeyInfo input;
            do
            {
                Console.WriteLine(@"Введите данные {0}-го студента: ", numberStudent);               
               
                Console.Write("Введите фамилию: ");
                surname = Console.ReadLine();
                Console.Write("Введите имя: ");
                name = Console.ReadLine();
                Console.Write("Введите отчество: ");
                middleName = Console.ReadLine();
                Console.Write("Введите название факультета: ");
                faculty = Console.ReadLine();
                Console.Write("Введите оценку за экзамен: ");
                grade = Convert.ToInt16(Console.ReadLine());
                numberStudent++;

                Console.WriteLine(new string('-', 50));

                Enrollee enrollee = new Enrollee(surname, name, middleName, faculty, grade);
                enrolleeList.Add(enrollee);

                input = Console.ReadKey();
            } while (input.Key != ConsoleKey.Escape);

            int countStud = 0;
            int sumGrade = 0;
            float avgGrade = 0;

            foreach (var element in enrolleeList)
            {
                countStud++;
                sumGrade += element.Grade;
            }
            
            avgGrade = sumGrade/countStud;

            Console.WriteLine();
            Console.WriteLine("Зачисленные студенты: ");

            foreach (var element in new Show().ShowStudent(enrolleeList,avgGrade))
            {
                Console.WriteLine(@"Фамилия: {0}", element.Surname);
                Console.WriteLine(@"Имя: {0}", element.Name);
                Console.WriteLine(@"Отчество: {0}", element.MiddleName);
                Console.WriteLine(@"Оценка по экзамену: {0}", element.Grade);
            }

            Console.ReadKey();
        }
    }
}
