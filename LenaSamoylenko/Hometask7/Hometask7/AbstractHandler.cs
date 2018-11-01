using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace Hometask7
{
    abstract class AbstractHandler
    {
        public abstract void Open(string fullName);
        public virtual void Create(string fullName)
        {
            var myfile=File.Create(fullName);
            myfile.Close();
            Console.WriteLine("------Creating was done------");
        }
        public abstract void Change(string fullName);
        public abstract void Save(string fullName);
    }
}
