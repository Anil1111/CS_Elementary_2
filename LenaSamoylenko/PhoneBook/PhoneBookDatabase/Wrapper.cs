using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookDatabase;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace PhoneBookDatabase
{
    public delegate DataTable DBDelegate();


    public class Wrapper
    {
        private UsingDB usingDB;
        private MySqlCommand mySqlCommand;
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
            mySqlCommand = new MySqlCommand("`selectData`", usingDB.Connection);
            mySqlCommand.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public DataTable UpdateCellName(int numb, DataGridViewRow row)
        {
            mySqlCommand = new MySqlCommand(@"`updateData`", usingDB.Connection);
            List<string> parameters = new List<string> { @"ID", @"FirstName", @"SecondName", @"eMail", @"adress", @"skype", @"phone" };

            for (int i = 0; i < parameters.Count; i++)
            {
                mySqlCommand.Parameters.AddWithValue(parameters[i], row.Cells[i].Value);
                if (i != 0 && i != 6)
                    mySqlCommand.Parameters[i].MySqlDbType = MySqlDbType.String;
                else if (i == 6) { mySqlCommand.Parameters[i].MySqlDbType = MySqlDbType.Decimal; }
                else { mySqlCommand.Parameters[0].MySqlDbType = MySqlDbType.Int32; }

            }

            //mySqlCommand.Parameters.AddWithValue(@"ID", numb);


            mySqlCommand.CommandType = CommandType.StoredProcedure;
            mySqlCommand.ExecuteNonQuery();

            return SelectAll();
            //MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            //DataTable shemaTable = mySqlDataReader.GetSchemaTable();
            //return shemaTable;
        }

        private void InizParam(string paramName, int index, DataGridViewRow row, MySqlCommand mySqlCommand)
        {

        }

        public Tuple<string, bool, bool> buttonPushForConnection()
        {
            Tuple<string, bool, bool> tuple;
            var c = usingDB.Connection.State;

            try
            {
                usingDB.Connection.Open();
                tuple = new Tuple<string, bool, bool>("Connecting", true, true);

            }
            catch
            {
                tuple = new Tuple<string, bool, bool>("No connecting", false, false);
            }
            return tuple;
        }

        public string ReturnUserName()
        {
            return UsingDB.Username;
        }

        public string ReturnDBName()
        {
            return UsingDB.Database;
        }

        public void Update()
        {


        }


        public void AddRow(HelpProj.InsertDialogData data)
        {
            mySqlCommand = new MySqlCommand(@"`insertData`", usingDB.Connection);
            List<string> parameters = new List<string> { @"FirstName", @"SecondName", @"eMail", @"skype", @"phone", @"adress" };


            mySqlCommand.Parameters.AddWithValue(parameters[0], data.FirstName);
            mySqlCommand.Parameters.AddWithValue(parameters[1], data.SecondName);
            mySqlCommand.Parameters.AddWithValue(parameters[2], data.Email);
            mySqlCommand.Parameters.AddWithValue(parameters[3], data.Skype);
            mySqlCommand.Parameters.AddWithValue(parameters[4], data.Phone);
            mySqlCommand.Parameters.AddWithValue(parameters[5], data.Adress);



            for (int i = 0; i < parameters.Count; i++)
            { mySqlCommand.Parameters[i].MySqlDbType = MySqlDbType.String; }
            mySqlCommand.Parameters[4].MySqlDbType = MySqlDbType.Decimal;

            mySqlCommand.CommandType = CommandType.StoredProcedure;
            mySqlCommand.ExecuteNonQuery();
        }
    }
    //DBDelegate bDelegate=new DBDelegate(UsingDB.)

}

