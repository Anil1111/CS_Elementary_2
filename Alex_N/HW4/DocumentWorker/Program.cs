using System;

namespace DocumentWorker
{
    class StausChecker
    {
        private string proKey = "gH3+Mu5&!GhR=";
        private string expKey = "sF5$mP1N*bB%/";

        public int VersionChecker(string code)
        {
            if (code == proKey)
            {
                return 1;
            }
            else
            {
                if (code == expKey)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

       
    }
    class Program
    {
        static void Main(string[] args)
        {
            

            StausChecker sc = new StausChecker();

            do
            {
                DocumentBase ourDocument = new DocumentBase();


                Console.WriteLine("Enter product Key:\n");

                switch (sc.VersionChecker(Console.ReadLine()))
                {

                    case 1:

                        ourDocument = new DocumentPro();// UP?

                        DocumentPro proTemp = (DocumentPro)ourDocument;//Down?

                        Console.WriteLine(ourDocument.Info());

                        break;

                    case 2:
                        ourDocument = new DocumentExpert();

                        DocumentExpert proTemp2 = (DocumentExpert)ourDocument;

                        Console.WriteLine(ourDocument.Info());
                        break;

                    default:

                        Console.WriteLine(ourDocument.Info());

                        break;
                }

                Console.WriteLine("ESC - Exit, Else - Continue");

            } while (Console.ReadKey().Key!= ConsoleKey.Escape);

            

        }
    }
}
