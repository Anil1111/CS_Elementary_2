using System;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class ConnectingDB
    {
        
        private MySqlConnection connection;

        private string server = "localhost";
        private string database = "world";
        private string username = "root";
        private string password = "ghjuhfvvbcn1809";


        public MySqlConnection Connection => connection;


        public ConnectingDB()
        {
            ConnectingDBOperation(server, database, username, password);
        }


     

        private void ConnectingDBOperation(string server, string database, string username, string password)
        {
            try
            {
                string connectionDB = String.Format($"server={server}; database={database}; username={username}; password={password}");
                connection = new MySqlConnection(connectionDB);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void RepeadConnection()
        {
            ConnectingDBOperation(server, database, username, password);
        }
    }
}
