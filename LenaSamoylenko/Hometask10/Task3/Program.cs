using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task3
{
    public delegate int MainDelegate();
    public delegate int AnonimDelegate(List<MainDelegate> mainDelegates);

    class Program
    {
        static void Main(string[] args)
        {

            List<MainDelegate> listDelegate = null;

            listDelegate = workWithDelegate.Fill(4);

            AnonimDelegate anonimDelegate = new AnonimDelegate(
                (List<MainDelegate> mainDelegates) =>
            {
                
                int result = 0;
                for (int i = 0; i < mainDelegates.Count; i++)
                {
                    result = result + mainDelegates[i].Invoke();
                }
                
                return result;
            });


            int FinalResult=anonimDelegate.Invoke(listDelegate);

            Console.WriteLine("Hello");
            Console.WriteLine("FinalResult is:{0}", FinalResult);
            Console.ReadKey();
        }

        static class workWithDelegate
        {
            static int MainDelegateMethod()
            {
                int result = 0;
                Random random = new Random();
                result = result + random.Next(0, 100);
                return result;
            }

            public static List<MainDelegate> Fill(int count)
            {
                List<MainDelegate> list = new List<MainDelegate>();
                MainDelegate m1 = new MainDelegate(MainDelegateMethod);
                for (int i = 0; i < count; i++)
                {
                    list.Add(m1);
                }
                return list;
            }

        }
    }
}
