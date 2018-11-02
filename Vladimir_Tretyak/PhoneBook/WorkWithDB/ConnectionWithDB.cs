using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace WorkWithDB
{
    class ConnectionWithDB
    {
        private string server;
        private string host;
        private string user;
        private string password;

        private string Server=>server;
        private string Host=>host;
        private string User=>user;
        private string Password=>password;

        public ConnectionWithDB()
        {
            PutDataToConnect();
            ConnectWithDB(Server, Host, User, Password);
        }
        private void ConnectWithDB(string server, string host, string user, string password)
        {
            //описать тело метода
        }
        private void PutDataToConnect()
        {
            Console.WriteLine("Put server, host, user and password using <Enter> like devider");
            server = Console.ReadLine();
            host = Console.ReadLine();
            user = Console.ReadLine();
            password = Console.ReadLine();

        }

    }
}
