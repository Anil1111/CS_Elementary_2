using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item2
{
    class Program
    {
        //2 - Создать класс, представляющий учебный класс ClassRoom. 
        //Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void Write(), void Relax(). 
        //Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil и переопределите каждый из методов, 
        //в зависимости от успеваемости ученика. Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. 
        //Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента. 
        //Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.

        static void Main(string[] args)
        {

            Pupil[] pupil = new Pupil[4];
            pupil[0] = new Pupil("Иванов И.В."); 
            pupil[1] = new Pupil("Петров И.В.");
            pupil[2] = new Pupil("Сидоров С.С.");
            pupil[3] = new Pupil("Скворцов В.В.");

            ClassRoom croom = new ClassRoom(pupil);

            Console.ReadKey();

        }
    }
}
