using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MVP
{
    public class Connect
    {
        MySqlConnection connection;
        MySqlDataAdapter dataAdapter;
        DataSet ds;

        public DataTable Connecting()
        {
            string datasource = "localhost";
            string port = "3306";
            string username = "root";
            string password = "password";

            string connectionString = String.Format($"datasource={datasource};port={port};username={username};password={password};");

            connection = new MySqlConnection(connectionString);

            string query = string.Empty;

            dataAdapter = new MySqlDataAdapter(query, connection);

            connection.Open();

            ds = new DataSet();
            dataAdapter.Fill(ds, "PhoneBook");
            return ds.Tables["PhoneBook"];
        }
    }
}
