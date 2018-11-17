using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentWorker
{
    class DocumentPro : DocumentBase
    {
        
        protected override string EditDoc()
        {
            return @"The document has been modified";
        }
        
    }
}
