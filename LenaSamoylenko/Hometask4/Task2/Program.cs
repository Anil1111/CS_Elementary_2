using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil p1 = new ExcelentPupil("Ivan Ivanov");
            Pupil p2 = new GoodPupil("Petr Zubov");
            ClassRoom class1A = new ClassRoom(p1, p2);
            class1A.Print();
            Console.ReadKey();
        }
    }
}
