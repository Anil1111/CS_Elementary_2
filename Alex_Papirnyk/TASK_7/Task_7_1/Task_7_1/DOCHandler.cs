using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_1
{
    class DOCHandler:AbstractHandler
    {
        protected override void Change()
        {
            Console.WriteLine("Вы изменили файл doc");
        }
        protected override void Open()
        {
            Console.WriteLine("Вы открыли файл doc");  
        }
        protected override void Save()
        {
            Console.WriteLine("Вы сохранили файл doc");
        }
        protected override void Create()
        {
            Console.WriteLine("Вы создали файл doc");
        }
        public DOCHandler()
        {
            Create();
            Open();
            Change();
            Save();
        }
    }
}
