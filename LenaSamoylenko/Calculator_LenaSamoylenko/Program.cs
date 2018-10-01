using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Calculator_LenaSamoylenko
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();


            do
            {
                calculator.findFirstOperation();
                calculator.findDigitsAndOperators();
                //подсчет приоритетных операций - '*' и '/'
                calculator.findMultiplyAndDivide();
                //подсчет операций "+" и "-"
                calculator.findPlusAndMinus();
                //замена строки для повторной отработки 
                calculator.exchangeDataAfterCount();
            }

            while (Convert.ToString(calculator.Result[(calculator.Result).Count - 1]) != calculator.BasicData);
            //result[result.Count - 1] != result[(result.Count - 2)]);
            Console.WriteLine("Result is: {0}", calculator.Result[(calculator.Result).Count - 1]);
            Console.ReadKey();
        }

    }
}







