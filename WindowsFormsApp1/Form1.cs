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
            //StartPSScript(null,null);
            //FillTextBoxSmenaReport();
            IncDataBase incDataBase = new IncDataBase();
            FileReader fileReader = new FileReader();
            //DateTime dtime = FileReader.LastWriteDataTimeFile;
            
            ///Раскоментить, чтобы писать в биза и наобород
            ///string namebd = "Incidents";
            //incDataBase.CreatePostgreDT(namebd);
            //incDataBase.InsertPostgreBD(fileReader.DTFromFile(), namebd);

            //DataGridView_Incidents.DataSource = incDataBase.SelectPstgressBD(namebd);
            
            (DataTable dtfromfile, string filename) = fileReader.DTFromFile();
            label1.Text = "Отчет от " + (File.GetLastWriteTime(filename).ToString());
            DataGridView_Incidents.DataSource = dtfromfile;

            ReportTextForSmena reportTextForSmena = new ReportTextForSmena();

            //MessageBox.Show(report.Length.ToString());

            textBox_SmenaReport.Text = reportTextForSmena.HalfSmenaReport(dtfromfile).Replace("\n", Environment.NewLine);
            textBox_SmenaDayReport.Text = reportTextForSmena.FullSmenaReport(dtfromfile).Replace("\n", Environment.NewLine);
            FillcomboBox_ValueFilter("РАБОЧАЯ_ГРУППА", comboBox3Zone);
        }

        private void button4_ECHZONE_Click(object sender, EventArgs e)
        {
            if(textBox4_ECHZone.Text != "")
            {
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
            if(DataGridView_Incidents.DataSource != null)
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
            }
        }

        private void ReshowDataGridView(string ColumnName, string FilterItem)
        {
            DataGridView_Incidents.CurrentCell = null;
            if (!(ColumnName.Contains("УЗЕЛ")))
            {
                for (int i = 0; i < DataGridView_Incidents.RowCount; i++)
                {
                    DataGridView_Incidents.Rows[i].Visible = true;
                }
            }
            for (int i = 0; i < DataGridView_Incidents.RowCount; i++)
            {
                string str = DataGridView_Incidents.Rows[i].Cells[ColumnName].Value.ToString();
                if (!(str.IndexOf(FilterItem, StringComparison.OrdinalIgnoreCase) >= 0 ))
                {
                    DataGridView_Incidents.Rows[i].Visible = false;
                }
            }
        }

        private void EnableVisibleDataGridView()
        {
            for (int i = 0; i < DataGridView_Incidents.RowCount; i++)
            {
                DataGridView_Incidents.Rows[i].Visible = true;
            }
        }

        private void comboBox3Zone_TextChanged(object sender, EventArgs e)
        {
            if (comboBox3Zone.Text != null)
            {
                string ColumnName = "РАБОЧАЯ_ГРУППА";
                string FilterItem = comboBox3Zone.Text;
                ReshowDataGridView(ColumnName, FilterItem);
            }
            FillcomboBox_ValueFilter("СТАНЦИЯ", comboBox3Station);
            if (comboBox3Zone.Text == "")
            {
                comboBox3Station.Text = "";
                comboBox3Point.Text = "";
                EnableVisibleDataGridView();
            }
        }

        private void comboBox3Station_TextChanged(object sender, EventArgs e)
        {
            if (comboBox3Station.Text != null)
            {
                string ColumnName = "СТАНЦИЯ";
                string FilterItem = comboBox3Station.Text;
                ReshowDataGridView(ColumnName, FilterItem);
            }
            FillcomboBox_ValueFilter("УЗЕЛ", comboBox3Point);
            if (comboBox3Station.Text == "")
            {
                if (comboBox3Zone.Text != null)
                {
                    string ColumnName = "РАБОЧАЯ_ГРУППА";
                    string FilterItem = comboBox3Zone.Text;
                    ReshowDataGridView(ColumnName, FilterItem);
                }
            }
                
        }

        private void comboBox3Point_TextChanged(object sender, EventArgs e)
        {
            if (comboBox3Point.Text != null)
            {
                string ColumnName = "УЗЕЛ";
                string FilterItem = comboBox3Point.Text;
                ReshowDataGridView(ColumnName, FilterItem);
            }
            if(comboBox3Point.Text == "")
            {
                if (comboBox3Station.Text != null)
                {
                    string ColumnName = "СТАНЦИЯ";
                    string FilterItem = comboBox3Station.Text;
                    ReshowDataGridView(ColumnName, FilterItem);
                }
            }
        }

        private void textBox3IncNumber_TextChanged(object sender, EventArgs e)
        {
            if(textBox3IncNumber.TextLength > 2)
            {
                string ColumnName = "НОМЕР";
                string FilterItem = textBox3IncNumber.Text;
                ReshowDataGridView(ColumnName, FilterItem);
            }
            if (textBox3IncNumber.TextLength <= 2)
                EnableVisibleDataGridView();
        }

        private void textBox3ShortInformation_TextChanged(object sender, EventArgs e)
        {
            if (textBox3ShortInformation.TextLength > 2)
            {
                string ColumnName = "КРАТКОЕ_ОПИСАНИЕ";
                string FilterItem = textBox3ShortInformation.Text;
                ReshowDataGridView(ColumnName, FilterItem);
            }
            if (textBox3ShortInformation.TextLength <= 2)
                EnableVisibleDataGridView();
        }

        private void textBox3Solved_TextChanged(object sender, EventArgs e)
        {
            if (textBox3Solved.TextLength > 2)
            {
                string ColumnName = "РЕШЕНИЕ";
                string FilterItem = textBox3Solved.Text;
                ReshowDataGridView(ColumnName, FilterItem);
            }
            if (textBox3Solved.TextLength <= 2)
                EnableVisibleDataGridView();
        }

        private void textBox3IP_TextChanged(object sender, EventArgs e)
        {
            if (textBox3IP.TextLength > 2)
            {
                string ColumnName = "IP";
                string FilterItem = textBox3IP.Text;
                ReshowDataGridView(ColumnName, FilterItem);
            }
            if (textBox3IP.TextLength <= 2)
                EnableVisibleDataGridView();
        }

        private void DataGridView_Incidents_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow inc = DataGridView_Incidents.Rows[DataGridView_Incidents.CurrentRow.Index];
            this.Hide();
            Form_Incident form_Incident = new Form_Incident(inc);
            form_Incident.ShowDialog();
            this.Visible = true;
        }
    }
}
