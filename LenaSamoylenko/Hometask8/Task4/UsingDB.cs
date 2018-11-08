using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Task4
{
    class UsingDB
    {
        static ConnectingDB uniqueInstance;


        public UsingDB(ConnectingDB connectingDB)
        {
            Instance();
        }

        public static ConnectingDB Instance()
        {
            if (uniqueInstance == null)
            { uniqueInstance = new ConnectingDB(); }
            return uniqueInstance;
        }

        public void SelectAllFromCity()
        {
            string query = "select * from world.city";

            MySqlCommand command = new MySqlCommand(query, uniqueInstance.Connection);
            uniqueInstance.Connection.Open();
            MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Console.WriteLine(dataReader[1].ToString()+dataReader[2].ToString());
            }
        }
    }
}
