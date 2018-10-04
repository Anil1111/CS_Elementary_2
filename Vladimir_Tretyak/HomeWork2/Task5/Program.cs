using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{


    class Program
    {
        static void Main(string[] args)
        {
            WriteTolibrary write = new WriteTolibrary();
            write.write();
            write.Show();
            Console.ReadLine();
        }
    }
}
