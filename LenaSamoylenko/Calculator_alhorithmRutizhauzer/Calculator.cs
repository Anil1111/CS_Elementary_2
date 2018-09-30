using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_alhorithmRutizhauzer
{
    class Calculator
    {

        private string userData;
        char[] symbols = { };
        List<string> symbols1;
        int[] count = { };

        public int Count => count.Length;
        public string UserData => userData;

        public int SymbolsCount => symbols.Count();

        public Calculator()
        {
            inputData temp = new inputData();
            userData = temp.UserData;
            count = null;
            symbols = null;
            symbols1 = null;
        }

        private void separetionData()
        {
            symbols = userData.ToCharArray();
            symbols1 = new List<string>();
            //ошибка при вводе первого двухзначного числа
            //symbols1.Add(symbols[0].ToString());
            for (int i = 1; i < symbols.Length; i++)
            {
                if (Char.IsDigit(symbols[i]) && Char.IsDigit(symbols[i - 1]))
                {
                    
                    symbols1.Add(symbols[i - 1].ToString() + symbols[i].ToString());

                }
                else
                { symbols1.Add(symbols[i].ToString()); }
            }

            count = new int[symbols1.Count];

        }

        public void assignLevel()
        {
            int vHelp;
            separetionData();
            int tempCount = 0;
            for (int i = 0; i < symbols1.Count; i++)
            {
                if (symbols1[i] == "(" || int.TryParse(symbols1[i], out vHelp) == true)
                {
                    count[i] = ++tempCount;
                }
                else if (symbols1[i] == ")" || symbols1[i] == "+" || symbols1[i] == "-" || symbols1[i] == "*" || symbols1[i] == "/")
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
            variable[0] = symbols1[tempIndex];
            variable[1] = symbols1[tempIndex + 1];
            variable[2] = symbols1[tempIndex + 2];
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
