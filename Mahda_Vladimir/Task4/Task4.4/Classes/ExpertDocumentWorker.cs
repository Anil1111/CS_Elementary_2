using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4.Classes
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void OpenDocument()
        {
            Console.WriteLine("Документ открыт в версии Expert");
        }

        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован в версии Expert");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
