using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ReportTextForSmena
    {
        IncidentsCounters incidentsCountersLastSmena = new IncidentsCounters();
        IncidentsCounters incidentsCountersSmena24Hours = new IncidentsCounters();
        IncidentsCounters incidentsCountersForAll = new IncidentsCounters();



        public string HalfSmenaReport(DataTable dtfromfile)
        {
            SmenaCategory smenaCategory = IncidentToCategories.GetIncidentToCategoy(dtfromfile);

            if (smenaCategory.LastSmena != null) { incidentsCountersLastSmena = IncidentsCountersProc.GetIncidentsCounters(smenaCategory.LastSmena); }
            if (smenaCategory.Smena24Hours != null) { incidentsCountersSmena24Hours = IncidentsCountersProc.GetIncidentsCounters(smenaCategory.Smena24Hours); }
            if (dtfromfile != null) {  incidentsCountersForAll = IncidentsCountersProc.GetIncidentsCounters(dtfromfile); }

            DataTable tmpdt;

            // string[] tmptext = new string[];
            string tmptext = "";
            //List<string> tmptext = new List<string>();
            tmptext += "1. Инциденты, переданные по смене (решенные).\n";
            //tmptext.Join(smenaCategory.IncidensFromPreviousSmenaEnd);
            //tmptext.Add("\n2. Инциденты, переданные по смене (не решенные).\n");

            tmptext += FormatTextForSmena(smenaCategory.IncidensFromPreviousSmenaEnd);
            tmptext += "\n2. Инциденты, переданные по смене (не решенные).\n";
            tmptext += FormatTextForSmena(smenaCategory.IncidensFromPreviousSmenaNoEnd);
            tmptext += "\n3. Инциденты по электропитанию.\n";
            try
            {
                tmpdt = (smenaCategory.ClosedIncidentsForSmena.AsEnumerable().Where(row => (row.Field<string>("ЭЛЕКТРОЭНЕРГИЯ") == "True"))).CopyToDataTable();
                tmptext += FormatTextForSmena(tmpdt);
            }
            catch { }
            tmptext += "\n4. Инциденты по СПД.\n";
            try
            {
                tmpdt = (smenaCategory.ClosedIncidentsForSmena.AsEnumerable().Where(row => (row.Field<string>("ЭЛЕКТРОЭНЕРГИЯ") == "False"))).CopyToDataTable();
                tmptext += FormatTextForSmena(tmpdt);
            }
            catch { }
            tmptext += "\n5. Инциденты в работе.\n";
            try
            {
                tmptext += FormatTextForSmena(smenaCategory.ToDoForNextSmenaKRASN);
            }
            catch { }
            tmptext += "\n6. Инциденты в работе ЮВСТ.\n";
            try
            {
                tmptext += FormatTextForSmena(smenaCategory.ToDoForNextSmenaUVST);
            }
            catch { }
            //tmptext += "`n`nКол-во решенных переданных ИНЦ КРАСН:.";
            //tmptext += "ТИ - " +$CountTechnicalFromPreviousSmenaAuto + " ИИ - " + $CountInfrastructureFromPreviousSmenaAuto
            tmptext += "\n\nЗа смену обработано:";
            tmptext += "\n\nКРАСН: ТИ - " + incidentsCountersLastSmena.KRS_TechnoInc + " ИИ - " + incidentsCountersLastSmena.KSK_InfraInc;

            tmptext += "\nВ работе: ТИ - " + incidentsCountersForAll.KRS_TechnoIncToWork + " ИИ - " + incidentsCountersForAll.KSK_InfraIncToWork;
            tmptext += "\n\nЮВСТ: ТИ - " + incidentsCountersLastSmena.UVST_TechnoInc + " ИИ - " + incidentsCountersLastSmena.UVST_InfraInc;

            tmptext += "\nВ работе: ТИ - " + incidentsCountersForAll.UVST_TechnoIncToWork + " ИИ - " + incidentsCountersForAll.UVST_InfraIncToWork;
            tmptext += "\n\nЗСИБ: ТИ - " + incidentsCountersLastSmena.ZSIB_TechnoInc + " ИИ - " + incidentsCountersLastSmena.ZSIB_InfraInc;

            tmptext += "\nВ работе: ТИ - " + incidentsCountersForAll.ZSIB_TechnoIncToWork + " ИИ - " + incidentsCountersForAll.ZSIB_InfraIncToWork;

            

            return tmptext;
        }

        public string FullSmenaReport(DataTable dtfromfile)
        {
            SmenaCategory smenaCategory = IncidentToCategories.GetIncidentToCategoy(dtfromfile);

            if (smenaCategory.LastSmena != null) { incidentsCountersLastSmena = IncidentsCountersProc.GetIncidentsCounters(smenaCategory.LastSmena); }
            if (smenaCategory.Smena24Hours != null) { incidentsCountersSmena24Hours = IncidentsCountersProc.GetIncidentsCounters(smenaCategory.Smena24Hours); }
            if (dtfromfile != null) { incidentsCountersForAll = IncidentsCountersProc.GetIncidentsCounters(dtfromfile); }

            DataTable tmpdt;

            // string[] tmptext = new string[];
            string tmptext = "";
            //List<string> tmptext = new List<string>();
            tmptext += "1. Инциденты, переданные по смене (решенные).\n";
            //tmptext.Join(smenaCategory.IncidensFromPreviousSmenaEnd);
            //tmptext.Add("\n2. Инциденты, переданные по смене (не решенные).\n");

            tmptext += FormatTextForSmena(smenaCategory.IncidensFromPreviousSmenaEnd);
            tmptext += "\n2. Инциденты, переданные по смене (не решенные).\n";
            tmptext += FormatTextForSmena(smenaCategory.IncidensFromPreviousSmenaNoEnd);
            tmptext += "\n3. Инциденты по электропитанию.\n";
            try
            {
                tmpdt = (smenaCategory.ClosedIncidentsForSmena24Hours.AsEnumerable().Where(row => (row.Field<string>("ЭЛЕКТРОЭНЕРГИЯ") == "True"))).CopyToDataTable();
                tmptext += FormatTextForSmena(tmpdt);
            }
            catch { }
            tmptext += "\n4. Инциденты по СПД.\n";
            try
            {
                tmpdt = (smenaCategory.ClosedIncidentsForSmena24Hours.AsEnumerable().Where(row => (row.Field<string>("ЭЛЕКТРОЭНЕРГИЯ") == "False"))).CopyToDataTable();
                tmptext += FormatTextForSmena(tmpdt);
            }
            catch { }
            tmptext += "\n5. Инциденты в работе.\n";
            try
            {
                tmptext += FormatTextForSmena(smenaCategory.ToDoForNextSmenaKRASN);
            }
            catch { }
            tmptext += "\n6. Инциденты в работе ЮВСТ.\n";
            try
            {
                tmptext += FormatTextForSmena(smenaCategory.ToDoForNextSmenaUVST);
            }
            catch { }
            //tmptext += "`n`nКол-во решенных переданных ИНЦ КРАСН:.";
            //tmptext += "ТИ - " +$CountTechnicalFromPreviousSmenaAuto + " ИИ - " + $CountInfrastructureFromPreviousSmenaAuto
            tmptext += "\n\nЗа сутки обработано:";
            tmptext += "\n\nКРАСН: ТИ - " + incidentsCountersSmena24Hours .KRS_TechnoInc + " ИИ - " + incidentsCountersSmena24Hours.KSK_InfraInc;
            tmptext += "\n\nЮВСТ: ТИ - " + incidentsCountersSmena24Hours.UVST_TechnoInc + " ИИ - " + incidentsCountersSmena24Hours.UVST_InfraInc;
            tmptext += "\n\nЗСИБ: ТИ - " + incidentsCountersSmena24Hours.ZSIB_TechnoInc + " ИИ - " + incidentsCountersSmena24Hours.ZSIB_InfraInc;

            tmptext += "\n\nИнтересные ТИ за сутки:";
            try
            {
                tmptext += FormatTextForSmena(smenaCategory.TI_Incidents24Hours_WithProblem);
            }
            catch { }


            return tmptext;
        }

        private string FormatTextForSmena(DataTable dt)
        {
            string FormatReport = "";


            try
            {
                if(dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string tech = "";
                        string starttime = "";
                        string endtime = "";
                        string comment = "";

                        if (dt.Rows[i]["ТЕХНИЧЕСКИЙ"].ToString().Contains("true"))
                        {
                            tech = "(ТИ)";
                        }
                        if (dt.Rows[i]["ВРЕМЯ_СОЗДАНИЯ"].ToString() != "")
                        {
                            starttime = (Convert.ToDateTime(dt.Rows[i]["ВРЕМЯ_СОЗДАНИЯ"]).AddHours(-4)).ToString("HH:mm");
                        }
                        if (dt.Rows[i]["ВРЕМЯ_ЗАКРЫТИЯ_В_СМ"].ToString() != "")
                        {
                            endtime = (Convert.ToDateTime(dt.Rows[i]["ВРЕМЯ_ЗАКРЫТИЯ_В_СМ"]).AddHours(-4)).ToString("HH:mm");
                        }
                        Regex regex = new Regex(@"\d{2}-\d{8}");
                        if (regex.Match(dt.Rows[i]["РЕШЕНИЕ"].ToString()).Success
                            || dt.Rows[i]["РЕШЕНИЕ"].ToString().Contains("возможно")
                            || dt.Rows[i]["СПРАВ_КОРНЕВАЯ_ПРИЧИНА"].ToString() == "")
                        {
                            comment = dt.Rows[i]["РЕШЕНИЕ"].ToString();
                        }
                        if (comment.Contains("ДО:") && comment.Contains(" ПОСЛЕ:")) { comment = comment.Substring(0, (comment.IndexOf("ДО:"))); }

                        string tempstr = starttime + " - " + endtime + " " + tech + dt.Rows[i]["НОМЕР"].ToString() +
                                ". Ст. " + dt.Rows[i]["СТАНЦИЯ"].ToString() + ", " + dt.Rows[i]["УЗЕЛ"].ToString() + ". " +
                                dt.Rows[i]["СПРАВ_КОРНЕВАЯ_ПРИЧИНА"].ToString() + ". " + comment + "\n";
                        tempstr = tempstr.Replace(" .", ".");
                        tempstr = tempstr.Replace("..", ".");
                        tempstr = tempstr.Replace(",.", ".");
                        FormatReport += tempstr;

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

            return FormatReport;
        }

        public void GetFinalReportText(DataTable dtfromfile)
        {
            SmenaCategory smenaCategory = IncidentToCategories.GetIncidentToCategoy(dtfromfile);


            //MessageBox.Show(FullSmenaReport(smenaCategory, dtfromfile));
        }
    }
}
