using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW4Task2
{

    class Program
    {
        static void Main(string[] args)
        {            
            ExcelentPupil one = new ExcelentPupil();
            one.FirstName = "Саша";
            one.LastName = "Александров:";
            GoodPupil two = new GoodPupil();
            two.FirstName = "Иван";
            two.LastName = "Лапа:";
            BadPupil three = new BadPupil();
            three.FirstName = "Евгений";
            three.LastName = "Попов:";
            ClassRoom A = new ClassRoom(one,two,three);
            ExcelentPupil four = new ExcelentPupil();
            four.FirstName = "Катя";
            four.LastName = "Карасёва:";
            A.inputData(four);
            foreach(var p in A.pupils)
            {
                Console.WriteLine($"{p.FirstName} {p.LastName}");
                p.print();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
