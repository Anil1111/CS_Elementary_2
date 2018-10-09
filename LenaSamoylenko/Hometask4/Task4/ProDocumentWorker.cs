using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class ProDocumentWorker : DocumentWorker
    {
        public ProDocumentWorker()
        {
            editDoc = "Документ отредактирован";
        }
        
        public override void EditDocument()
        {
            Console.WriteLine("You`re working in Pro version");
            Console.WriteLine(editDoc);
        }
        
        public override void SaveDocument()
        {
            saveDoc = "Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт";
            Console.WriteLine("You`re working in Pro version");
            Console.WriteLine(saveDoc);
        }
    }
}
