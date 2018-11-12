using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookDatabase;
using MySql.Data.MySqlClient;

namespace PhoneBookDatabase
{
    public delegate void DBDelegate();


    public class Wrapper
    {
        internal UsingDB usingDB;
        public Wrapper()
        {
            usingDB = new UsingDB("root", "ghjuhfvvbcn1809");
        }

        public void SelectAll()
        {
            usingDB.Connection.Open();
            MySqlCommand command = new MySqlCommand("selectdata", usingDB.Connection);
            command.CommandText = "selectdata";
            command.Connection = usingDB.Connection;

            MySqlDataReader reader = command.ExecuteReader();
            usingDB.Connection.Close();

        }



        //DBDelegate bDelegate=new DBDelegate(UsingDB.)

    }
}
