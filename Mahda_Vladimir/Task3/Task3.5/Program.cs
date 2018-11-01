using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3._5.Classes;

//5 - Разработать систему «Вступительные экзамены». Абитуриент регистрируется на Факультет, 
// сдает Экзамены. Преподаватель выставляет Оценку. Система подсчитывает средний бал и 
// определяет Абитуриента, зачисленного в учебное заведение.

namespace Task3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем абитуриентов
            Enrollee Petrenko = new Enrollee("Petrenko");
            Enrollee Garny = new Enrollee("Garny");
            Enrollee Gapka = new Enrollee("Gapka");
            Enrollee Sidorchuk = new Enrollee("Sidorchuk");

            //Создаем пустой список абитуриентов
            Enrollees MechanicFacultiEnrollees = new Enrollees();

            //Создаем список вступительных экзаменов
            Exam Mathematic = new Exam("Mathematic");
            Exam English = new Exam("English");
            Exam UkrMova = new Exam("UkrMova");
            Exams exams = new Exams(Mathematic, English, UkrMova);

            //Создаем преподавателя
            Teacher Strong = new Teacher("Strong");

            //Создаем факультет
            Faculty MechMat = new Faculty("MechMat", exams, MechanicFacultiEnrollees, Strong);
            List<Faculty> univer = new List<Faculty>(); // список факультетов
            univer.Add(MechMat);

            //Создаем университет с одним факультеттом
            University Univer = new University("DNU", univer);

            //Абитуриенты регистрируются на факультет
            Petrenko.CheckToFaculty(MechMat);
            Garny.CheckToFaculty(MechMat);
            Gapka.CheckToFaculty(MechMat);
            Sidorchuk.CheckToFaculty(MechMat);

            Univer.ShowUniversity();
            //Преподаватель ставит оценки за экзамены
            Strong.SetEnrolleesGrades(MechMat);
            MechMat.Enrollees.ShowEnrolleesWithGrades(exams);

            //Система определяет абитуриентов, зачисленных в учебное заведение
            University.ShowListEnrolledStudents(MechMat, passingScore: 60);

            Console.ReadKey();
        }
    }
}
