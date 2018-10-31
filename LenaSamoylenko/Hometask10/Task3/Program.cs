using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task3
{
    public delegate int MainDelegate(int startData);
    public delegate int AnonimDelegate(List<MainDelegate> mainDelegates);

    class Program
    {
        static void Main(string[] args)
        {

            List<MainDelegate> listDelegate = null;


            AnonimDelegate anonimDelegate = new AnonimDelegate(
                (List<MainDelegate> mainDelegates) =>
            {
                int startData = Convert.ToInt32(Console.ReadLine());
                MainDelegate mD = new MainDelegate(
                    (int sD) =>
                    {

                        int x = Convert.ToInt32(Console.ReadLine());
                        return (sD + x);
                    });
                Console.WriteLine("Put");


                mD.Invoke(startData);
                int result = 0;
                for (int i = 0; i < mainDelegates.Count; i++)
                {
                    
                }
                return result;
            });


            anonimDelegate.Invoke(listDelegate);

            Console.WriteLine("Hello");
        }
    }
}
