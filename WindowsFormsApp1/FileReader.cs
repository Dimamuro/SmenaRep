using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
     class IncLocation
    {
        private static (string Point, string Station) GetIncLocationKrasn(string[] Value)
        {
            var result = (Point : "", Station : "");

            int CountWords = Value.Count();
            result.Station = Value[CountWords-3].Substring(0,1)+ Value[CountWords - 3].Substring(1).ToLower();
            for (int i = 0; i <= (CountWords - 4); i++)
            {
                result.Point += Value[i]+" ";
            }

            return result;
        }

        private static (string Point, string Station) GetIncLocationUvst(string[] Value)
        {
            var result = (Point: "", Station: "");

            int CountWords = Value.Count();
            result.Station = Value[0].Substring(0, 1) + Value[0].Substring(1).ToLower();

            return result;
        }

        private static (string Point, string Station) GetIncLocationZsib(string[] Value)
        {
            var result = (Point: "", Station: "");

            int CountWords = Value.Count();
            result.Station = Value[0].Substring(0, 1) + Value[0].Substring(1).ToLower();

            return result;
        }

        public static (string Point, string Station) GetIncLocation(string locationstring, string workgroup)
        {
            var location = (Point: "", Station: "");

            int startstr = locationstring.IndexOf("Расположение");
            string[] tmpvalue = locationstring.Substring(startstr+14).Split(' ')[0].Split('-');
            
            switch (workgroup)
            {
                case "СМЕНА-СТО-КРАСН":
                    location = GetIncLocationKrasn(tmpvalue);
                    break;
                case "СМЕНА-СТО-ЮВСТ":
                    location = GetIncLocationUvst(tmpvalue);
                    break;
                case "СМЕНА-СТО-ЗСИБ":
                    location = GetIncLocationZsib(tmpvalue);
                    break;
            }

            if (location.Station == "Квосточный") { location.Station = "Красноярск-Восточный"; }
            if (location.Station == "Ксеверный") { location.Station = "Красноярск-Северный"; }
            if (location.Station == "Конторадсзлобино") { location.Station = "Красноярск-Восточный"; location.Point = "Контора ДС";  }

            return location;
        }
    }

    class IncidentsCounters
    {
        public int KSK_InfraInc = 0;
        public int KSK_InfraIncToWork = 0;

        public int KRS_TechnoInc = 0;
        public int KRS_TechnoIncToWork = 0;

        public int UVST_InfraInc = 0;
        public int UVST_InfraIncToWork = 0;

        public int UVST_TechnoInc = 0;
        public int UVST_TechnoIncToWork = 0;

        public int ZSIB_InfraInc = 0;
        public int ZSIB_InfraIncToWork = 0;

        public int ZSIB_TechnoInc = 0;
        public int ZSIB_TechnoIncToWork = 0;
    }

    class IncidentsCountersProc
    {
        public static IncidentsCounters GetIncidentsCounters(DataTable dt)
        {
            IncidentsCounters incidentsCounters = new IncidentsCounters();
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["РАБОЧАЯ_ГРУППА"].ToString().Contains("КРАСН"))
                    {
                        if (dt.Rows[i]["ТЕХНИЧЕСКИЙ"].ToString() == "true")
                        {
                            if (dt.Rows[i]["СТАТУС"].ToString().Contains("В работе") || dt.Rows[i]["СТАТУС"].ToString().Contains("Приостановлен"))
                            {
                                incidentsCounters.KRS_TechnoIncToWork++;
                            }
                            incidentsCounters.KRS_TechnoInc++;
                        }
                        if (dt.Rows[i]["ИНФРАСТРУКТУРНЫЙ"].ToString() == "true")
                        {
                            if (dt.Rows[i]["СТАТУС"].ToString().Contains("В работе") || dt.Rows[i]["СТАТУС"].ToString().Contains("Приостановлен"))
                            {
                                incidentsCounters.KSK_InfraIncToWork++;
                            }
                            incidentsCounters.KSK_InfraInc++;
                        }
                    }

                    if (dt.Rows[i]["РАБОЧАЯ_ГРУППА"].ToString().Contains("ЮВСТ"))
                    {
                        if (dt.Rows[i]["ТЕХНИЧЕСКИЙ"].ToString() == "true")
                        {
                            if (dt.Rows[i]["СТАТУС"].ToString().Contains("В работе") || dt.Rows[i]["СТАТУС"].ToString().Contains("Приостановлен"))
                            {
                                incidentsCounters.UVST_TechnoIncToWork++;
                            }
                            incidentsCounters.UVST_TechnoInc++;
                        }
                        if (dt.Rows[i]["ИНФРАСТРУКТУРНЫЙ"].ToString() == "true")
                        {
                            if (dt.Rows[i]["СТАТУС"].ToString().Contains("В работе") || dt.Rows[i]["СТАТУС"].ToString().Contains("Приостановлен"))
                            {
                                incidentsCounters.UVST_InfraIncToWork++;
                            }
                            incidentsCounters.UVST_InfraInc++;
                        }
                    }

                    if (dt.Rows[i]["РАБОЧАЯ_ГРУППА"].ToString().Contains("ЗСИБ"))
                    {
                        if (dt.Rows[i]["ТЕХНИЧЕСКИЙ"].ToString() == "true")
                        {
                            if (dt.Rows[i]["СТАТУС"].ToString().Contains("В работе") || dt.Rows[i]["СТАТУС"].ToString().Contains("Приостановлен"))
                            {
                                incidentsCounters.ZSIB_TechnoIncToWork++;
                            }
                            incidentsCounters.ZSIB_TechnoInc++;
                        }
                        if (dt.Rows[i]["ИНФРАСТРУКТУРНЫЙ"].ToString() == "true")
                        {
                            if (dt.Rows[i]["СТАТУС"].ToString().Contains("В работе") || dt.Rows[i]["СТАТУС"].ToString().Contains("Приостановлен"))
                            {
                                incidentsCounters.ZSIB_InfraIncToWork++;
                            }
                            incidentsCounters.ZSIB_InfraInc++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
           

            return incidentsCounters;
        }
    }

    class SmenaCategory
    {
        public DataTable Smena24Hours;
        public DataTable LastSmena;
        public DataTable ClosedIncidentsForSmena;
        public DataTable ToDoForNextSmena;
        public DataTable ToDoForNextSmenaKRASN;
        public DataTable ToDoForNextSmenaUVST;
        //public DataTable IncidensFromPreviousSmena;
        public DataTable ClosedIncidentsForSmena24Hours;
        public DataTable TI_Incidents24Hours;
        public DataTable TI_Incidents24Hours_WithProblem;
        public DataTable IncidensFromPreviousSmenaNoEnd;
        public DataTable IncidensFromPreviousSmenaEnd;
    }

    class IncidentToCategories
    {
        public static SmenaCategory GetIncidentToCategoy(DataTable dt)
        {
            var smenaTime = SmenaTime.GetSmenaTime();
            SmenaCategory smenaCategory = new SmenaCategory();

            //Инциденты с прошлой смены завершенные
            try
            {
                smenaCategory.IncidensFromPreviousSmenaEnd = (dt.AsEnumerable().Where(row => row.Field<string>("ФАКТИЧЕСКОЕ_ЗАВЕРШЕНИЕ") != ""
                        && Convert.ToDateTime(row.Field<string>("ФАКТИЧЕСКОЕ_ЗАВЕРШЕНИЕ")) >= smenaTime.NowSmenaTime
                        && Convert.ToDateTime(row.Field<string>("ВРЕМЯ_СОЗДАНИЯ")) < smenaTime.NowSmenaTime
                        && row.Field<string>("РАБОЧАЯ_ГРУППА").Contains("КРАСН"))).CopyToDataTable();
            }
            catch { }

            //Инциденты с прошлой смены НЕ завершенные
            try
            {
                smenaCategory.IncidensFromPreviousSmenaNoEnd = (dt.AsEnumerable().Where(row => row.Field<string>("ФАКТИЧЕСКОЕ_ЗАВЕРШЕНИЕ") == ""
                        && Convert.ToDateTime(row.Field<string>("ВРЕМЯ_СОЗДАНИЯ")) < smenaTime.NowSmenaTime
                        && row.Field<string>("РАБОЧАЯ_ГРУППА").Contains("КРАСН"))).CopyToDataTable();
            }
            catch { }

            //Инциденты за последние 2 смены
            try
            {
                smenaCategory.Smena24Hours = (dt.AsEnumerable().Where(row => Convert.ToDateTime(row.Field<string>("ВРЕМЯ_СОЗДАНИЯ")) >= smenaTime.DaySmenaTime)).CopyToDataTable();
            }
            catch { }

            //Инциденты за последнию смену
            try
            {
                smenaCategory.LastSmena = (smenaCategory.Smena24Hours.AsEnumerable().Where(row => Convert.ToDateTime(row.Field<string>("ВРЕМЯ_СОЗДАНИЯ")) >= smenaTime.NowSmenaTime)).CopyToDataTable();
            }
            catch { }

            //Инциденты закрытые за последнюю смену
            try
            {
                smenaCategory.ClosedIncidentsForSmena = (smenaCategory.LastSmena.AsEnumerable().Where(row => row.Field<string>("ИНФРАСТРУКТУРНЫЙ").Contains("true")
                        && row.Field<string>("РАБОЧАЯ_ГРУППА").Contains("КРАСН")
                        && (row.Field<string>("СТАТУС").Contains("Выполнен") || row.Field<string>("СТАТУС").Contains("Закрыт"))))
                        .CopyToDataTable();
            }
            catch { }

            //Инциденты закрытые за последние 2 смены
            try
            {
                smenaCategory.ClosedIncidentsForSmena24Hours = (smenaCategory.Smena24Hours.AsEnumerable().Where(row => row.Field<string>("ИНФРАСТРУКТУРНЫЙ").Contains("true")
                        && row.Field<string>("РАБОЧАЯ_ГРУППА").Contains("КРАСН")
                        && (row.Field<string>("СТАТУС").Contains("Выполнен") || row.Field<string>("СТАТУС").Contains("Закрыт"))))
                        .CopyToDataTable();
            }
            catch { }

            //Инциденты остающиеся в работе
            try
            {
                smenaCategory.ToDoForNextSmena = (dt.AsEnumerable().Where(row => (row.Field<string>("СТАТУС").Contains("В работе") 
                        || row.Field<string>("СТАТУС").Contains("Приостановлен"))))
                        .CopyToDataTable();
            }
            catch { }

            //Инциденты остающиеся в работе КРАСН
            try
            {
                smenaCategory.ToDoForNextSmenaKRASN = (smenaCategory.ToDoForNextSmena.AsEnumerable().Where(row => row.Field<string>("РАБОЧАЯ_ГРУППА").Contains("КРАСН")))
                        .CopyToDataTable();
            }
            catch { }

            //Инциденты остающиеся в работе ЮВСТ
            try
            {
                smenaCategory.ToDoForNextSmenaUVST = (smenaCategory.ToDoForNextSmena.AsEnumerable().Where(row => row.Field<string>("РАБОЧАЯ_ГРУППА").Contains("ЮВСТ")))
                .CopyToDataTable();
            }
            catch { }

            //Инциденты технические
            try
            {
                smenaCategory.TI_Incidents24Hours = (smenaCategory.Smena24Hours.AsEnumerable().Where(row => row.Field<string>("ТЕХНИЧЕСКИЙ").Contains("true")))
                        .CopyToDataTable();
            }
            catch { }

            //Инциденты технические содержащие проблемы
            try
            {
                smenaCategory.TI_Incidents24Hours_WithProblem = (smenaCategory.TI_Incidents24Hours.AsEnumerable().Where(row => row.Field<string>("РЕШЕНИЕ").Contains("ПРБ")
                        && row.Field<string>("РАБОЧАЯ_ГРУППА").Contains("КРАСН")))
                        .CopyToDataTable();
            }
            catch { }


            return smenaCategory;
        }
    }

    class SmenaTime
    {
        public static (DateTime NowSmenaTime, DateTime DaySmenaTime) GetSmenaTime()
        {
            DateTime dtime = DateTime.Now.AddDays(0);
            DateTime tdtime = DateTime.Today;
            var result = (NowSmenaTime: dtime, DaySmenaTime: dtime);

            if (dtime < DateTime.Today.AddHours(4))
            {
                result.NowSmenaTime = DateTime.Today.AddHours(-4);
                result.DaySmenaTime = DateTime.Today.AddHours(-16);
            }
            if (dtime >= DateTime.Today.AddHours(4) && dtime < DateTime.Today.AddHours(16))
            {
                result.NowSmenaTime = DateTime.Today.AddHours(8);
                result.DaySmenaTime = DateTime.Today.AddHours(8);
            }
            if (dtime >= DateTime.Today.AddHours(16))
            {
                result.NowSmenaTime = DateTime.Today.AddHours(20);
                result.DaySmenaTime = DateTime.Today.AddHours(8);
            }
            return result;
        }
    }



    class FileReader
    {
        private static string rootDir = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\Downloads\");

        private static string FindLastFile(string InputDir, string SubstringFile)
        {
            DateTime LastWriteDataTimeFile = new DateTime(1990, 1, 1);
            string fileName = "";

            FileSystemInfo[] InputFiles = new DirectoryInfo(InputDir).GetFileSystemInfos();
            foreach (var item in InputFiles)
            {
                Regex regex = new Regex(SubstringFile);
                MatchCollection matches = regex.Matches(item.Name);
                if (matches.Count > 0 && item.Name.EndsWith(@".txt"))          //if (item.Name.EndsWith(SubstringFile))//добавить нужные форматы
                {
                    if (LastWriteDataTimeFile < Convert.ToDateTime(item.LastWriteTime))
                    {
                        LastWriteDataTimeFile = Convert.ToDateTime(item.LastWriteTime);
                        fileName = item.FullName;
                    }
                }
            }
            return fileName;
        }

        private static DataTable GetDataTableFromExportFile(string fullfilename)
        {
            DataTable dt = new DataTable();

            try
            {
                using (StreamReader sr = new StreamReader(fullfilename, Encoding.Default))
                {
                    int i = 0;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] values = line.Split('*');
                        if (i == 0)
                        {
                            foreach (var columnname in values)
                            {
                                string tmpcolumnname = columnname;
                                switch (columnname)
                                {
                                    case "Номер": tmpcolumnname = "НОМЕР"; break;
                                    case "Краткое описание": tmpcolumnname = "КРАТКОЕ_ОПИСАНИЕ"; break;
                                    case "Статус": tmpcolumnname = "СТАТУС"; break;
                                    case "Рабочая группа": tmpcolumnname = "РАБОЧАЯ_ГРУППА"; break;
                                    case "Время направления в работу": tmpcolumnname = "ВРЕМЯ_СОЗДАНИЯ"; break;
                                    case "Время закрытия события в системе мониторинга": tmpcolumnname = "ВРЕМЯ_ЗАКРЫТИЯ_В_СМ"; break;
                                    case "Фактическое завершение": tmpcolumnname = "ФАКТИЧЕСКОЕ_ЗАВЕРШЕНИЕ"; break;
                                    case "Решение": tmpcolumnname = "РЕШЕНИЕ"; break;
                                    case "Корневая причина": tmpcolumnname = "СПРАВ_КОРНЕВАЯ_ПРИЧИНА"; break;
                                    case "Технический": tmpcolumnname = "ТЕХНИЧЕСКИЙ"; break;
                                    case "Инфраструктурный": tmpcolumnname = "ИНФРАСТРУКТУРНЫЙ"; break;
                                    case "Подробное описание": tmpcolumnname = "ПОДРОБНОЕ_ОПИСАНИЕ"; break;
                                    case "Исполнитель": tmpcolumnname = "ИСПОЛНИТЕЛЬ"; break;
                                    case "Крайний срок": tmpcolumnname = "КРАЙНИЙ_СРОК"; break;
                                }
                                dt.Columns.Add(tmpcolumnname);
                            }
                            i++;
                        }
                        else
                        {
                            dt.Rows.Add(values);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("FileReader.GetDataTableFromExportFile: " + e.Message);
            }

            return dt;
        }

        private DataTable ExpandDataTableIncident(DataTable dt)
        {
            List<string> rootcase = new List<string>{
                    "Аварийное отключение электроэнергии",
                    "Обрыв/повреждение кабеля электропитания", 
                    "Отключение электропитания городскими электросетями",
                    "Плановые работы энергетиков, без оповещения ИВЦ"};
            List<string> timeproperties = new List<string>{
                    "ВРЕМЯ_СОЗДАНИЯ",
                    "ВРЕМЯ_ЗАКРЫТИЯ_В_СМ",
                    "ФАКТИЧЕСКОЕ_ЗАВЕРШЕНИЕ",
                    "КРАЙНИЙ_СРОК"};


            dt.Columns.Add("СТАНЦИЯ");
            dt.Columns.Add("УЗЕЛ");
            dt.Columns.Add("ЭЛЕКТРОЭНЕРГИЯ");
            dt.Columns.Add("IP");
            dt.Columns.Add("DomainName");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string locationstring = dt.Rows[i]["ПОДРОБНОЕ_ОПИСАНИЕ"].ToString();
                string workgroup = dt.Rows[i]["РАБОЧАЯ_ГРУППА"].ToString();
                string shortdescription = dt.Rows[i]["КРАТКОЕ_ОПИСАНИЕ"].ToString();

                bool iselectric = rootcase.Contains(dt.Rows[i]["СПРАВ_КОРНЕВАЯ_ПРИЧИНА"].ToString());
                foreach(string timeproperty in timeproperties)
                {
                    if (dt.Rows[i][timeproperty].ToString() != "") dt.Rows[i][timeproperty] = Convert.ToDateTime(dt.Rows[i][timeproperty]);
                }
                if(shortdescription.Contains("Событие СМ ITNM"))
                {
                    var location = IncLocation.GetIncLocation(locationstring, workgroup);
                    dt.Rows[i].SetField("ЭЛЕКТРОЭНЕРГИЯ", iselectric.ToString()); 
                    dt.Rows[i].SetField("СТАНЦИЯ", location.Station);
                    dt.Rows[i].SetField("УЗЕЛ", location.Point);

                    var list = shortdescription.ToString().Split(' '); //dt.Rows[i].SetField("КРАТКОЕ_ОПИСАНИЕ", shortdescription.ToString().Split(' '));
                    dt.Rows[i].SetField("IP",list[list.Count() - 1].ToString().Replace("IP:", "").ToString());
                    dt.Rows[i].SetField("DomainName", list[list.Count() - 2].ToString());
                }
                else
                {
                    dt.Rows[i].SetField("ТЕХНИЧЕСКИЙ", "false");

                    dt.Rows[i].SetField("ЭЛЕКТРОЭНЕРГИЯ", "False");
                    dt.Rows[i].SetField("СТАНЦИЯ", "null");
                    dt.Rows[i].SetField("УЗЕЛ", "null");
                    dt.Rows[i].SetField("IP", "null");
                    dt.Rows[i].SetField("DomainName", "null");
                }
            }


            return dt;
        }


        public (DataTable, string) DTFromFile()
        {
            DataTable dtfromfile = new DataTable();
            string fullfilename = FindLastFile(rootDir, @"export*");
            if(fullfilename == "")
            {
                MessageBox.Show("Фаил не найден укажите путь к файлу");
 

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        fullfilename = openFileDialog.FileName;
                    }
                }
            }

            if (fullfilename != "")
            {
                dtfromfile = GetDataTableFromExportFile(fullfilename);
                dtfromfile = ExpandDataTableIncident(dtfromfile);
            }


            return (dtfromfile, fullfilename);
        }
        
    }
}
