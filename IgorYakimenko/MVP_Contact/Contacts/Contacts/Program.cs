using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Contacts
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WorkWithData workWithData = new WorkWithMySql($"datasource=localhost;database=contacts_book;port=3306;username=root;password=123456;");

            /************************************CreateRecord**************************************************/
            ////добавление в таблицу контактов Нового человека 
            //workWithData.CreateRecord(new FieldTable
            //{
            //    name = "Иван",
            //    surname = "Иванов",
            //    middle_name = "Иванович",
            //    birthday = "12.02.1980",
            //    comments = "Сантехник"
            //});

            ////добавление в таблицу contact_type новый тип коммуникации
            //workWithData.CreateRecord(new FieldTable
            //{
            //    contact_definition = "WhatsApp"
            //});

            ////добавление в таблицу contact_list новый вид контакта
            //workWithData.CreateRecord(new FieldTable
            //{
            //    fio_id = 6,
            //    type_id = 1,
            //    value_ = "123456654"
            //});

            /************************************DeleteRecord**************************************************/
            ////удаляю запись из таблицы contact_list
            //workWithData.DeleteRecord(new FieldTable
            //{
            //    id_list = 11,
            //    fio_id = 6
            //});

            ////удаляю запись из таблицы contact_fio
            //workWithData.DeleteRecord(new FieldTable
            //{
            //    fio_id =7
            //});


            /************************************UpdateRecord**************************************************/
            ////меняю запись из таблицы contact_list
            //workWithData.UpdateRecord(new FieldTable
            //{
            //    id_list = 12,
            //    fio_id = 8,
            //    value_ = "12345678"
            //});

            ////меняю запись из таблицы contact_fio
            //workWithData.UpdateRecord(new FieldTable
            //{
            //    fio_id = 8,
            //    name = "Петр",
            //    surname = "Петров",
            //    middle_name = "Петрович",
            //    birthday = "17.04.2000",
            //    comments = "электрик"
            //});



            /************************************SelectRecord**************************************************/
            ////вывожу таблицу по запросу contact_type
            //List<FieldTable> fieldTable = new List<FieldTable>();

            //fieldTable = workWithData.SelectRecord(new FieldTable
            //{
            //}, "Type");

            ////вывожу таблицу по запросу contact_type
            //fieldTable = workWithData.SelectRecord(new FieldTable
            //{
            //    fio_id = 8
            //}, "Fio");

            ////вывожу таблицу по запросу contact_list
            //fieldTable = workWithData.SelectRecord(new FieldTable
            //{
            //    fio_id = 8
            //}, "List");

            //foreach (var element in fieldTable)
            //{
            //    string name_ = element.value_;
            //}


            /************************************SearchRecord**************************************************/
            ////По входной строке ищу нужный контакты
            //List<FieldTable> fieldTable = new List<FieldTable>();

            //fieldTable = workWithData.SearchRecord("Сантехник");

            //foreach (var element in fieldTable)
            //{
            //    int id_fio_ = element.fio_id;
            //    string surname_ = element.surname;
            //    string middle_name = element.middle_name;
            //    string birthday = element.birthday;
            //    string comments = element.comments;
            //}

        }
    }
}
