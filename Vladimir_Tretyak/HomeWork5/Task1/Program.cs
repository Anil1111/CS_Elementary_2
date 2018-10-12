using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создайте класс AbstractHandler.В теле класса создать методы void Open(), 
//void Create(), void Chenge(), void Save(). Создать производные классы XMLHandler, TXTHandler, 
//DOCHandler от базового класса AbstractHandler.Написать программу, которая будет выполнять 
//определение документа и для каждого формата должны быть методы открытия, создания,
//редактирования, сохранения определенного формата документа.

namespace HW5Task1
{
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }

    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            
        }

        public override void Create()
        {
            
        }

        public override void Open()
        {
            
        }

        public override void Save()
        {
            
        }
    }

    class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
           
        }

        public override void Create()
        {
          
        }

        public override void Open()
        {
            
        }

        public override void Save()
        {
           
        }
    }
    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
           
        }

        public override void Create()
        {
         
        }

        public override void Open()
        {
            
        }

        public override void Save()
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
