using System;
using System.Data;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Management.Automation.Runspaces;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker3TimeStart.Value = DateTime.Today.AddDays(-7);
            dateTimePicker3TimeEnd.Value = DateTime.Today.AddDays(1);
            IncDataBase incDataBase = new IncDataBase();
            FileReader fileReader = new FileReader();
            WhenBDChange whenBDChange = new WhenBDChange();

            //DateTime dtime = FileReader.LastWriteDataTimeFile;

            ///Раскоментить, чтобы писать в биза и наобород

            try
            {
                (DataTable dtfromfile, string filename) = fileReader.DTFromFile();

                //Работа с базой данных
                string namebd = "Incidents";
                incDataBase.CreatePostgreDT(namebd);
                var FileIsNew = whenBDChange.FileIsNew(filename);
                label_ChangeBD.Text = "БД изменялась" + FileIsNew.Item2.ToString();
                if (FileIsNew.Item1)    //Закоментить если нужно не проверять время создания файла и изменения БД
                    incDataBase.InsertPostgreBD(dtfromfile, namebd);

                if (filename != "" && dtfromfile != null)
                {
                    label1.Text = "Отчет от " + (File.GetLastWriteTime(filename).ToString());



                    if (checkBox3_EnableDB.Checked)
                        DataGridView_Incidents.DataSource = incDataBase.SelectPstgressBD(namebd);    //Работа с базой данных
                    if (!checkBox3_EnableDB.Checked)
                        DataGridView_Incidents.DataSource = dtfromfile;                           //Работа без базы данных

                    ReportTextForSmena reportTextForSmena = new ReportTextForSmena();

                    textBox_SmenaReport.Text = reportTextForSmena.HalfSmenaReport(dtfromfile).Replace("\n", Environment.NewLine);
                    textBox_SmenaDayReport.Text = reportTextForSmena.FullSmenaReport(dtfromfile).Replace("\n", Environment.NewLine);

                    finder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("File1 имеет ошибки в методе Form1_Load: " + ex.Message);
            }

        }

        private void button4_ECHZONE_Click(object sender, EventArgs e)
        {
            if (textBox4_ECHZone.Text != "")
            {
                this.Hide();
                Form_ElectronicNotificators form_ElectronicNotificators = new Form_ElectronicNotificators(textBox4_ECHZone.Text);
                form_ElectronicNotificators.ShowDialog();
                this.Visible = true;
                //var electrotext = new object []
            }
        }

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    // You could potentially name the column based on the DGV column name (beware of dupes)
                    // or assign a type based on the data type of the data bound to this DGV column.
                    dt.Columns.Add(column.HeaderText);
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Visible)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        cellValues[i] = row.Cells[i].Value;
                    }
                    dt.Rows.Add(cellValues);
                }
            }

            return dt;
        }

        private void FillcomboBox_ValueFilter(string ColumnName, ComboBox Box)
        {
            if (DataGridView_Incidents.DataSource != null)
            {
                Box.Items.Clear();
                DataTable ShareDT = GetDataTableFromDGV(DataGridView_Incidents);
                var result = from row in ShareDT.AsEnumerable()
                             group row by row.Field<string>(ColumnName) into grp
                             select new
                             {
                                 FilterObject = grp.Key,
                                 MemberCount = grp.Count()
                             };

                foreach (var item in result)
                {
                    Box.Items.Add(item.FilterObject);
                }
                //Box.Sorted = true;
            }
        }

        private void ReshowDataGridView(string ColumnName, string FilterItem)
        {
            DataGridView_Incidents.CurrentCell = null;
            for (int i = 0; i < DataGridView_Incidents.RowCount; i++)
            {
                string str = DataGridView_Incidents.Rows[i].Cells[ColumnName].Value.ToString();
                if (!(str.IndexOf(FilterItem, StringComparison.OrdinalIgnoreCase) >= 0))
                {
                    DataGridView_Incidents.Rows[i].Visible = false;
                }
            }

        }

        private void finder_textbox(TextBox sometextBox, string columnname)
        {
            if (sometextBox.TextLength > 2)
            {
                string ColumnName = columnname;
                string FilterItem = sometextBox.Text;
                ReshowDataGridView(ColumnName, FilterItem);
            }
        }

        private void FillcomboBox(string lastnotemntywindwo)
        {
            switch (lastnotemntywindwo)
            {
                case "РАБОЧАЯ_ГРУППА":
                    FillcomboBox_ValueFilter("СТАНЦИЯ", comboBox3Station);
                    FillcomboBox_ValueFilter("УЗЕЛ", comboBox3Point);
                    FillcomboBox_ValueFilter("ИСПОЛНИТЕЛЬ", comboBox3_FIO);
                    break;
                case "СТАНЦИЯ":
                    FillcomboBox_ValueFilter("УЗЕЛ", comboBox3Point);
                    FillcomboBox_ValueFilter("ИСПОЛНИТЕЛЬ", comboBox3_FIO);
                    break;
                case "УЗЕЛ":
                    FillcomboBox_ValueFilter("ИСПОЛНИТЕЛЬ", comboBox3_FIO);
                    break;
                case "":
                    FillcomboBox_ValueFilter("РАБОЧАЯ_ГРУППА", comboBox3Zone);
                    FillcomboBox_ValueFilter("СТАНЦИЯ", comboBox3Station);
                    FillcomboBox_ValueFilter("УЗЕЛ", comboBox3Point);
                    FillcomboBox_ValueFilter("ИСПОЛНИТЕЛЬ", comboBox3_FIO);
                    break;
                default:
                    break;
            }
        }

        private void finder(string value = "")
        {
            var lastnotemntywindwo = "";

            if (comboBox3Zone.Text != "")
            {
                //ReshowDataGridView("РАБОЧАЯ_ГРУППА", comboBox3Zone.Text);
                value = comboBox3Zone.Text;
                lastnotemntywindwo = "РАБОЧАЯ_ГРУППА";
            }
            if (comboBox3Station.Text != "")
            {
                //ReshowDataGridView("СТАНЦИЯ", comboBox3Station.Text);
                value = comboBox3Station.Text;
                lastnotemntywindwo = "СТАНЦИЯ";
            }
            if (comboBox3Point.Text != "")
            {
                //ReshowDataGridView("УЗЕЛ", comboBox3Point.Text);
                value = comboBox3Point.Text;
                lastnotemntywindwo = "УЗЕЛ";
            }
            if (comboBox3_FIO.Text != "")
            {
                //ReshowDataGridView("ИСПОЛНИТЕЛЬ", comboBox3_FIO.Text);
                value = comboBox3_FIO.Text;
                lastnotemntywindwo = "ИСПОЛНИТЕЛЬ";
            }

            if (value.Length > 2)
            {
                EnableVisibleDataGridView();
                ReshowDataGridView("РАБОЧАЯ_ГРУППА", comboBox3Zone.Text);
                ReshowDataGridView("СТАНЦИЯ", comboBox3Station.Text);
                ReshowDataGridView("УЗЕЛ", comboBox3Point.Text);
                ReshowDataGridView("ИСПОЛНИТЕЛЬ", comboBox3_FIO.Text);
                //Combobox parametrs


                FillcomboBox(lastnotemntywindwo);

                //textboxparam
                finder_textbox(textBox3IncNumber, "НОМЕР");
                finder_textbox(textBox3ShortInformation, "КРАТКОЕ_ОПИСАНИЕ");
                finder_textbox(textBox3Solved, "РЕШЕНИЕ");
                finder_textbox(textBox3IP, "IP");
            }
            FillcomboBox(lastnotemntywindwo);
            ShowCountVisibleRows();
        }

        private void EnableVisibleDataGridView()
        {
            DataGridView_Incidents.CurrentCell = null;
            for (int i = 0; i < DataGridView_Incidents.RowCount; i++)
            {
                DataGridView_Incidents.Rows[i].Visible = false;
                var StartDate =DateTime.MinValue;
                var EndDate = DateTime.Now;
                if (DataGridView_Incidents.Rows[i].Cells["ВРЕМЯ_СОЗДАНИЯ"].Value.ToString() != "")
                    StartDate = Convert.ToDateTime(DataGridView_Incidents.Rows[i].Cells["ВРЕМЯ_СОЗДАНИЯ"].Value);
                if (DataGridView_Incidents.Rows[i].Cells["ФАКТИЧЕСКОЕ_ЗАВЕРШЕНИЕ"].Value.ToString() != "")
                    EndDate = Convert.ToDateTime(DataGridView_Incidents.Rows[i].Cells["ФАКТИЧЕСКОЕ_ЗАВЕРШЕНИЕ"].Value);
                if (StartDate > dateTimePicker3TimeStart.Value && EndDate < dateTimePicker3TimeEnd.Value)
                {
                    DataGridView_Incidents.Rows[i].Visible = true;
                }
            }
        }

        private void ShowCountVisibleRows()
        {
            int Count = 0;
            for (int i = 0; i < DataGridView_Incidents.RowCount; i++)
            {
                if (DataGridView_Incidents.Rows[i].Visible == true)
                    Count++;
            }
            label3_CountVisibleRows.Text = "Найдено значений: " + Count.ToString();
        }

        private void comboBox3Zone_TextChanged(object sender, EventArgs e)
        {
            finder((sender as ComboBox).Text);
        }

        private void comboBox3Station_TextChanged(object sender, EventArgs e)
        {
            finder((sender as ComboBox).Text);
        }

        private void comboBox3Point_TextChanged(object sender, EventArgs e)
        {
            finder((sender as ComboBox).Text);
        }

        private void comboBox3_FIO_TextChanged(object sender, EventArgs e)
        {
            finder((sender as ComboBox).Text);
        }

        private void textBox3IncNumber_TextChanged(object sender, EventArgs e)
        {
            finder((sender as TextBox).Text);
        }

        private void textBox3ShortInformation_TextChanged(object sender, EventArgs e)
        {
            finder((sender as TextBox).Text);
        }

        private void textBox3Solved_TextChanged(object sender, EventArgs e)
        {
            finder((sender as TextBox).Text);
        }

        private void textBox3IP_TextChanged(object sender, EventArgs e)
        {
            finder((sender as TextBox).Text);
        }

        private void dateTimePicker3TimeStart_ValueChanged(object sender, EventArgs e)
        {
            finder("sometext");
        }

        private void dateTimePicker3TimeEnd_ValueChanged(object sender, EventArgs e)
        {
            finder("sometext");
        }

        private void DataGridView_Incidents_Sorted(object sender, EventArgs e)
        {
            finder("sometext");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void DataGridView_Incidents_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow inc = DataGridView_Incidents.Rows[DataGridView_Incidents.CurrentRow.Index];
            this.Hide();
            Form_Incident form_Incident = new Form_Incident(inc);
            form_Incident.ShowDialog();
            this.Visible = true;
        }

        private void button3_reset_Click(object sender, EventArgs e)
        {
            comboBox3Zone.Text = "";
            comboBox3Station.Text = "";
            comboBox3Point.Text = "";
            comboBox3_FIO.Text = "";
            textBox3IncNumber.Text = "";
            textBox3IP.Text = "";
            textBox3ShortInformation.Text = "";
            textBox3Solved.Text = "";
            dateTimePicker3TimeStart.Value = DateTime.Today.AddDays(-7);
            dateTimePicker3TimeEnd.Value = DateTime.Today.AddDays(1);
            EnableVisibleDataGridView();
            finder();
            //EnableVisibleDataGridView();
            //ShowCountVisibleRows();
        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
                ShowCountVisibleRows();
        }
    }
}
