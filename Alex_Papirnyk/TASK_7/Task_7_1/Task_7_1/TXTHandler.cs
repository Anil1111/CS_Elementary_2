using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_1
{
    class TXTHandler:AbstractHandler
    {
        protected override void Change()
        {
            Console.WriteLine("Вы изменили файл txt");
        }
        protected override void Open()
        {
            Console.WriteLine("Вы открыли файл txt");
        }
        protected override void Save()
        {
            Console.WriteLine("Вы сохранили файл txt");
        }
        protected override void Create()
        {
            Console.WriteLine("Вы создали файл txt");
        }
        public TXTHandler()
        {
            Create();
            Open();
            Change();
            Save();
        }
    }
}


