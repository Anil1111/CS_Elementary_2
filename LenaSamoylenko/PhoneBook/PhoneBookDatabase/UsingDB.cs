using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookDatabase
{
    class UsingDB : ConnectDB
    {
        private UsingDB usingDataBases;
        internal UsingDB UsingDataBases => usingDataBases;


        public UsingDB(string username, string password) : base(username, password)
        { }

       
        internal void ChangeConnection(string username, string password)
        {
            usingDataBases = new UsingDB(username, password);
        }

        internal void SelectAll()
        {

        }
    }
}
