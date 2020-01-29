namespace WindowsFormsApp1
{
    partial class Form_Incident
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Incident = new System.Windows.Forms.Label();
            this.label_IncNumber = new System.Windows.Forms.Label();
            this.Label_WorkGroup = new System.Windows.Forms.Label();
            this.label_Worker = new System.Windows.Forms.Label();
            this.label_Station = new System.Windows.Forms.Label();
            this.textBox_IncNumber = new System.Windows.Forms.TextBox();
            this.textBox_WorkGroup = new System.Windows.Forms.TextBox();
            this.radioButtonInfra = new System.Windows.Forms.RadioButton();
            this.radioButtonTech = new System.Windows.Forms.RadioButton();
            this.radioButtonHuman = new System.Windows.Forms.RadioButton();
            this.textBox_Worker = new System.Windows.Forms.TextBox();
            this.textBox_Station = new System.Windows.Forms.TextBox();
            this.label_Point = new System.Windows.Forms.Label();
            this.textBox_Point = new System.Windows.Forms.TextBox();
            this.label_TimeStart = new System.Windows.Forms.Label();
            this.label_TimeMonitor = new System.Windows.Forms.Label();
            this.label_TimeEnd = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.textBox_TimeStart = new System.Windows.Forms.TextBox();
            this.textBox_TimeMonitor = new System.Windows.Forms.TextBox();
            this.textBox_TimeEnd = new System.Windows.Forms.TextBox();
            this.label_IP = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.label_DN = new System.Windows.Forms.Label();
            this.textBox_DN = new System.Windows.Forms.TextBox();
            this.label_LongInformation = new System.Windows.Forms.Label();
            this.textBox_LongInformation = new System.Windows.Forms.TextBox();
            this.label_Solved = new System.Windows.Forms.Label();
            this.textBox_Solved = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Incident
            // 
            this.label_Incident.AutoSize = true;
            this.label_Incident.Location = new System.Drawing.Point(235, 9);
            this.label_Incident.Name = "label_Incident";
            this.label_Incident.Size = new System.Drawing.Size(56, 13);
            this.label_Incident.TabIndex = 0;
            this.label_Incident.Text = "Инцидент";
            // 
            // label_IncNumber
            // 
            this.label_IncNumber.AutoSize = true;
            this.label_IncNumber.Location = new System.Drawing.Point(22, 61);
            this.label_IncNumber.Name = "label_IncNumber";
            this.label_IncNumber.Size = new System.Drawing.Size(41, 13);
            this.label_IncNumber.TabIndex = 0;
            this.label_IncNumber.Text = "Номер";
            this.label_IncNumber.Click += new System.EventHandler(this.label_IncNumber_Click);
            // 
            // Label_WorkGroup
            // 
            this.Label_WorkGroup.AutoSize = true;
            this.Label_WorkGroup.Location = new System.Drawing.Point(22, 113);
            this.Label_WorkGroup.Name = "Label_WorkGroup";
            this.Label_WorkGroup.Size = new System.Drawing.Size(86, 13);
            this.Label_WorkGroup.TabIndex = 0;
            this.Label_WorkGroup.Text = "Рабочая группа";
            // 
            // label_Worker
            // 
            this.label_Worker.AutoSize = true;
            this.label_Worker.Location = new System.Drawing.Point(22, 137);
            this.label_Worker.Name = "label_Worker";
            this.label_Worker.Size = new System.Drawing.Size(74, 13);
            this.label_Worker.TabIndex = 0;
            this.label_Worker.Text = "Исполнитель";
            // 
            // label_Station
            // 
            this.label_Station.AutoSize = true;
            this.label_Station.Location = new System.Drawing.Point(22, 161);
            this.label_Station.Name = "label_Station";
            this.label_Station.Size = new System.Drawing.Size(49, 13);
            this.label_Station.TabIndex = 0;
            this.label_Station.Text = "Станция";
            // 
            // textBox_IncNumber
            // 
            this.textBox_IncNumber.Location = new System.Drawing.Point(198, 58);
            this.textBox_IncNumber.Name = "textBox_IncNumber";
            this.textBox_IncNumber.Size = new System.Drawing.Size(341, 20);
            this.textBox_IncNumber.TabIndex = 1;
            // 
            // textBox_WorkGroup
            // 
            this.textBox_WorkGroup.Location = new System.Drawing.Point(198, 110);
            this.textBox_WorkGroup.Name = "textBox_WorkGroup";
            this.textBox_WorkGroup.Size = new System.Drawing.Size(341, 20);
            this.textBox_WorkGroup.TabIndex = 1;
            // 
            // radioButtonInfra
            // 
            this.radioButtonInfra.AutoSize = true;
            this.radioButtonInfra.Location = new System.Drawing.Point(25, 31);
            this.radioButtonInfra.Name = "radioButtonInfra";
            this.radioButtonInfra.Size = new System.Drawing.Size(123, 17);
            this.radioButtonInfra.TabIndex = 2;
            this.radioButtonInfra.TabStop = true;
            this.radioButtonInfra.Text = "Инфраструктурный";
            this.radioButtonInfra.UseVisualStyleBackColor = true;
            // 
            // radioButtonTech
            // 
            this.radioButtonTech.AutoSize = true;
            this.radioButtonTech.Location = new System.Drawing.Point(219, 31);
            this.radioButtonTech.Name = "radioButtonTech";
            this.radioButtonTech.Size = new System.Drawing.Size(90, 17);
            this.radioButtonTech.TabIndex = 2;
            this.radioButtonTech.TabStop = true;
            this.radioButtonTech.Text = "Технический";
            this.radioButtonTech.UseVisualStyleBackColor = true;
            // 
            // radioButtonHuman
            // 
            this.radioButtonHuman.AutoSize = true;
            this.radioButtonHuman.Location = new System.Drawing.Point(400, 31);
            this.radioButtonHuman.Name = "radioButtonHuman";
            this.radioButtonHuman.Size = new System.Drawing.Size(91, 17);
            this.radioButtonHuman.TabIndex = 2;
            this.radioButtonHuman.TabStop = true;
            this.radioButtonHuman.Text = "Человечачий";
            this.radioButtonHuman.UseVisualStyleBackColor = true;
            // 
            // textBox_Worker
            // 
            this.textBox_Worker.Location = new System.Drawing.Point(198, 134);
            this.textBox_Worker.Name = "textBox_Worker";
            this.textBox_Worker.Size = new System.Drawing.Size(341, 20);
            this.textBox_Worker.TabIndex = 1;
            // 
            // textBox_Station
            // 
            this.textBox_Station.Location = new System.Drawing.Point(198, 158);
            this.textBox_Station.Name = "textBox_Station";
            this.textBox_Station.Size = new System.Drawing.Size(341, 20);
            this.textBox_Station.TabIndex = 1;
            // 
            // label_Point
            // 
            this.label_Point.AutoSize = true;
            this.label_Point.Location = new System.Drawing.Point(22, 187);
            this.label_Point.Name = "label_Point";
            this.label_Point.Size = new System.Drawing.Size(33, 13);
            this.label_Point.TabIndex = 0;
            this.label_Point.Text = "Узел";
            // 
            // textBox_Point
            // 
            this.textBox_Point.Location = new System.Drawing.Point(198, 184);
            this.textBox_Point.Name = "textBox_Point";
            this.textBox_Point.Size = new System.Drawing.Size(341, 20);
            this.textBox_Point.TabIndex = 1;
            // 
            // label_TimeStart
            // 
            this.label_TimeStart.AutoSize = true;
            this.label_TimeStart.Location = new System.Drawing.Point(22, 254);
            this.label_TimeStart.Name = "label_TimeStart";
            this.label_TimeStart.Size = new System.Drawing.Size(148, 13);
            this.label_TimeStart.TabIndex = 0;
            this.label_TimeStart.Text = "Время направленя в группу";
            // 
            // label_TimeMonitor
            // 
            this.label_TimeMonitor.AutoSize = true;
            this.label_TimeMonitor.Location = new System.Drawing.Point(195, 255);
            this.label_TimeMonitor.Name = "label_TimeMonitor";
            this.label_TimeMonitor.Size = new System.Drawing.Size(170, 13);
            this.label_TimeMonitor.TabIndex = 0;
            this.label_TimeMonitor.Text = "Время закрытия в мониторинге";
            // 
            // label_TimeEnd
            // 
            this.label_TimeEnd.AutoSize = true;
            this.label_TimeEnd.Location = new System.Drawing.Point(379, 255);
            this.label_TimeEnd.Name = "label_TimeEnd";
            this.label_TimeEnd.Size = new System.Drawing.Size(141, 13);
            this.label_TimeEnd.TabIndex = 0;
            this.label_TimeEnd.Text = "Фактическое завершение";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(22, 87);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(41, 13);
            this.label_Status.TabIndex = 0;
            this.label_Status.Text = "Статус";
            // 
            // textBox_Status
            // 
            this.textBox_Status.Location = new System.Drawing.Point(198, 84);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.Size = new System.Drawing.Size(341, 20);
            this.textBox_Status.TabIndex = 1;
            // 
            // textBox_TimeStart
            // 
            this.textBox_TimeStart.Location = new System.Drawing.Point(24, 270);
            this.textBox_TimeStart.Name = "textBox_TimeStart";
            this.textBox_TimeStart.Size = new System.Drawing.Size(156, 20);
            this.textBox_TimeStart.TabIndex = 1;
            // 
            // textBox_TimeMonitor
            // 
            this.textBox_TimeMonitor.Location = new System.Drawing.Point(198, 270);
            this.textBox_TimeMonitor.Name = "textBox_TimeMonitor";
            this.textBox_TimeMonitor.Size = new System.Drawing.Size(167, 20);
            this.textBox_TimeMonitor.TabIndex = 1;
            // 
            // textBox_TimeEnd
            // 
            this.textBox_TimeEnd.Location = new System.Drawing.Point(382, 270);
            this.textBox_TimeEnd.Name = "textBox_TimeEnd";
            this.textBox_TimeEnd.Size = new System.Drawing.Size(157, 20);
            this.textBox_TimeEnd.TabIndex = 1;
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Location = new System.Drawing.Point(22, 211);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(17, 13);
            this.label_IP.TabIndex = 0;
            this.label_IP.Text = "IP";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(198, 208);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(341, 20);
            this.textBox_IP.TabIndex = 1;
            // 
            // label_DN
            // 
            this.label_DN.AutoSize = true;
            this.label_DN.Location = new System.Drawing.Point(22, 235);
            this.label_DN.Name = "label_DN";
            this.label_DN.Size = new System.Drawing.Size(23, 13);
            this.label_DN.TabIndex = 0;
            this.label_DN.Text = "DN";
            // 
            // textBox_DN
            // 
            this.textBox_DN.Location = new System.Drawing.Point(198, 232);
            this.textBox_DN.Name = "textBox_DN";
            this.textBox_DN.Size = new System.Drawing.Size(341, 20);
            this.textBox_DN.TabIndex = 1;
            // 
            // label_LongInformation
            // 
            this.label_LongInformation.AutoSize = true;
            this.label_LongInformation.Location = new System.Drawing.Point(22, 302);
            this.label_LongInformation.Name = "label_LongInformation";
            this.label_LongInformation.Size = new System.Drawing.Size(114, 13);
            this.label_LongInformation.TabIndex = 0;
            this.label_LongInformation.Text = "Подробное описание";
            // 
            // textBox_LongInformation
            // 
            this.textBox_LongInformation.Location = new System.Drawing.Point(24, 318);
            this.textBox_LongInformation.Multiline = true;
            this.textBox_LongInformation.Name = "textBox_LongInformation";
            this.textBox_LongInformation.Size = new System.Drawing.Size(515, 218);
            this.textBox_LongInformation.TabIndex = 1;
            // 
            // label_Solved
            // 
            this.label_Solved.AutoSize = true;
            this.label_Solved.Location = new System.Drawing.Point(22, 539);
            this.label_Solved.Name = "label_Solved";
            this.label_Solved.Size = new System.Drawing.Size(52, 13);
            this.label_Solved.TabIndex = 0;
            this.label_Solved.Text = "Решение";
            // 
            // textBox_Solved
            // 
            this.textBox_Solved.Location = new System.Drawing.Point(24, 555);
            this.textBox_Solved.Multiline = true;
            this.textBox_Solved.Name = "textBox_Solved";
            this.textBox_Solved.Size = new System.Drawing.Size(515, 67);
            this.textBox_Solved.TabIndex = 1;
            // 
            // Form_Incident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 632);
            this.Controls.Add(this.radioButtonHuman);
            this.Controls.Add(this.radioButtonTech);
            this.Controls.Add(this.radioButtonInfra);
            this.Controls.Add(this.textBox_TimeEnd);
            this.Controls.Add(this.textBox_TimeMonitor);
            this.Controls.Add(this.textBox_Solved);
            this.Controls.Add(this.textBox_LongInformation);
            this.Controls.Add(this.textBox_TimeStart);
            this.Controls.Add(this.textBox_DN);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.textBox_Point);
            this.Controls.Add(this.textBox_Station);
            this.Controls.Add(this.textBox_Worker);
            this.Controls.Add(this.textBox_Status);
            this.Controls.Add(this.textBox_WorkGroup);
            this.Controls.Add(this.label_TimeEnd);
            this.Controls.Add(this.label_DN);
            this.Controls.Add(this.label_TimeMonitor);
            this.Controls.Add(this.label_IP);
            this.Controls.Add(this.label_Solved);
            this.Controls.Add(this.label_LongInformation);
            this.Controls.Add(this.label_TimeStart);
            this.Controls.Add(this.label_Point);
            this.Controls.Add(this.textBox_IncNumber);
            this.Controls.Add(this.label_Station);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label_Worker);
            this.Controls.Add(this.Label_WorkGroup);
            this.Controls.Add(this.label_IncNumber);
            this.Controls.Add(this.label_Incident);
            this.Name = "Form_Incident";
            this.Text = "Form_Incident";
            this.Load += new System.EventHandler(this.Form_Incident_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Incident;
        private System.Windows.Forms.Label label_IncNumber;
        private System.Windows.Forms.Label Label_WorkGroup;
        private System.Windows.Forms.Label label_Worker;
        private System.Windows.Forms.Label label_Station;
        private System.Windows.Forms.TextBox textBox_IncNumber;
        private System.Windows.Forms.TextBox textBox_WorkGroup;
        private System.Windows.Forms.RadioButton radioButtonInfra;
        private System.Windows.Forms.RadioButton radioButtonTech;
        private System.Windows.Forms.RadioButton radioButtonHuman;
        private System.Windows.Forms.TextBox textBox_Worker;
        private System.Windows.Forms.TextBox textBox_Station;
        private System.Windows.Forms.Label label_Point;
        private System.Windows.Forms.TextBox textBox_Point;
        private System.Windows.Forms.Label label_TimeStart;
        private System.Windows.Forms.Label label_TimeMonitor;
        private System.Windows.Forms.Label label_TimeEnd;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.TextBox textBox_TimeStart;
        private System.Windows.Forms.TextBox textBox_TimeMonitor;
        private System.Windows.Forms.TextBox textBox_TimeEnd;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Label label_DN;
        private System.Windows.Forms.TextBox textBox_DN;
        private System.Windows.Forms.Label label_LongInformation;
        private System.Windows.Forms.TextBox textBox_LongInformation;
        private System.Windows.Forms.Label label_Solved;
        private System.Windows.Forms.TextBox textBox_Solved;
    }
}