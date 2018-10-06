using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calc
{
    class Program
    {
       
          
        static void Main(string[] args)
        {            
  
            if (args.Length > 0)
            {
                Calculator calc = new Calculator(args[0].ToString());
                calc.ShowRezult();
                Console.ReadKey();
            }
             
        }

       

        
    }
}
