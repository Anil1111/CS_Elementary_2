using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class ConnectingDB
    {
        static ConnectingDB uniqueInstance;
        private bool succesConnection;

        public bool SuccesConnection { get; private set; }


        public ConnectingDB() { }


        public static ConnectingDB Instance()
        {
            if (uniqueInstance == null)
            { uniqueInstance = new ConnectingDB(); }
            return uniqueInstance;
        }

        public void ConnectingDBOperation()
        {
            //описать процесс самого соединения
            try { }
            catch { }
        }

        public void RepeadConnection()
        {
            ConnectingDBOperation();
        }
    }
}
