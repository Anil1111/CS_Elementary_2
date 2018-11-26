using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class.Method();
            Console.ReadKey();
        }




    }

    static class Class
    {
        static int i = 0;
        public static void Method()
        {
            if (i !=30)
            { }
            else { i = 0; }
            ThreadStart threadStart = new ThreadStart(Class.Method);
            Thread thread = new Thread(Class.Method);
            thread.Start();
            Console.WriteLine(new string(' ', 1 * i) + thread.ManagedThreadId);
            i++;
        }
    }



}
