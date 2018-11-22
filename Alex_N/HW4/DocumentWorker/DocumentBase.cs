using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentWorker
{
    class DocumentBase
    {

        protected string OpenDoc()
        {
            return @"The document has been opened";
        }
        protected virtual string EditDoc()
        {
            return @"You can modify the document only in Pro-version";
        }
        protected virtual string SaveDok()
        {
            return @"You can save the document only in Expert-version";
        }


        public string Info()
        {
            return $"\n{OpenDoc()}\n{EditDoc()}\n{SaveDok()}";
        }

    }
}

