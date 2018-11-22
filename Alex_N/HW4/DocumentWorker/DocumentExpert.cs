using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentWorker
{
    class DocumentExpert : DocumentPro
    {
        protected override string SaveDok()
        {
            return @"The Document has been saved";
        }
    }
}
