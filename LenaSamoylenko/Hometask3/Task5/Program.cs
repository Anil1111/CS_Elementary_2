using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {

        static void Main(string[] args)
        {
            //добавление факультетов с экзаменами
            Faculty facul1 = new Faculty("Украинский язык", "Математика", "Физика", "Физико-технический");
            Faculty facul2 = new Faculty("Украинский язык", "Математика", "Английский язык", "Прикладная математика");
            Faculty facul3 = new Faculty("Украинский язык", "Математика", "Английский язык", "Международная экономика");
            Faculty facul4 = new Faculty("Украинский язык", "Английский язык", "История", "Филологический");


            //добавление абитуриентов
            Enrollee enr1 = new Enrollee("Маша Кобякова", Faculty.Faculty[3]);
            Enrollee enr2 = new Enrollee("Оля Дубинина", Faculty.Faculty[3]);
            Enrollee enr3 = new Enrollee("Костя Муленко", Faculty.Faculty[0]);
            Enrollee enr4 = new Enrollee("Миша Полывяный", Faculty.Faculty[0]);

            //добавление учителей
            Teacher teach1 = new Teacher("Яценко В.Н.");
            Teacher teach2 = new Teacher("Кулабухов А.В.");
            Teacher teach3 = new Teacher("Хащина А.Г.");


            //выставление оценок студентам
            for (int i = 0; i < University.AllEnrollee.Count; i++)
            {

                teach1.setMark(University.AllEnrollee[i], 0);
                teach2.setMark(University.AllEnrollee[i], 1);
                teach3.setMark(University.AllEnrollee[i], 2);
            }

            foreach (var e in University.AllEnrollee)
            {
                Console.WriteLine(e.EnrolleeName);
                for (int i = 0; i <= 2; i++)
                { Print(i, e); }
            }


            //добавленние эталонного бала для поступления
            facul1.AddEtalonMarkForFaculty(75.4);
            facul4.AddEtalonMarkForFaculty(85.0);

            //Сравнение средних балов и прохождение студентов
            for (int i = 0; i < University.AllEnrollee.Count; i++)
            { University.FromEnrolleeToStudent(University.AllEnrollee[i]); }
 
            Console.WriteLine("\nпрошли на выбранные факультеты");
            foreach (var e in University.AllEnrollee)
            {
                if (e.InChooseFaculty==true)
                Console.WriteLine(e.EnrolleeName+" "+e.AverageMark);
            }

            Console.ReadKey();
        }

        static void Print(int numberOfExam, Enrollee e)
        {
            Console.WriteLine(e.GroupOfExams[numberOfExam] + " " + e.Mark[numberOfExam] + " " + e.TeacherName[numberOfExam]);
        }


    }
}

