using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace Hometask7
{
    class TXTHandler : AbstractHandler
    {

        public override void Open(string fullName)
        {
            using (StreamReader txt = new StreamReader(fullName, System.Text.Encoding.Default))
            {
                string line;
                while ((line = txt.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("------Opening was done------");

            }
        }

        public override void Change(string fullName)
        {
            using (StreamWriter txt = new StreamWriter(fullName, true, System.Text.Encoding.Default))
            {
                bool continueAddText = true;
                while (continueAddText)
                {
                    Console.WriteLine("Put one line to add into document");
                    txt.WriteLine(Console.ReadLine());
                    continueAddText = WorkWithFile.ContinueAddText();
                }

                Console.WriteLine("------Changing was done------");
                txt.Close();
            }

        }


        public override void Save(string fullName)
        {
            StreamWriter txt = new StreamWriter(fullName);
            txt.Close();
            Console.WriteLine("------Saving was done------");

        }



    }
}
