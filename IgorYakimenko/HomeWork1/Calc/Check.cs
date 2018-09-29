using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Check                 // В класс Check собрал все проверки 
    {
        private char symbol;
        public char Symbol
        {
            get
            {
                return symbol;
            }
        }

        public Check(char symbol)
        {
            Inicialized(symbol);
        }

        private void Inicialized (char symbol)
        {
            this.symbol =  symbol;
        }

        //Метод возвращает true, если проверяемый символ - разделитель ("пробел" или "равно")
        public bool IsDelimeter()
        {
            if ((" =".IndexOf(Symbol) != -1))
                return true;
            return false;
        }

        //Метод возвращает true, если проверяемый символ - оператор
        public bool IsOperator()
        {
            if (("+–/*^()".IndexOf(Symbol) != -1))
                return true;
            return false;
        }

        //Метод возвращает true, если символ это цифра
        public bool IsNumeric()
        {
            if (("0123456789".IndexOf(Symbol) != -1))
                return true;
            return false;
        }

        //Метод возвращает приоритет оператора
        public byte GetPriority()
        {
            switch (Symbol)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '–': return 3;
                case '*': return 4;
                case '/': return 4;
                case '^': return 5;
                default: return 6;
            }
        }

    }
}
