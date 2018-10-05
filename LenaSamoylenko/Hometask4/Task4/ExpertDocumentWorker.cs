using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public ExpertDocumentWorker() { saveDoc = "Документ сохранен в новом формате"; }
        
        //чисто для выполнения логики задания
        public override void SaveDocument()
        {
            Console.WriteLine("You`re working in Exp version");
            Console.WriteLine(SaveDoc);
        }
    }
}
