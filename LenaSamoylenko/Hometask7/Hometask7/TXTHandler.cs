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
        FileStream sr;
        public override void Open(string fullName)
        {
            sr = File.Open(fullName, FileMode.OpenOrCreate);
            Console.ReadKey();
        }

        public override void Change(string fullName)
        {
            Console.WriteLine("Put text that you want to add in this file");
            byte[] text = Encoding.Unicode.GetBytes(Console.ReadLine());
            sr.Write(text,0,text.Length);
        }

        public override void Create(string fullName)
        {
            sr = new FileStream(fullName, FileMode.Create);
        }


        //???
        public override void Save(string fullName)
        {
           
        }
    }
}
