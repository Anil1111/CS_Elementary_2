using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorByMahda
{
    class StringCheck
    {
        //Проверка строки на соответствие математическому выражению
        public static bool IsExpressionTrue(string expression, out string error)
        {
            error = string.Empty;
            // [^\d\+\-\*\/\(\)]  - шаблон не цифры, операции или скобки
            string wrongSymbols = @"[^\d\+\-\*\/\(\)]";
            if (Regex.IsMatch(expression, wrongSymbols))
            {
                error = "The expression contains invalid characters";
                return false;
            }
            // [\+\-\*\/]{2,}   - арифметическая операция встречается 2 и более раз подряд
            // \(+[^\d\+\-]     - после '(' стоит не цифра, '+' или '-' и не '('
            // [^\d]\)          - перед ')' стоит не цифра и не ')'
            // \d\(             - сразу за цифрой стоит '('
            // \)\d             - после закрывающей скобки стоит цифра        
            string multiplicSimbols = @"([\+\-\*\/]{2,})|(\(+[^\d\+\-\(])|([^\d\)]\)|(\d\()|(\)\d))";
            if (Regex.IsMatch(expression, multiplicSimbols))
            {
                error = "The expression contains wrong actions";
                return false;
            }
            // ^[^\d\+\-\(] - первая не цифра, '+', '-' или '('
            // [^\d\)]$ - последняя не цифра или ')'
            string firstOrLastSimbol = @"(^[^\d\+\-\(])|([^\d\)]$)";
            if (Regex.IsMatch(expression, firstOrLastSimbol))
            {
                error = "Wrong first or last character";
                return false;
            }
            return true;
        }

        //проверка строки на количество открывающих и закрывающих скобок
        public static bool IsParenthesesMatch(string expression, out string error, out int parenthesesQuantity)
        {
            int count = 0;
            parenthesesQuantity = 0;
            error = "";
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    count++;
                    parenthesesQuantity++;
                }
                if (expression[i] == ')') count--;

            }
            if (count != 0)
            {
                error = "The number of opening and closing parentheses does not match";
                return false;
            }
            return true;
        }
    }
}
