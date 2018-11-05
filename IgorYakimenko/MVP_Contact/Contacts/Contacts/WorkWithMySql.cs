using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Contacts
{
    class WorkWithMySql : WorkWithData
    {
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
                                values(" + tableField .fio_id+ ", " + tableField.type_id + ", '"+ tableField .value_+ "');";
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
            if (tableField.id_list !=0)
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

        public override List<FieldTable> SelectRecord(FieldTable tableField, string getViewTable)
        {
            #region Вывожу результирующую таблицы
            string sql_str = string.Empty;
            List<FieldTable> fieldTables = new List<FieldTable>();
            switch(getViewTable)
            {
                case "Type": sql_str = "select * from contacts_book.contact_type order by idcontact_type";
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
                string connectionString = String.Format($"datasource ={datasource};port={port};username={username};password={password};");

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    dataAdapter = new MySqlDataAdapter(sql_str, connection);
                    connection.Open();
                    using (MySqlDataReader myReader = dataAdapter.SelectCommand.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            switch (getViewTable)
                            {
                                case "Type":
                                    fieldTables.Add(new FieldTable
                                    {
                                        idcontact_type = Convert.ToInt16(myReader["idcontact_type"]),
                                        contact_definition = myReader["contact_definition"].ToString()
                                    });
                                    break;

                                case "Fio":
                                    fieldTables.Add(new FieldTable
                                    {
                                        fio_id = Convert.ToInt16(myReader["id_fio"]),
                                        name = myReader["name"].ToString(),
                                        surname = myReader["surname"].ToString(),
                                        middle_name = myReader["middle_name"].ToString(),
                                        comments = myReader["comments"].ToString()
                                    });
                                    break;

                                case "List":
                                    fieldTables.Add(new FieldTable
                                    {
                                        id_list = Convert.ToInt16(myReader["id_list"]),
                                        fio_id = Convert.ToInt16(myReader["fio_id"]),
                                        type_id = Convert.ToInt16(myReader["type_id"]),
                                        value_ = myReader["value_"].ToString()
                                    });
                                    break;
                            }
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
            }

            return fieldTables;
            #endregion
        }

        public override void UpdateRecord(FieldTable tableField)
        {
            #region Меняю записи
            string sql_str = string.Empty;

            #region Формирую SQL запрос
            if (tableField.id_list != 0)
            {
                sql_str = @"update contacts_book.contact_list set value_ ='"+ tableField.value_+ "' " +
                            "where id_list = " + tableField.id_list + " and fio_id = "+ tableField.fio_id + " ";
            }
            else
            {
                sql_str = @"update contacts_book.contact_fio 
                            set  
                                name = '"+ tableField.name+ "', "+
                          "    surname = '"+ tableField.surname + "', "+
                          "    middle_name = '"+ tableField.middle_name + "', " +
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
                string connectionString = String.Format($"datasource ={datasource};port={port};username={username};password={password};");

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    dataAdapter = new MySqlDataAdapter(sql_str, connection);
                    connection.Open();
                    dataAdapter.SelectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                string mess = ex.Message;
            }

            #endregion
        }
    }
}
