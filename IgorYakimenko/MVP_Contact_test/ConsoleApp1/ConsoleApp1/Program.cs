using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts;
using MySql.Data.MySqlClient;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithData workWithData = new WorkWithMySql();
            workWithData.datasource = "localhost";
            workWithData.port = "3306";
            workWithData.username = "root";
            workWithData.password = "123456";

            //добавление в таблицу контактов Нового человека 
            workWithData.CreateRecord(new FieldTable
            {
                name = "Сидор",
                surname = "Сидоров",
                middle_name = "Сидорович",
                birthday = "15.04.1981",
                comments = "Лифтер"
            });

            

            //добавление в таблицу contact_list новый вид контакта
            workWithData.CreateRecord(new FieldTable
            {
                fio_id = 10,
                type_id = 1,
                value_ = "555666444"
            });


        }
    }
}
