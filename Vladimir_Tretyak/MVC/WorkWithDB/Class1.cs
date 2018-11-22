using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MVC
{
    public class WorkWithDB
    {
        static List<Abonent> AbonentsDB = new List<Abonent>();
        MySqlConnection connection;
        public WorkWithDB(string connectString)
        {
           connection = new MySqlConnection(connectString);
        }
        public bool ConnectionToDB()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }                       
        }
      
        public List<Abonent>ReadAll()
        {        
            List<Abonent> persons = new List<Abonent>();
            string readSQL = "SELECT lastName,firstName,phoneNumber,skype,telegram,eMail FROM person";
            MySqlCommand command = new MySqlCommand(readSQL, connection);
            MySqlDataReader reader = command.ExecuteReader();
            int idForView = 0;
            while (reader.Read())
            {
                
                idForView++;
                persons.Add(new Abonent(idForView,reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                                        reader[3].ToString(),reader[4].ToString(),reader[5].ToString()));
                
            }
            reader.Close();
          
            return persons;//Вернём список из БД
        }

        public void WriteInDB(List<Abonent> abonentsDB)
        {
            AbonentsDB = abonentsDB;
        }


    }
}
