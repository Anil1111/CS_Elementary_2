using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_1
{
    /*
    
     * Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа.*/
   abstract class AbstractHandler
    {
        protected abstract void Open();
        protected abstract void Create();
        protected abstract void Change();
        protected abstract void Save();
      
        
    }
}
