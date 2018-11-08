using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace Contacts
{
    public class WorkWithMySql : WorkWithData
    {
        public WorkWithMySql(string connStr)
             : base(connStr)
        {

        }

        public override void CreateRecord(FieldTable tableField)
        {
            #region Добавление новой записи
            string sql_str = string.Empty;

            #region Формирую SQL запрос
            if (!string.IsNullOrEmpty(tableField.name))
            {
                sql_str = @"Insert into contacts_book.contact_fio (name,surname, middle_name, birthday, comments) 
                                                                    values('" + tableField.name + "', " +
                                 "'" + tableField.surname + "', " +
                                 "'" + tableField.middle_name + "', " +
                                 "STR_TO_DATE('" + tableField.birthday + "', '%d.%m.%Y'), " +
                                 "'" + tableField.comments + "'); ";
            }
            else if (!string.IsNullOrEmpty(tableField.contact_definition))
            {
                sql_str = @"insert into contacts_book.contact_type(contact_definition) values('" + tableField.contact_definition + "');";
            }
            else
            {
                sql_str = @"insert into contacts_book.contact_list(fio_id, type_id, value_) 
                                values(" + tableField.fio_id + ", " + tableField.type_id + ", '" + tableField.value_ + "');";
            }
            #endregion

            ExecutionSqlQuery(sql_str);

            #endregion 
        }

        public override void DeleteRecord(FieldTable tableField)
        {
            #region Удаление записи
            string sql_str = string.Empty;

            #region Формирую SQL запрос
            if (tableField.id_list != 0)
            {
                sql_str = @"delete from contacts_book.contact_list where id_list = " + tableField.id_list + " and fio_id = " + tableField.fio_id + " ";
            }
            else
            {
                sql_str = @"delete from contacts_book.contact_fio where id_fio = " + tableField.fio_id + "";
            }
            #endregion


            ExecutionSqlQuery(sql_str);


            #endregion
        }

        public override DataTable SearchRecord(string searchStr)
        {
            #region По входной строке ищу нужный контакты
            string sql_str = string.Empty;

            DataTable dt = new DataTable();


            sql_str = @"select 
		                        distinct 
				                        id_fio,
				                        surname,
                                        name,
                                        middle_name,
                                        birthday,
                                        comments
                        from contact_fio as a
                        left join contact_list as b
                        on(id_fio=b.fio_id)
                        where 
		                        (
			                        lower(surname) like '%" + searchStr.ToLower() + "%' or " +
                    @"           lower(name) like '%" + searchStr.ToLower() + "%' or " +
                    @"           lower(middle_name) like '%" + searchStr.ToLower() + "%' or " +
                    @"           birthday like '%" + searchStr.ToLower() + "%' or " +
                    @"           lower(comments) like '%" + searchStr.ToLower() + "%' or " +
                    @"           lower(value_) like '%" + searchStr.ToLower() + "%'" +
                    @"         )";


            MySqlDataAdapter dataAdapter;

            try
            {
                string connectionString = ConnStr;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    dataAdapter = new MySqlDataAdapter(sql_str, connection);
                    connection.Open();
                    dataAdapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                CreateStringErr(ex.Message);
            }
            return dt;
            #endregion
        }

        public override DataTable SelectRecord(FieldTable tableField, string getViewTable)
        {
            #region Вывожу результирующую таблицы
            string sql_str = string.Empty;

            DataTable dt = new DataTable();
            switch (getViewTable)
            {
                case "Type":
                    sql_str = "select * from contacts_book.contact_type order by idcontact_type";
                    break;

                case "Fio":
                    sql_str = "select * from contacts_book.contact_fio where id_fio = " + tableField.fio_id + "";
                    break;

                case "List":
                    sql_str = "select * from contacts_book.contact_list where fio_id = " + tableField.fio_id + "";
                    break;
            }

            MySqlDataAdapter dataAdapter;

            try
            {
                string connectionString = ConnStr;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    dataAdapter = new MySqlDataAdapter(sql_str, connection);
                    connection.Open();
                    dataAdapter.Fill(dt);

                }
            }
            catch (Exception ex)
            {
                CreateStringErr(ex.Message);
            }


            return dt;
            #endregion
        }

        public override void UpdateRecord(FieldTable tableField)
        {
            #region Меняю записи
            string sql_str = string.Empty;

            #region Формирую SQL запрос
            if (tableField.id_list != 0)
            {
                sql_str = @"update contacts_book.contact_list set value_ ='" + tableField.value_ + "' " +
                            "where id_list = " + tableField.id_list + " and fio_id = " + tableField.fio_id + " ";
            }
            else
            {
                sql_str = @"update contacts_book.contact_fio 
                            set  
                                name = '" + tableField.name + "', " +
                          "    surname = '" + tableField.surname + "', " +
                          "    middle_name = '" + tableField.middle_name + "', " +
                          "    birthday = STR_TO_DATE('" + tableField.birthday + "','%d.%m.%Y'), " +
                          "    comments = '" + tableField.comments + "'" +
                          " where id_fio = " + tableField.fio_id + "";
            }
            #endregion


            ExecutionSqlQuery(sql_str);


            #endregion
        }

        private void ExecutionSqlQuery(string sql_str)
        {
            #region Выполняю SQL запрос
            MySqlDataAdapter dataAdapter;

            try
            {
                string connectionString = ConnStr; /*String.Format($"datasource ={datasource};port={port};username={username};password={password};");*/

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    dataAdapter = new MySqlDataAdapter(sql_str, connection);
                    connection.Open();
                    dataAdapter.SelectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                CreateStringErr(ex.Message);
            }

            #endregion
        }

        private static void LogFile(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine("  :");
            w.WriteLine("  :{0}", logMessage);
            w.WriteLine("-------------------------------");
        }

        private static void CreateStringErr(string error)
        {
            string dirLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            if (!System.IO.File.Exists(dirLocation + "\\logFile.txt"))
            {
                System.IO.File.Create(dirLocation + "\\logFile.txt");
                using (StreamWriter w = File.AppendText(dirLocation + "\\logFile.txt"))
                {
                    LogFile(error, w);
                }
            }
            else
            {
                using (StreamWriter w = File.AppendText(dirLocation + "\\logFile.txt"))
                {

                    LogFile(error, w);
                }
            }
        }
    }
}
