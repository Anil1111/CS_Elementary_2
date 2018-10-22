using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Prises prises = new Prises();
            Prise prise1 = new Prise("Картошка", "ATB", 5.30);
            Prise prise2 = new Prise("Морковь", "Varus", 3.35);
            Prise prise3 = new Prise("Апельсин", "Ashan", 10);
            prises.InputData(prise1);
            prises.InputData(prise2);
            prises.InputData(prise3);
            prises.prisesSorting();
            prises.userConditionOrder();
            Console.ReadLine();

        }
    }
}
