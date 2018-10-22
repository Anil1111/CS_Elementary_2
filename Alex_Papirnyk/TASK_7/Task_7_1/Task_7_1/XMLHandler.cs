using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_1
{
    class XMLHandler:AbstractHandler
    {
        protected override void Change()
        {
            Console.WriteLine("Вы изменили файл xml");
        }
        protected override void Open()
        {
            Console.WriteLine("Вы открыли файл xml");
        }
        protected override void Save()
        {
            Console.WriteLine("Вы сохранили файл xml");
        }
        protected override void Create()
        {
            Console.WriteLine("Вы создали файл xml");
        }
        public XMLHandler()
        {
            Create();
            Open();
            Change();
            Save();
        }
    }
}

