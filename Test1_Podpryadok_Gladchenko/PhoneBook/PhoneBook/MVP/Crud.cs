using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace MVP
{
    public class Crud
    {
        MySqlDataAdapter dataAdapter;
        public Crud()
        {
            dataAdapter = new MySqlDataAdapter();
        }

        public void Add()
        {
            dataAdapter.Fill();
        }

        public void Save()
        {

        }

        public void Search()
        {

        }

        public void Delate()
        {

        }
    }
}
