using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PhoneBookDatabase
{
    class ConnectDB
    {
        private MySqlConnection connection;
        private string server = "localhost";
        private string database = "phonebook";
        private string userName = null;
        private string password = null;
        private bool succesConnection = false;

        internal string Username => userName;
        internal MySqlConnection Connection => connection;
        internal bool SuccesConnection => succesConnection;


        public ConnectDB(string _username, string _password)
        {
            userName = _username;
            password = _password;
            ProcessConnecting(server, database, userName, password);
        }

        private void ProcessConnecting(string server, string database, string username, string password)
        {
            try
            {
                string con = String.Format($"server={server}; database={database}; username={username}; password={password}");
                connection = new MySqlConnection(con);
                succesConnection = true;
            }
            catch (Exception e)
            {

            }

        }
    }
}
