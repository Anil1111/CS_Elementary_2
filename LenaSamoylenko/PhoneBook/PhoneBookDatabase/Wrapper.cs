using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookDatabase;
using MySql.Data.MySqlClient;
using System.Data;


namespace PhoneBookDatabase
{
    public delegate void DBDelegate();


    public class Wrapper
    {
        private UsingDB usingDB;

        internal UsingDB UsingDB => usingDB;

        //private ConnectDB connectDB;

        public Wrapper(string username, string password)
        {
            usingDB = new UsingDB(username, password);

        }


        public void SelectAll()
        {
            MySqlCommand command = new MySqlCommand("selectdata", usingDB.Connection);
            command.CommandText = "selectdata";
            command.Connection = usingDB.Connection;

            MySqlDataReader reader = command.ExecuteReader();
            usingDB.Connection.Close();

        }

        public DataTable SelectAll1()
        {
            //DataSet dataSet = new DataSet();
            //MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select * from `phonebook`.`name`", usingDB.Connection);
            //dataAdapter.Fill(dataSet, "view");

            MySqlCommand mySqlCommand = new MySqlCommand("select * from `phonebook`.`name`", usingDB.Connection);
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            DataTable shemaTable = mySqlDataReader.GetSchemaTable();
            return shemaTable;
        }

        public string buttonPushForConnection()
        {

            var c = usingDB.Connection.State;
            string textconnection;

            try
            {
                usingDB.Connection.Open();
                textconnection = "Connecting";
            }
            catch { textconnection = "No connecting"; }
            return textconnection;
        }

        public string ReturnUserName()
        {
            return UsingDB.Username;
        }

        public string ReturnDBName()
        {
            return UsingDB.Database;
        }


        //DBDelegate bDelegate=new DBDelegate(UsingDB.)

    }
}
