using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Calculator
    {
        private string inputStr = string.Empty;
        public string InputStr
        {
            get
            {
                return inputStr;
            }
        }


        public Calculator(string inputStr)
        {
            this.inputStr = inputStr;
        }

        public void ShowRezult()
        {
            Results rez = new Results();
            string TmpReult = rez.GetExpression(InputStr);
            double result = rez.Counting(TmpReult);//Решаем полученное выражение

            if (string.IsNullOrEmpty(rez.str_error)) Console.WriteLine("Результат: " + result); //Возвращаем результа
            else Console.WriteLine(new string(' ', 40) + rez.str_error);

        }

    }
    
}
