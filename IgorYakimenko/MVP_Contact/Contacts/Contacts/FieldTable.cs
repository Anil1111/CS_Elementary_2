using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class FieldTable
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string middle_name { get; set; }
        public string birthday { get; set; }
        public string comments { get; set; }

        public int id_list { get; set; }
        public int fio_id { get; set; }
        public int type_id { get; set; }
        public string value_ { get; set; }

        public int idcontact_type { get; set; }
        public string contact_definition { get; set; }
    }
}
