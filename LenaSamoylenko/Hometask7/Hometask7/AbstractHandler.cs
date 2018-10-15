using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Hometask7
{
    abstract class AbstractHandler
    {
        public virtual void Open(string location)
        {
            
            StreamReader sr = new StreamReader(@location);
            //написать само открытие файла
            Console.ReadKey();
        }
            
        public abstract void Create();
        public abstract void Chenge();
        public abstract void Save();
    }
}
