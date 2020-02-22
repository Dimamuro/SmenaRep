namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_ElectronicNotoficators = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label4_ECHZone = new System.Windows.Forms.Label();
            this.textBox4_ECHZone = new System.Windows.Forms.TextBox();
            this.button4_ECHZONE = new System.Windows.Forms.Button();
            this.IncidentsTab = new System.Windows.Forms.TabPage();
            this.label3_CountVisibleRows = new System.Windows.Forms.Label();
            this.button3_reset = new System.Windows.Forms.Button();
            this.dateTimePicker3TimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3TimeStart = new System.Windows.Forms.DateTimePicker();
            this.textBox3IP = new System.Windows.Forms.TextBox();
            this.textBox3Solved = new System.Windows.Forms.TextBox();
            this.textBox3ShortInformation = new System.Windows.Forms.TextBox();
            this.textBox3IncNumber = new System.Windows.Forms.TextBox();
            this.label3IP = new System.Windows.Forms.Label();
            this.label3Solved = new System.Windows.Forms.Label();
            this.labelShort3Information = new System.Windows.Forms.Label();
            this.label3_FIO = new System.Windows.Forms.Label();
            this.label3Point = new System.Windows.Forms.Label();
            this.label3Station = new System.Windows.Forms.Label();
            this.label3IncNumber = new System.Windows.Forms.Label();
            this.label3TimeEnd = new System.Windows.Forms.Label();
            this.label3TimeStart = new System.Windows.Forms.Label();
            this.labe3lZone = new System.Windows.Forms.Label();
            this.comboBox3_FIO = new System.Windows.Forms.ComboBox();
            this.comboBox3Point = new System.Windows.Forms.ComboBox();
            this.comboBox3Station = new System.Windows.Forms.ComboBox();
            this.comboBox3Zone = new System.Windows.Forms.ComboBox();
            this.DataGridView_Incidents = new System.Windows.Forms.DataGridView();
            this.DayReport = new System.Windows.Forms.TabPage();
            this.textBox_SmenaDayReport = new System.Windows.Forms.TextBox();
            this.SmenaReport = new System.Windows.Forms.TabPage();
            this.textBox_SmenaReport = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.checkBox3_EnableDB = new System.Windows.Forms.CheckBox();
            this.label_ChangeBD = new System.Windows.Forms.Label();
            this.tabPage_ElectronicNotoficators.SuspendLayout();
            this.IncidentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Incidents)).BeginInit();
            this.DayReport.SuspendLayout();
            this.SmenaReport.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(706, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Подготовить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Отчет от ...";
            // 
            // tabPage_ElectronicNotoficators
            // 
            this.tabPage_ElectronicNotoficators.Controls.Add(this.label2);
            this.tabPage_ElectronicNotoficators.Controls.Add(this.label4_ECHZone);
            this.tabPage_ElectronicNotoficators.Controls.Add(this.textBox4_ECHZone);
            this.tabPage_ElectronicNotoficators.Controls.Add(this.button4_ECHZONE);
            this.tabPage_ElectronicNotoficators.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ElectronicNotoficators.Name = "tabPage_ElectronicNotoficators";
            this.tabPage_ElectronicNotoficators.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ElectronicNotoficators.Size = new System.Drawing.Size(792, 665);
            this.tabPage_ElectronicNotoficators.TabIndex = 3;
            this.tabPage_ElectronicNotoficators.Text = "ЭЧ Уведомления";
            this.tabPage_ElectronicNotoficators.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "В альфе";
            // 
            // label4_ECHZone
            // 
            this.label4_ECHZone.AutoSize = true;
            this.label4_ECHZone.Location = new System.Drawing.Point(3, 16);
            this.label4_ECHZone.Name = "label4_ECHZone";
            this.label4_ECHZone.Size = new System.Drawing.Size(198, 13);
            this.label4_ECHZone.TabIndex = 2;
            this.label4_ECHZone.Text = "Вставте текст заявки одной зоны ЭЧ";
            // 
            // textBox4_ECHZone
            // 
            this.textBox4_ECHZone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4_ECHZone.Location = new System.Drawing.Point(3, 35);
            this.textBox4_ECHZone.Multiline = true;
            this.textBox4_ECHZone.Name = "textBox4_ECHZone";
            this.textBox4_ECHZone.Size = new System.Drawing.Size(786, 627);
            this.textBox4_ECHZone.TabIndex = 1;
            // 
            // button4_ECHZONE
            // 
            this.button4_ECHZONE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4_ECHZONE.Location = new System.Drawing.Point(714, 6);
            this.button4_ECHZONE.Name = "button4_ECHZONE";
            this.button4_ECHZONE.Size = new System.Drawing.Size(75, 23);
            this.button4_ECHZONE.TabIndex = 0;
            this.button4_ECHZONE.Text = "Подготовить";
            this.button4_ECHZONE.UseVisualStyleBackColor = true;
            this.button4_ECHZONE.Click += new System.EventHandler(this.button4_ECHZONE_Click);
            // 
            // IncidentsTab
            // 
            this.IncidentsTab.Controls.Add(this.label3_CountVisibleRows);
            this.IncidentsTab.Controls.Add(this.button3_reset);
            this.IncidentsTab.Controls.Add(this.dateTimePicker3TimeEnd);
            this.IncidentsTab.Controls.Add(this.dateTimePicker3TimeStart);
            this.IncidentsTab.Controls.Add(this.textBox3IP);
            this.IncidentsTab.Controls.Add(this.textBox3Solved);
            this.IncidentsTab.Controls.Add(this.textBox3ShortInformation);
            this.IncidentsTab.Controls.Add(this.textBox3IncNumber);
            this.IncidentsTab.Controls.Add(this.label3IP);
            this.IncidentsTab.Controls.Add(this.label3Solved);
            this.IncidentsTab.Controls.Add(this.labelShort3Information);
            this.IncidentsTab.Controls.Add(this.label3_FIO);
            this.IncidentsTab.Controls.Add(this.label3Point);
            this.IncidentsTab.Controls.Add(this.label3Station);
            this.IncidentsTab.Controls.Add(this.label3IncNumber);
            this.IncidentsTab.Controls.Add(this.label3TimeEnd);
            this.IncidentsTab.Controls.Add(this.label3TimeStart);
            this.IncidentsTab.Controls.Add(this.labe3lZone);
            this.IncidentsTab.Controls.Add(this.comboBox3_FIO);
            this.IncidentsTab.Controls.Add(this.comboBox3Point);
            this.IncidentsTab.Controls.Add(this.comboBox3Station);
            this.IncidentsTab.Controls.Add(this.comboBox3Zone);
            this.IncidentsTab.Controls.Add(this.DataGridView_Incidents);
            this.IncidentsTab.Location = new System.Drawing.Point(4, 22);
            this.IncidentsTab.Name = "IncidentsTab";
            this.IncidentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.IncidentsTab.Size = new System.Drawing.Size(792, 665);
            this.IncidentsTab.TabIndex = 2;
            this.IncidentsTab.Text = "Инциденты";
            this.IncidentsTab.UseVisualStyleBackColor = true;
            // 
            // label3_CountVisibleRows
            // 
            this.label3_CountVisibleRows.AutoSize = true;
            this.label3_CountVisibleRows.Location = new System.Drawing.Point(238, 79);
            this.label3_CountVisibleRows.Name = "label3_CountVisibleRows";
            this.label3_CountVisibleRows.Size = new System.Drawing.Size(113, 13);
            this.label3_CountVisibleRows.TabIndex = 7;
            this.label3_CountVisibleRows.Text = "Найдено значений: 0";
            // 
            // button3_reset
            // 
            this.button3_reset.Location = new System.Drawing.Point(683, 75);
            this.button3_reset.Name = "button3_reset";
            this.button3_reset.Size = new System.Drawing.Size(76, 23);
            this.button3_reset.TabIndex = 6;
            this.button3_reset.Text = "Сброс";
            this.button3_reset.UseVisualStyleBackColor = true;
            this.button3_reset.Click += new System.EventHandler(this.button3_reset_Click);
            // 
            // dateTimePicker3TimeEnd
            // 
            this.dateTimePicker3TimeEnd.Location = new System.Drawing.Point(308, 27);
            this.dateTimePicker3TimeEnd.Name = "dateTimePicker3TimeEnd";
            this.dateTimePicker3TimeEnd.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker3TimeEnd.TabIndex = 5;
            this.dateTimePicker3TimeEnd.ValueChanged += new System.EventHandler(this.dateTimePicker3TimeEnd_ValueChanged);
            // 
            // dateTimePicker3TimeStart
            // 
            this.dateTimePicker3TimeStart.Location = new System.Drawing.Point(308, 3);
            this.dateTimePicker3TimeStart.Name = "dateTimePicker3TimeStart";
            this.dateTimePicker3TimeStart.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker3TimeStart.TabIndex = 5;
            this.dateTimePicker3TimeStart.ValueChanged += new System.EventHandler(this.dateTimePicker3TimeStart_ValueChanged);
            // 
            // textBox3IP
            // 
            this.textBox3IP.Location = new System.Drawing.Point(568, 52);
            this.textBox3IP.Name = "textBox3IP";
            this.textBox3IP.Size = new System.Drawing.Size(191, 20);
            this.textBox3IP.TabIndex = 4;
            this.textBox3IP.TextChanged += new System.EventHandler(this.textBox3IP_TextChanged);
            // 
            // textBox3Solved
            // 
            this.textBox3Solved.Location = new System.Drawing.Point(568, 27);
            this.textBox3Solved.Name = "textBox3Solved";
            this.textBox3Solved.Size = new System.Drawing.Size(191, 20);
            this.textBox3Solved.TabIndex = 4;
            this.textBox3Solved.TextChanged += new System.EventHandler(this.textBox3Solved_TextChanged);
            // 
            // textBox3ShortInformation
            // 
            this.textBox3ShortInformation.Location = new System.Drawing.Point(569, 3);
            this.textBox3ShortInformation.Name = "textBox3ShortInformation";
            this.textBox3ShortInformation.Size = new System.Drawing.Size(190, 20);
            this.textBox3ShortInformation.TabIndex = 4;
            this.textBox3ShortInformation.TextChanged += new System.EventHandler(this.textBox3ShortInformation_TextChanged);
            // 
            // textBox3IncNumber
            // 
            this.textBox3IncNumber.Location = new System.Drawing.Point(308, 51);
            this.textBox3IncNumber.Name = "textBox3IncNumber";
            this.textBox3IncNumber.Size = new System.Drawing.Size(138, 20);
            this.textBox3IncNumber.TabIndex = 4;
            this.textBox3IncNumber.TextChanged += new System.EventHandler(this.textBox3IncNumber_TextChanged);
            // 
            // label3IP
            // 
            this.label3IP.AutoSize = true;
            this.label3IP.Location = new System.Drawing.Point(452, 54);
            this.label3IP.Name = "label3IP";
            this.label3IP.Size = new System.Drawing.Size(17, 13);
            this.label3IP.TabIndex = 3;
            this.label3IP.Text = "IP";
            // 
            // label3Solved
            // 
            this.label3Solved.AutoSize = true;
            this.label3Solved.Location = new System.Drawing.Point(452, 30);
            this.label3Solved.Name = "label3Solved";
            this.label3Solved.Size = new System.Drawing.Size(52, 13);
            this.label3Solved.TabIndex = 3;
            this.label3Solved.Text = "Решение";
            // 
            // labelShort3Information
            // 
            this.labelShort3Information.AutoSize = true;
            this.labelShort3Information.Location = new System.Drawing.Point(452, 6);
            this.labelShort3Information.Name = "labelShort3Information";
            this.labelShort3Information.Size = new System.Drawing.Size(114, 13);
            this.labelShort3Information.TabIndex = 3;
            this.labelShort3Information.Text = "Краткое содержание";
            // 
            // label3_FIO
            // 
            this.label3_FIO.AutoSize = true;
            this.label3_FIO.Location = new System.Drawing.Point(6, 78);
            this.label3_FIO.Name = "label3_FIO";
            this.label3_FIO.Size = new System.Drawing.Size(34, 13);
            this.label3_FIO.TabIndex = 3;
            this.label3_FIO.Text = "ФИО";
            // 
            // label3Point
            // 
            this.label3Point.AutoSize = true;
            this.label3Point.Location = new System.Drawing.Point(6, 54);
            this.label3Point.Name = "label3Point";
            this.label3Point.Size = new System.Drawing.Size(33, 13);
            this.label3Point.TabIndex = 3;
            this.label3Point.Text = "Узел";
            // 
            // label3Station
            // 
            this.label3Station.AutoSize = true;
            this.label3Station.Location = new System.Drawing.Point(6, 30);
            this.label3Station.Name = "label3Station";
            this.label3Station.Size = new System.Drawing.Size(49, 13);
            this.label3Station.TabIndex = 3;
            this.label3Station.Text = "Станция";
            // 
            // label3IncNumber
            // 
            this.label3IncNumber.AutoSize = true;
            this.label3IncNumber.Location = new System.Drawing.Point(234, 54);
            this.label3IncNumber.Name = "label3IncNumber";
            this.label3IncNumber.Size = new System.Drawing.Size(68, 13);
            this.label3IncNumber.TabIndex = 3;
            this.label3IncNumber.Text = "Номер ИНЦ";
            // 
            // label3TimeEnd
            // 
            this.label3TimeEnd.AutoSize = true;
            this.label3TimeEnd.Location = new System.Drawing.Point(234, 30);
            this.label3TimeEnd.Name = "label3TimeEnd";
            this.label3TimeEnd.Size = new System.Drawing.Size(67, 13);
            this.label3TimeEnd.TabIndex = 2;
            this.label3TimeEnd.Text = "Заканчивая";
            // 
            // label3TimeStart
            // 
            this.label3TimeStart.AutoSize = true;
            this.label3TimeStart.Location = new System.Drawing.Point(234, 6);
            this.label3TimeStart.Name = "label3TimeStart";
            this.label3TimeStart.Size = new System.Drawing.Size(59, 13);
            this.label3TimeStart.TabIndex = 2;
            this.label3TimeStart.Text = "Начиная с";
            // 
            // labe3lZone
            // 
            this.labe3lZone.AutoSize = true;
            this.labe3lZone.Location = new System.Drawing.Point(6, 6);
            this.labe3lZone.Name = "labe3lZone";
            this.labe3lZone.Size = new System.Drawing.Size(32, 13);
            this.labe3lZone.TabIndex = 2;
            this.labe3lZone.Text = "Зона";
            // 
            // comboBox3_FIO
            // 
            this.comboBox3_FIO.FormattingEnabled = true;
            this.comboBox3_FIO.Location = new System.Drawing.Point(59, 75);
            this.comboBox3_FIO.Name = "comboBox3_FIO";
            this.comboBox3_FIO.Size = new System.Drawing.Size(169, 21);
            this.comboBox3_FIO.Sorted = true;
            this.comboBox3_FIO.TabIndex = 1;
            this.comboBox3_FIO.TextChanged += new System.EventHandler(this.comboBox3_FIO_TextChanged);
            // 
            // comboBox3Point
            // 
            this.comboBox3Point.FormattingEnabled = true;
            this.comboBox3Point.Location = new System.Drawing.Point(59, 51);
            this.comboBox3Point.Name = "comboBox3Point";
            this.comboBox3Point.Size = new System.Drawing.Size(169, 21);
            this.comboBox3Point.Sorted = true;
            this.comboBox3Point.TabIndex = 1;
            this.comboBox3Point.TextChanged += new System.EventHandler(this.comboBox3Point_TextChanged);
            // 
            // comboBox3Station
            // 
            this.comboBox3Station.FormattingEnabled = true;
            this.comboBox3Station.Location = new System.Drawing.Point(59, 27);
            this.comboBox3Station.Name = "comboBox3Station";
            this.comboBox3Station.Size = new System.Drawing.Size(169, 21);
            this.comboBox3Station.Sorted = true;
            this.comboBox3Station.TabIndex = 1;
            this.comboBox3Station.TextChanged += new System.EventHandler(this.comboBox3Station_TextChanged);
            // 
            // comboBox3Zone
            // 
            this.comboBox3Zone.FormattingEnabled = true;
            this.comboBox3Zone.Location = new System.Drawing.Point(59, 3);
            this.comboBox3Zone.Name = "comboBox3Zone";
            this.comboBox3Zone.Size = new System.Drawing.Size(169, 21);
            this.comboBox3Zone.Sorted = true;
            this.comboBox3Zone.TabIndex = 1;
            this.comboBox3Zone.TextChanged += new System.EventHandler(this.comboBox3Zone_TextChanged);
            // 
            // DataGridView_Incidents
            // 
            this.DataGridView_Incidents.AllowUserToAddRows = false;
            this.DataGridView_Incidents.AllowUserToOrderColumns = true;
            this.DataGridView_Incidents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_Incidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Incidents.Location = new System.Drawing.Point(3, 100);
            this.DataGridView_Incidents.Name = "DataGridView_Incidents";
            this.DataGridView_Incidents.ReadOnly = true;
            this.DataGridView_Incidents.Size = new System.Drawing.Size(786, 562);
            this.DataGridView_Incidents.TabIndex = 0;
            this.DataGridView_Incidents.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_Incidents_CellMouseDoubleClick);
            this.DataGridView_Incidents.Sorted += new System.EventHandler(this.DataGridView_Incidents_Sorted);
            // 
            // DayReport
            // 
            this.DayReport.Controls.Add(this.textBox_SmenaDayReport);
            this.DayReport.Location = new System.Drawing.Point(4, 22);
            this.DayReport.Name = "DayReport";
            this.DayReport.Padding = new System.Windows.Forms.Padding(3);
            this.DayReport.Size = new System.Drawing.Size(792, 665);
            this.DayReport.TabIndex = 1;
            this.DayReport.Text = "Суточный Отчет";
            this.DayReport.UseVisualStyleBackColor = true;
            // 
            // textBox_SmenaDayReport
            // 
            this.textBox_SmenaDayReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_SmenaDayReport.Location = new System.Drawing.Point(3, 3);
            this.textBox_SmenaDayReport.Multiline = true;
            this.textBox_SmenaDayReport.Name = "textBox_SmenaDayReport";
            this.textBox_SmenaDayReport.ReadOnly = true;
            this.textBox_SmenaDayReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_SmenaDayReport.Size = new System.Drawing.Size(786, 659);
            this.textBox_SmenaDayReport.TabIndex = 5;
            // 
            // SmenaReport
            // 
            this.SmenaReport.Controls.Add(this.textBox_SmenaReport);
            this.SmenaReport.Location = new System.Drawing.Point(4, 22);
            this.SmenaReport.Name = "SmenaReport";
            this.SmenaReport.Padding = new System.Windows.Forms.Padding(3);
            this.SmenaReport.Size = new System.Drawing.Size(792, 665);
            this.SmenaReport.TabIndex = 0;
            this.SmenaReport.Text = "Отчет Смены";
            this.SmenaReport.UseVisualStyleBackColor = true;
            // 
            // textBox_SmenaReport
            // 
            this.textBox_SmenaReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SmenaReport.Location = new System.Drawing.Point(3, 3);
            this.textBox_SmenaReport.Multiline = true;
            this.textBox_SmenaReport.Name = "textBox_SmenaReport";
            this.textBox_SmenaReport.ReadOnly = true;
            this.textBox_SmenaReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_SmenaReport.Size = new System.Drawing.Size(786, 773);
            this.textBox_SmenaReport.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.SmenaReport);
            this.tabControl1.Controls.Add(this.DayReport);
            this.tabControl1.Controls.Add(this.IncidentsTab);
            this.tabControl1.Controls.Add(this.tabPage_ElectronicNotoficators);
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 691);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // checkBox3_EnableDB
            // 
            this.checkBox3_EnableDB.AutoSize = true;
            this.checkBox3_EnableDB.Location = new System.Drawing.Point(571, 8);
            this.checkBox3_EnableDB.Name = "checkBox3_EnableDB";
            this.checkBox3_EnableDB.Size = new System.Drawing.Size(128, 17);
            this.checkBox3_EnableDB.TabIndex = 7;
            this.checkBox3_EnableDB.Text = "Подключиться к БД";
            this.checkBox3_EnableDB.UseVisualStyleBackColor = true;
            this.checkBox3_EnableDB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label_ChangeBD
            // 
            this.label_ChangeBD.AutoSize = true;
            this.label_ChangeBD.Location = new System.Drawing.Point(2, 18);
            this.label_ChangeBD.Name = "label_ChangeBD";
            this.label_ChangeBD.Size = new System.Drawing.Size(100, 13);
            this.label_ChangeBD.TabIndex = 8;
            this.label_ChangeBD.Text = "БД изменялась ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 724);
            this.Controls.Add(this.label_ChangeBD);
            this.Controls.Add(this.checkBox3_EnableDB);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Подготовка отчета смены";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage_ElectronicNotoficators.ResumeLayout(false);
            this.tabPage_ElectronicNotoficators.PerformLayout();
            this.IncidentsTab.ResumeLayout(false);
            this.IncidentsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Incidents)).EndInit();
            this.DayReport.ResumeLayout(false);
            this.DayReport.PerformLayout();
            this.SmenaReport.ResumeLayout(false);
            this.SmenaReport.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_ElectronicNotoficators;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4_ECHZone;
        private System.Windows.Forms.TextBox textBox4_ECHZone;
        private System.Windows.Forms.Button button4_ECHZONE;
        private System.Windows.Forms.TabPage IncidentsTab;
        private System.Windows.Forms.DateTimePicker dateTimePicker3TimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimePicker3TimeStart;
        private System.Windows.Forms.TextBox textBox3IP;
        private System.Windows.Forms.TextBox textBox3Solved;
        private System.Windows.Forms.TextBox textBox3ShortInformation;
        private System.Windows.Forms.TextBox textBox3IncNumber;
        private System.Windows.Forms.Label label3IP;
        private System.Windows.Forms.Label label3Solved;
        private System.Windows.Forms.Label labelShort3Information;
        private System.Windows.Forms.Label label3_FIO;
        private System.Windows.Forms.Label label3Point;
        private System.Windows.Forms.Label label3Station;
        private System.Windows.Forms.Label label3IncNumber;
        private System.Windows.Forms.Label label3TimeEnd;
        private System.Windows.Forms.Label label3TimeStart;
        private System.Windows.Forms.Label labe3lZone;
        private System.Windows.Forms.ComboBox comboBox3_FIO;
        private System.Windows.Forms.ComboBox comboBox3Point;
        private System.Windows.Forms.ComboBox comboBox3Station;
        private System.Windows.Forms.ComboBox comboBox3Zone;
        private System.Windows.Forms.DataGridView DataGridView_Incidents;
        private System.Windows.Forms.TabPage DayReport;
        private System.Windows.Forms.TextBox textBox_SmenaDayReport;
        private System.Windows.Forms.TabPage SmenaReport;
        private System.Windows.Forms.TextBox textBox_SmenaReport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button3_reset;
        private System.Windows.Forms.CheckBox checkBox3_EnableDB;
        private System.Windows.Forms.Label label3_CountVisibleRows;
        private System.Windows.Forms.Label label_ChangeBD;
    }
}

