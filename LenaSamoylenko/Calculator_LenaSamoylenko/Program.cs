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
                calculator.findDigitsAndOperators();
                //подсчет операций "+" и "-"
                calculator.findPlusAndMinus();
                //замена строки для повторной отработки 
                calculator.exchangeDataAfterCount();
            }
            while (calculator.Result[(calculator.Result).Count - 1] != calculator.Result[(calculator.Result).Count - 2]);
            //result[result.Count - 1] != result[(result.Count - 2)]);
            Console.WriteLine("Result is: {0}", calculator.Result[(calculator.Result).Count - 1]);
            Console.ReadKey();
        }

    }
}

class Calculator
{
    //public string BasicData { get {basicData=value } set { return basicData }; }
    private string basicData;
    private List<int> result;
    public List<int> Result=>result;
    public string BasicData
    {
        get { return basicData; }
        set { basicData = value; }
    }
    public Calculator()
    {
        Console.WriteLine("Hello! Put your basic data using 0-9 and +, -, *, /, ()");
        BasicData = Console.ReadLine();
        result = new List<int>();
    }

    //intitizlization
    private List<int> numbers = new List<int>();
    private List<char> operations = new List<char>();

    //result.Add(0);
    private string[] leftBrackets = { };
    private string[] rightBrackets = { };
    private string[] firstOperation = { };




    public void findFirstOperation()
    {
        numbers.Clear();
        operations.Clear();
        leftBrackets = BasicData.Split('(');
        rightBrackets = BasicData.Split(')');
        firstOperation = leftBrackets[leftBrackets.Length - 1].Split(')');
    }

    public void findDigitsAndOperators()
    {
        if (leftBrackets.Length == firstOperation.Length || leftBrackets.Length == rightBrackets.Length)
        {
            //нахождение чисел в выражении
            Regex numbersInLine = new Regex(@"[0-9]+");
            MatchCollection numMatchCollection = numbersInLine.Matches(firstOperation[0]);
            foreach (Match match in numMatchCollection)
            {
                numbers.Add(Int32.Parse(match.Value));
                match.NextMatch();
            }
            //нахождение знака операции
            Regex operationInLine = new Regex(@"[+,-,*,/]");
            MatchCollection operationMatchCollection = operationInLine.Matches(firstOperation[0]);
            foreach (Match match in operationMatchCollection)
            {
                operations.Add(Char.Parse(match.Value));
                match.NextMatch();
            }
        }

        else
        {
            Console.WriteLine("Error in the numbers of brackets");
            Console.ReadKey();
            return;
        }
    }
    public void findMultiplyAndDivide()
    {
        int i = 0;
        while (i <= operations.Count - 1)
        {
            if (operations[i] == '+' || operations[i] == '-') { i++; }
            else if (operations[i] == '*' || operations[i] == '/')
            {
                workWithList(i, numbers, operations);
            }
            else { }
        }
    }

    public void findPlusAndMinus()
    {
        int j = 0;
        while (j <= operations.Count - 1)
        {
            if (operations[j] == '+' || operations[j] == '-')
            {
                workWithList(j, numbers, operations);
            }
            else { }

        }
        result.Add(numbers[0]);
    }

    public void exchangeDataAfterCount()
    { BasicData = basicData.Replace("(" + firstOperation[0] + ")", numbers[0].ToString()); }

    public static int operationType(char calcOperator, int x1, int x2)
    {
        int result;
        if (calcOperator == '-') return result = x1 - x2;
        else if (calcOperator == '+') return result = x1 + x2;
        else if (calcOperator == '*') return result = x1 * x2;
        else if (calcOperator == '/') return result = x1 / x2;
        else
        {
            Console.WriteLine("Error");
            return result = 0;
        }
    }

    public static void workWithList(int i, List<int> x1, List<char> x2)
    {
        x1[i + 1] = operationType(x2[i], x1[i], x1[i + 1]);
        x1.RemoveAt(i);
        x2.RemoveAt(i);
    }
}






