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
            
            Book book1 = new Book();
            string aN= book1.putData("put autor name");
            string bT = book1.putData("put title");
            string bC = book1.putData("put content");
            book1.addBook(aN, bT, bC);
            Console.ReadKey();
        }
    }
}
