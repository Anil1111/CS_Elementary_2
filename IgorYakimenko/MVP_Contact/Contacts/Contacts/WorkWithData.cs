using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    abstract class WorkWithData
    {
        public string datasource { get; set; }
        public string port { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        
        public abstract void CreateRecord(FieldTable tableField);
        public abstract void DeleteRecord(FieldTable tableField);
        public abstract void UpdateRecord(FieldTable tableField);
        public abstract List<FieldTable> SelectRecord(FieldTable tableField, string getViewTable);
    }
}
