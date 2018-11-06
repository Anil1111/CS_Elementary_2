using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    abstract class WorkWithData
    {
        public string ConnStr { get { return connStr; } }
        private string connStr = string.Empty;

        public WorkWithData(string connStr)
        {
            this.connStr = connStr;
        }

        public abstract void CreateRecord(FieldTable tableField);
        public abstract void DeleteRecord(FieldTable tableField);
        public abstract void UpdateRecord(FieldTable tableField);
        public abstract List<FieldTable> SelectRecord(FieldTable tableField, string getViewTable);
        public abstract List<FieldTable> SearchRecord(string searchStr); 
    }
}
