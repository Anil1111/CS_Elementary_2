using System;

namespace WorkWithDB
{
    public class UseDB
    {
        private ConnectionWithDB connectionWithDB = null;

        internal ConnectionWithDB ConnectionWithDB => connectionWithDB;


        public UseDB(ConnectionWithDB _connectionWithDB)
        {
            //вызов метода для установления связи с бд
            connectionWithDB = _connectionWithDB;

        }

        
    }

    

}
