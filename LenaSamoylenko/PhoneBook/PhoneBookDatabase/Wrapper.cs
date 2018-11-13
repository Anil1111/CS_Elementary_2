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
    public delegate DataTable DBDelegate();


    public class Wrapper
    {
        private UsingDB usingDB;

        internal UsingDB UsingDB => usingDB;

        //private ConnectDB connectDB;

        public Wrapper(string username, string password)
        {
            usingDB = new UsingDB(username, password);

        }

        //первый способ
        //public DataTable SelectAll()
        //{
        //    DataTable dataTable = new DataTable();
        //    MySqlDataAdapter adapter = new MySqlDataAdapter("select * from `phonebook`.`name`", usingDB.Connection);
        //    adapter.Fill(dataTable);
        //    return dataTable;
        //}

        public DataTable SelectAll()
        {
            MySqlCommand mySqlCommand = new MySqlCommand("`selectData`", usingDB.Connection);
            mySqlCommand.CommandType = CommandType.StoredProcedure;
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
