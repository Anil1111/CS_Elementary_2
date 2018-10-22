using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4._2.Classes;

// Создать класс, представляющий учебный класс ClassRoom. Создайте класс ученик Pupil. 
//В теле класса создайте методы void Study(), void Read(), void Write(), void Relax(). 
//Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil 
//и переопределите каждый из методов, в зависимости от успеваемости ученика. 
//Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. 
//Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента. 
//Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться,
//читать, писать, отдыхать.


namespace Task4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil pupil1 = new ExcelentPupil("John");
            GoodPupil pupil2 = new GoodPupil("Mary");
            BadPupil pupil3 = new BadPupil("Mark");

            ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3);
            classRoom.AddPupil(new GoodPupil("Samanta"));
            classRoom.ShowClassRoom();

            Console.ReadKey();
        }
    }
}
