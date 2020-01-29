using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Incident : Form
    {
        //public Incident IncidentInfo { get; set; }
        public DataGridViewRow IncidentInfo;
        public Form_Incident(DataGridViewRow inc)
        {
            InitializeComponent();
            IncidentInfo = inc;
        }

        private void label_IncNumber_Click(object sender, EventArgs e)
        {

        }

        private void Form_Incident_Load(object sender, EventArgs e)
        {
            if (IncidentInfo.Cells["ИНФРАСТРУКТУРНЫЙ"].Value.ToString() == "true")
                radioButtonInfra.Checked = true;
            if (IncidentInfo.Cells["ТЕХНИЧЕСКИЙ"].Value.ToString() == "true")
                radioButtonTech.Checked = true;
            if (radioButtonTech.Checked == false && radioButtonInfra.Checked == false)
                radioButtonHuman.Checked = true;
            textBox_IncNumber.Text = IncidentInfo.Cells["НОМЕР"].Value.ToString();
            textBox_Status.Text = IncidentInfo.Cells["СТАТУС"].Value.ToString();
            textBox_WorkGroup.Text = IncidentInfo.Cells["РАБОЧАЯ_ГРУППА"].Value.ToString();
            textBox_Worker.Text = IncidentInfo.Cells["ИСПОЛНИТЕЛЬ"].Value.ToString();
            textBox_Station.Text = IncidentInfo.Cells["СТАНЦИЯ"].Value.ToString();
            textBox_Point.Text = IncidentInfo.Cells["УЗЕЛ"].Value.ToString();
            textBox_IP.Text = IncidentInfo.Cells["IP"].Value.ToString();
            textBox_DN.Text = IncidentInfo.Cells["DomainName"].Value.ToString();
            textBox_TimeStart.Text = IncidentInfo.Cells["ВРЕМЯ_СОЗДАНИЯ"].Value.ToString();
            textBox_TimeMonitor.Text = IncidentInfo.Cells["ВРЕМЯ_ЗАКРЫТИЯ_В_СМ"].Value.ToString();
            textBox_TimeEnd.Text = IncidentInfo.Cells["ФАКТИЧЕСКОЕ_ЗАВЕРШЕНИЕ"].Value.ToString();
            textBox_Solved.Text = IncidentInfo.Cells["РЕШЕНИЕ"].Value.ToString();
            textBox_LongInformation.Text = IncidentInfo.Cells["ПОДРОБНОЕ_ОПИСАНИЕ"].Value.ToString();

        }
    }
}
