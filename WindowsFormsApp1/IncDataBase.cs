using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    class WhenBDChange
    {
        private void ChangeOldFile(string filename, DateTime dt)
        {
            using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(dt.ToString());
            }
        }

        public (bool, DateTime) FileIsNew(string NewFile)
        {
            bool FileIsNew = false;
            var NewFileDate = File.GetLastWriteTime(NewFile);
            var OldFileDate = NewFileDate;
            string OldFile = "BDChanged.info";

            if (File.Exists(OldFile))
                OldFileDate = File.GetLastWriteTime(OldFile);
            if(OldFileDate <= NewFileDate)
            {
                FileIsNew = true;
                ChangeOldFile(OldFile, NewFileDate);
                OldFileDate = File.GetLastWriteTime(OldFile);

                //MessageBox.Show("База была изменена! \n старая запись: " + OldFileDate.ToString() + " \n новая запись: " + NewFileDate.ToString());
            }
            
            //else { MessageBox.Show("База НЕ изменена! \n старая запись: " + OldFileDate.ToString() + " \n новая запись: " + NewFileDate.ToString()); }

            return (FileIsNew, OldFileDate);
        }
    }
    class IncDataBase
    {
        private static string npgsqlconnstring = String.Format("Server={0};Port={1};" +
                "User Id={2};Password={3};Database={4};",
                "10.89.251.88", 5432, "collector", "ghfdjcelbt", "ups");
        private NpgsqlConnection npgsqlconn = new NpgsqlConnection(npgsqlconnstring);

        private NpgsqlCommand npgsqlcmd;
        
        private List<string> ColumnNames = new List<string> {
            "НОМЕР",
            "ЭК",
            "КРАТКОЕ_ОПИСАНИЕ",
            "СТАТУС",
            "РАБОЧАЯ_ГРУППА",
            "ВРЕМЯ_СОЗДАНИЯ",
            "ВРЕМЯ_ЗАКРЫТИЯ_В_СМ",
            "ФАКТИЧЕСКОЕ_ЗАВЕРШЕНИЕ",
            "РЕШЕНИЕ",
            "СПРАВ_КОРНЕВАЯ_ПРИЧИНА",
            "ТЕХНИЧЕСКИЙ",
            "ИНФРАСТРУКТУРНЫЙ",
            "ПОДРОБНОЕ_ОПИСАНИЕ",
            "ИСПОЛНИТЕЛЬ",
            "КРАЙНИЙ_СРОК",
            "ИНИЦИАТОР",
            "ПРОТОКОЛ",
            "ДУБЛИРУЮЩИЙ_ИНЦИДЕНТ",
            "ЗАПРОСЫ_ВП_ВЫПОЛНЕНЫ",
            "ЗОНА_ОТВЕТСТВЕННОСТИ",
            "ИСТОЧНИК_ИНЦИДЕНТА",
            "КАТЕГОРИЯ",
            "КОД_ЗАКРЫТИЯ",
            "ПРОСРОЧЕН",
            "РАСПОЛОЖЕНИЕ",
            "РЕГИСТРАТОР",
            "ПРИЧИНЫ_ВОЗНИКНОВЕНИЯ_КОММЕНТАРИИ"
        };

        private string PostgresCreateTableIfNotExists(string namedb)
        {
            string str = " VARCHAR, ";
            //string strdate = " timestamp, ";

            string postgrescreatetableifnotexists = "CREATE TABLE IF NOT EXISTS " + namedb +

                "(" +
                "id"                                    + " serial NOT NULL PRIMARY KEY, " +
                "НОМЕР"                                 + " VARCHAR UNIQUE NOT NULL, " +
                "ЭК"                                    + str +
                "КРАТКОЕ_ОПИСАНИЕ"                      + str +
                "СТАТУС"                                + str +
                "РАБОЧАЯ_ГРУППА"                        + str +
                "ВРЕМЯ_СОЗДАНИЯ"                        + str + //strdate +
                "ВРЕМЯ_ЗАКРЫТИЯ_В_СМ"                   + str + //strdate +
                "ФАКТИЧЕСКОЕ_ЗАВЕРШЕНИЕ"                + str + //strdate +
                "РЕШЕНИЕ"                               + str +
                "СПРАВ_КОРНЕВАЯ_ПРИЧИНА"                + str +
                "ТЕХНИЧЕСКИЙ"                           + str +
                "ИНФРАСТРУКТУРНЫЙ"                      + str +
                "ПОДРОБНОЕ_ОПИСАНИЕ"                    + str +
                "СТАНЦИЯ"                               + str +
                "УЗЕЛ"                                  + str +
                "IP"                                    + str +
                "DOMAINNAME"                           + str +
                "ИСПОЛНИТЕЛЬ"                           + str +
                "КРАЙНИЙ_СРОК"                          + str + //strdate +
                "ИНИЦИАТОР"                             + str +
                "ПРОТОКОЛ"                              + str +
                "ДУБЛИРУЮЩИЙ_ИНЦИДЕНТ"                  + str +
                "ЗАПРОСЫ_ВП_ВЫПОЛНЕНЫ"                  + str +
                "ЗОНА_ОТВЕТСТВЕННОСТИ"                  + str +
                "ИСТОЧНИК_ИНЦИДЕНТА"                    + str +
                "КАТЕГОРИЯ"                             + str +
                "КОД_ЗАКРЫТИЯ"                          + str +
                "ПРОСРОЧЕН"                             + str +
                "РАСПОЛОЖЕНИЕ"                          + str +
                "РЕГИСТРАТОР"                           + str +
                "ЭЛЕКТРОЭНЕРГИЯ" + str +
                "ПРИЧИНЫ_ВОЗНИКНОВЕНИЯ_КОММЕНТАРИИ"     + " VARCHAR" +
                ")";

            return postgrescreatetableifnotexists;
        }

        private string PostgresInsertUPSList(string namedb)
        {
            string comma = ", ";

            string list = "НОМЕР" + comma +
                "ЭК" + comma +
                "КРАТКОЕ_ОПИСАНИЕ" + comma +
                "СТАТУС" + comma +
                "РАБОЧАЯ_ГРУППА" + comma +
                "ВРЕМЯ_СОЗДАНИЯ" + comma +
                "ВРЕМЯ_ЗАКРЫТИЯ_В_СМ" + comma +
                "ФАКТИЧЕСКОЕ_ЗАВЕРШЕНИЕ" + comma +
                "РЕШЕНИЕ" + comma +
                "СПРАВ_КОРНЕВАЯ_ПРИЧИНА" + comma +
                "ТЕХНИЧЕСКИЙ" + comma +
                "ИНФРАСТРУКТУРНЫЙ" + comma +
                "ПОДРОБНОЕ_ОПИСАНИЕ" + comma +
                "ИСПОЛНИТЕЛЬ" + comma +
                "КРАЙНИЙ_СРОК" + comma +
                "ИНИЦИАТОР" + comma +
                "ПРОТОКОЛ" + comma +
                "ДУБЛИРУЮЩИЙ_ИНЦИДЕНТ" + comma +
                "ЗАПРОСЫ_ВП_ВЫПОЛНЕНЫ" + comma +
                "ЗОНА_ОТВЕТСТВЕННОСТИ" + comma +
                "ИСТОЧНИК_ИНЦИДЕНТА" + comma +
                "КАТЕГОРИЯ" + comma +
                "КОД_ЗАКРЫТИЯ" + comma +
                "ПРОСРОЧЕН" + comma +
                "РАСПОЛОЖЕНИЕ" + comma +
                "РЕГИСТРАТОР" + comma +
                "ПРИЧИНЫ_ВОЗНИКНОВЕНИЯ_КОММЕНТАРИИ";

            string valuelist = "'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', " +
                    "'{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}'";


            string sqlinsertupslist = "INSERT INTO " +
                namedb + "(" + list + ") " +
                "VALUES(" + valuelist + ") " +
                "ON CONFLICT (НОМЕР) DO UPDATE" +
                "SET (" + list + ") = (" + valuelist + ")";

            return sqlinsertupslist;
        }

        private string PostgresInsertUPSListOnline(string namedb, string[] columnnames, string[] values)
        {
            try
            {
                string comma = ", ";

                string list = "";
                string valuelist = "";

                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i] != null)
                    {
                        list += columnnames[i] + comma;
                        valuelist += "$$" + values[i] + "$$" + comma;
                    }
                    //else { MessageBox.Show("Пустая строка в " + columnnames[i]); }
                }
                list = list.Substring(0, list.Length - 2);
                valuelist = valuelist.Substring(0, valuelist.Length - 2);

                string sqlinsertupslist = "INSERT INTO " +
                    namedb + "(" + list + ") " +
                    "VALUES(" + valuelist + ") " +
                    "ON CONFLICT (НОМЕР) DO UPDATE " +
                    "SET (" + list + ") = (" + valuelist + ")";

                return sqlinsertupslist;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error PostgresInsertUPSListOnline: " + ex.Message);
                return "";
            }
            
        }

        public void CreatePostgreDT(string namedb)
        {
            try
            {
                npgsqlconn.Open();
                string sql = PostgresCreateTableIfNotExists(namedb);
                npgsqlcmd = new NpgsqlCommand(sql, npgsqlconn);
                npgsqlcmd.ExecuteReader();
                npgsqlconn.Close();
            }
            catch (Exception ex)
            {
                npgsqlconn.Close();
                //Exceptions.WriteErrorMessage(ex, "CreatePostgreDB");
                MessageBox.Show("Error IncDataBase.CreatePostgreDT: " + ex.Message);
            }
        }

       

        public void InsertPostgreBD(DataTable dt, string namedb)
        {
            string[] columnnames = dt.Columns.Cast<DataColumn>()
                                            .Select(x => x.ColumnName)
                                            .ToArray();

            try
            {
                npgsqlconn.Open();
                foreach (DataRow row in dt.Rows)
                {


                    //MessageBox.Show(sql);

                    string[] values = row.ItemArray.Cast<string>().ToArray();
                    string sql = PostgresInsertUPSListOnline(namedb, columnnames, values);
                    npgsqlcmd = new NpgsqlCommand(sql, npgsqlconn);
                    npgsqlcmd.ExecuteNonQuery();
                }
                npgsqlconn.Close();
            }
            catch (Exception ex)
            {
                npgsqlconn.Close();
                MessageBox.Show("Error InsertPostgreBD: " + ex.Message);
            }
        }



        //try
        //{
        //    npgsqlconn.Open();
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        string[] values = row.ItemArray.Cast<string>().ToArray();
        //        string sql = PostgresInsertUPSListOnline(namedb, columnnames, values);
        //        //MessageBox.Show(sql);

        //        npgsqlcmd = new NpgsqlCommand(sql, npgsqlconn);
        //        npgsqlcmd.ExecuteNonQuery();
        //    }
        //    npgsqlconn.Close();
        //}
        //catch (Exception ex)
        //{
        //    npgsqlconn.Close();
        //    //Exceptions.WriteErrorMessage(ex, "InsertPostgreBD");
        //    MessageBox.Show("Error InsertPostgreBD: " + ex.Message);
        //}


        public DataTable SelectPstgressBD(string namedb)
        {
            DataTable dt = new DataTable();
            try
            {
                npgsqlconn.Open();
                string sql = @"SELECT * FROM public." + namedb; //PostgresDataTable;
                npgsqlcmd = new NpgsqlCommand(sql, npgsqlconn);
                dt.Load(npgsqlcmd.ExecuteReader());
                npgsqlconn.Close();
            }
            catch (Exception ex)
            {
                npgsqlconn.Close();
                //Exceptions.WriteErrorMessage(ex, "SelectPostgreBD");
                MessageBox.Show("Error SelectPostgreBD: " + ex.Message);
            }
            return dt;
        }
    }
}
