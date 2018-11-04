using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.Common;

//Изучить Singelton.Создать класс, где необходимо подключить базу данных в проект и класс, 
//который будет отвечать за соединение с ней.Один раз создается соединение 
//и нет нужны создавать его снова и снова.

namespace Task6._4
{
    public sealed class MyDBConnection
    {
        private static MySqlConnection instance;
        private const string connectionString = "Server=127.0.0.1;" +
                                                "Database=InternetShop;" +
                                                "User id=root;" +
                                                "Password=";
        private MyDBConnection() { }

        public static MySqlConnection Instance
        {
            get     //This is Singleton!!!
            {
                if (instance == null)
                    instance = new MySqlConnection(connectionString);
                return instance;
            }
        }

        public static void QueryInternetShopAllProducts(MySqlConnection connection)
        {
            string sql = "SELECT * FROM InternetShop.products;";

            // Create command
            MySqlCommand cmd = new MySqlCommand
            {
                // Set connection for command
                Connection = connection,
                CommandText = sql
            };

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Get article
                        int article = Convert.ToInt32(reader.GetValue(0)); // 0
                        // Get brandId
                        int brandId = Convert.ToInt32(reader.GetValue(1)); // 1
                        // Get typeId
                        int typeId = Convert.ToInt32(reader.GetValue(2)); // 2
                        // Get categoryId
                        int categoryId = Convert.ToInt32(reader.GetValue(3)); // 3
                        // Get price
                        double price = Convert.ToDouble(reader.GetValue(4)); // 4

                        Console.WriteLine("--------------------");
                        Console.WriteLine($"article:    {article}");
                        Console.WriteLine($"brandId:    {brandId}");
                        Console.WriteLine($"typeId:     {typeId}");
                        Console.WriteLine($"categoryId: {categoryId}");
                        Console.WriteLine($"price:      {price}");
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection ...");
            MySqlConnection connection = MyDBConnection.Instance;

            try
            {
                Console.WriteLine("Openning Connection ...");

                connection.Open();

                Console.WriteLine("Connection successful!");
                MyDBConnection.QueryInternetShopAllProducts(connection);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Connection close!");
                // Close connection.
                connection.Close();
                // Dispose object, Freeing Resources.
                connection.Dispose();
            }
            Console.Read();
        }
    }
}