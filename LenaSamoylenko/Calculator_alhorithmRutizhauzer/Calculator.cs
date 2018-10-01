using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Calculator_alhorithmRutizhauzer
{
    class Calculator
    {

        private string userData;
        List<string> symbols;
        //List<string> symbols1;
        int[] count = { };

        public int Count => count.Length;
        public string UserData => userData;

        public int SymbolsCount => symbols.Count();

        public Calculator()
        {
            inputData temp = new inputData();
            userData = temp.UserData;
            count = null;
            //symbols = null;
            symbols = null;
        }

        private void separetionData()
        {
            //symbols = userData.ToCharArray();
            symbols = new List<string>();
            //ошибка при вводе первого двухзначного числа
            //symbols1.Add(symbols[0].ToString());

            //добавление в symbols1 нормальных чисел
            Regex pattern = new Regex(@"\d+|[+,-,*,/,(,)]");
            MatchCollection membersMatchCollection = pattern.Matches(UserData);
            foreach (Match match in membersMatchCollection)
            {
                symbols.Add(match.Value);
                match.NextMatch();

            }

            count = new int[symbols.Count];

        }

        public void assignLevel()
        {
            int vHelp;
            separetionData();
            int tempCount = 0;
            for (int i = 0; i < symbols.Count; i++)
            {
                if (symbols[i] == "(" || int.TryParse(symbols[i], out vHelp) == true)
                {
                    count[i] = ++tempCount;
                }
                else if (symbols[i] == ")" || symbols[i] == "+" || symbols[i] == "-" || symbols[i] == "*" || symbols[i] == "/")
                {
                    count[i] = --tempCount;
                }
                else
                {
                    Console.WriteLine("Error with data");
                }
            }
        }

        private int searchIndexOfMaxAssignLevel()
        {
            int helpVariableIndex = Array.IndexOf(count, count.Max());
            return helpVariableIndex;
        }

        private string[] maxLevelTerm()
        {
            string[] variable = new string[3];

            int tempIndex = searchIndexOfMaxAssignLevel();
            variable[0] = symbols[tempIndex];
            variable[1] = symbols[tempIndex + 1];
            variable[2] = symbols[tempIndex + 2];
            return variable;
        }

        public void exchangeInUserData()
        {
            string[] interimArray = maxLevelTerm();
            int interimResult = resultMaxLevelTerm(interimArray);
            string helpFirstOperation1 = interimArray[0].ToString() + interimArray[1].ToString() + interimArray[2].ToString();
            string helpFirstOperation2 = interimResult.ToString();
            string tempUserData = userData.Replace(helpFirstOperation1, helpFirstOperation2);
            tempUserData = tempUserData.Replace('(' + helpFirstOperation2 + ')', helpFirstOperation2);
            userData = tempUserData;
        }

        private int resultMaxLevelTerm(string[] array)
        {
            int X1, X2;
            bool tryParseFirstX = int.TryParse(array[0], out X1);
            bool tryParseSecondX = int.TryParse(array[2], out X2);
            int result = operationType(array[1], X1, X2);
            return result;
        }

        public int operationType(string calcOperator, int x1, int x2)
        {
            int result;
            if (calcOperator == "-") return result = x1 - x2;
            else if (calcOperator == "+") return result = x1 + x2;
            else if (calcOperator == "*") return result = x1 * x2;
            else if (calcOperator == "/") return result = x1 / x2;
            else
            {
                Console.WriteLine("Error with operationType");
                return result = 0;
            }
        }

        class inputData
        {
            private string userData;

            public string UserData => userData;
            public inputData()
            {
                Console.WriteLine("Put your data");
                this.userData = Console.ReadLine();
            }
        }



    }
}
