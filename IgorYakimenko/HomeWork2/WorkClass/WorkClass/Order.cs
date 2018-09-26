using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkClass
{
    class Order
    {
        public Int16 AccPayer { get; set; }
        public string NamePayer { get; set; }
        public string AddressPayer { get; set; }
        public Int16 InnPayer { get; set; }
        public double SummPayer { get; set; }
        public Int16 AccRecipient { get; set; }        
    }
}
