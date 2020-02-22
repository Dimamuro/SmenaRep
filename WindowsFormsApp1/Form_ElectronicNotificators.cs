using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_ElectronicNotificators : Form
    {
        public string ElectricNotificators;
        public Form_ElectronicNotificators(string str)
        {
            InitializeComponent();
            ElectricNotificators = str;
        }

        private void FillElectronicNotificatorForm()
        {
            var list = ElectricNotificators.Split(new[] { '\r', '\n' });
            string ECHZone = "";
            int IndexOf;
            var tmp = "";

            string TimeRange = DateTime.Today.ToString();
            DateTime DateInaccssibility = DateTime.Today.AddDays(1);
            bool DateIsChange = false;

            DateTime TimeStart;
            DateTime TimeEnd;
            List<string> Stations = new List<string>();

            foreach (string tmpstr in list)
            {
                if (tmpstr != "")
                {
                    /// Удаляю пунктуацию в конце строки
                    Regex regex = new Regex(@"\W");
                    tmp = tmpstr;
                    for (int i = tmp.Length - 1; i >= 0; i--)
                    {
                        if (!(regex.Match(tmp[i].ToString()).Success))
                        {
                            tmp = tmp.Substring(0, i + 1).ToString();
                            i = -1;
                        }
                    }
                    /// Дата начала простоя
                    regex = new Regex(@"\d\d\.\d\d\.\d\d");
                    if (regex.Match(tmp).Success)
                    {
                        DateInaccssibility = Convert.ToDateTime((tmp.Split(' ').AsEnumerable().Where(obj => regex.Match(obj).Success)).First());
                        DateIsChange = true;
                    }
                    if (tmpstr == list[list.Length - 1] && !DateIsChange)
                    {
                        MessageBox.Show("Отсутсвтует дата простоя: " + Environment.NewLine + "Будет -> " + DateInaccssibility.ToString("dd.MM.yy"));
                    }
                        
                    DateTime DateInaccssibilityEnd = DateInaccssibility.AddDays(1);

                    textBox_StartActive.Text = DateInaccssibility.ToString("dd'/'MM'/'yy HH:mm:ss");
                    textBox_EndActive.Text = DateInaccssibility.AddDays(1).ToString("dd'/'MM'/'yy HH:mm:ss");


                    /// ЭЧ зона
                    if (tmp.Contains("ЭЧ-"))
                    {
                        IndexOf = tmp.IndexOf("ЭЧ-");
                        ECHZone = tmp.Substring(IndexOf, 4);
                    }

                    regex = new Regex(@"\A-");
                    if (regex.Match(tmp.Replace(" ","").Replace("\t","")).Success)
                    {
                        if (tmp.Contains("ё")) { tmp = tmp.Replace("ё", "е"); }

                        regex = new Regex(@"\sдо\s");
                        if (regex.Match(tmp).Success)
                        {
                            IndexOf = tmp.IndexOf(" до ");
                            tmp = tmp.Substring(0, IndexOf) + "-" + tmp.Substring(IndexOf + 4, tmp.Length - IndexOf - 4);
                                
                        }
                            
                        try
                        {
                            string line;
                            StreamReader sr = new StreamReader(".\\Glossary.txt", Encoding.Default);
                            while ((line = sr.ReadLine()) != null)
                            {
                                var Glossary = line.Replace("-"," ");
                                if (tmp.Contains(Glossary))
                                {
                                    //MessageBox.Show(tmp);
                                    regex = new Regex(@"\d:\d\d-\d");
                                    if (regex.Match(tmp).Success)
                                    {
                                        TimeRange = (tmp.Split(' ','.',',').AsEnumerable().Where(obj => regex.Match(obj).Success)).Last();
                                        TimeStart = DateInaccssibility + TimeSpan.Parse(TimeRange.Split('-')[0]) + TimeSpan.Parse("04:00");
                                        TimeEnd = DateInaccssibility + TimeSpan.Parse(TimeRange.Split('-')[TimeRange.Split('-').Length - 1]) + TimeSpan.Parse("04:00");
                                    }
                                    else
                                    {
                                        TimeStart = DateInaccssibility + TimeSpan.Parse("08:00");
                                        TimeEnd = DateInaccssibility + TimeSpan.Parse("17:00");
                                    }

                                    if (TimeStart > TimeEnd) { TimeEnd = TimeEnd.AddDays(1); }

                                    if (Convert.ToDateTime(textBox_EndActive.Text) < TimeEnd)
                                    {
                                        textBox_EndActive.Text = TimeEnd.ToString("dd'/'MM'/'yy HH:mm:ss");
                                    }

                                    dataGridView_Inaccessibility.Rows.Add(TimeStart.ToString("dd'/'MM'/'yy HH:mm:ss"),
                                            TimeEnd.ToString("dd'/'MM'/'yy HH:mm:ss"),
                                             "*" + Glossary.Replace(" ", "") + "*КРАСН");

                                    Stations.Add(Glossary);
                                }
                                
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }

            textBox_Description.Text = "Плановые работы " + ECHZone + " cо снятием напряжения на " 
                    + DateInaccssibility.ToString("dd.MM.yy") + ":" + Environment.NewLine ;

            if (Stations.Count > 0)
            {
                var result = from obj in Stations.AsEnumerable()
                             group obj by obj into grp
                             select new
                             {
                                 FilterObject = grp.Key,
                                 MemberCount = grp.Count()
                             };
                foreach (var item in result)
                {
                    textBox_Description.Text += item.FilterObject + ", ";
                }
            }
        }

        private void StartProgram()
        {
            dataGridView_Inaccessibility.Rows.Clear();
            FillElectronicNotificatorForm();
        }

        private void Form_ElectronicNotificators_Load(object sender, EventArgs e)
        {
            textBox_Information.Text = ElectricNotificators;
            StartProgram();
        }

        private void textBox_Information_TextChanged(object sender, EventArgs e)
        {
            ElectricNotificators = textBox_Information.Text;
            StartProgram();
        }
    }
}
