using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class DocumentWorker
    {
        protected string openDoc;
        protected string editDoc;
        protected string saveDoc;

        private string OpenDoc => openDoc;
        protected virtual string EditDoc => editDoc;
        protected virtual string SaveDoc => saveDoc;
        public DocumentWorker() { openDoc = "Документ открыт"; }
        public void OpenDocument()
        {
            Console.WriteLine(openDoc);
        }
        //чисто для выполнения логики задания
        public virtual void EditDocument()
        {
            editDoc = "Редактирования документа возможно в версии Pro";
            Console.WriteLine(editDoc);
        }
        //чисто для выполнения логики задания
        public virtual void SaveDocument()
        {
            saveDoc = "Сохранение документа доступно в версии Pro";
            Console.WriteLine(saveDoc);
        }
    }
}
