namespace WindowsFormsApp1
{
    partial class Form_ElectronicNotificators
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_Level = new System.Windows.Forms.Label();
            this.label_Zone = new System.Windows.Forms.Label();
            this.label_AccessFor = new System.Windows.Forms.Label();
            this.label_Priority = new System.Windows.Forms.Label();
            this.label_StartActive = new System.Windows.Forms.Label();
            this.label_EndActive = new System.Windows.Forms.Label();
            this.label_Inaccessibility = new System.Windows.Forms.Label();
            this.label_EK = new System.Windows.Forms.Label();
            this.label_Category = new System.Windows.Forms.Label();
            this.label_System = new System.Windows.Forms.Label();
            this.label_Information = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.textBox_Level = new System.Windows.Forms.TextBox();
            this.textBox_Zone = new System.Windows.Forms.TextBox();
            this.textBox_AccessFor = new System.Windows.Forms.TextBox();
            this.textBox_Priority = new System.Windows.Forms.TextBox();
            this.textBox_StartActive = new System.Windows.Forms.TextBox();
            this.textBox_EndActive = new System.Windows.Forms.TextBox();
            this.textBox_EK = new System.Windows.Forms.TextBox();
            this.textBox_Category = new System.Windows.Forms.TextBox();
            this.textBox_System = new System.Windows.Forms.TextBox();
            this.textBox_Information = new System.Windows.Forms.TextBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.dataGridView_Inaccessibility = new System.Windows.Forms.DataGridView();
            this.ColStartDateInaccessibility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEndDateInaccessibility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEKText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Inaccessibility)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Уведомление";
            // 
            // label_Level
            // 
            this.label_Level.AutoSize = true;
            this.label_Level.Location = new System.Drawing.Point(15, 74);
            this.label_Level.Name = "label_Level";
            this.label_Level.Size = new System.Drawing.Size(54, 13);
            this.label_Level.TabIndex = 1;
            this.label_Level.Text = "Уровень:";
            // 
            // label_Zone
            // 
            this.label_Zone.AutoSize = true;
            this.label_Zone.Location = new System.Drawing.Point(15, 96);
            this.label_Zone.Name = "label_Zone";
            this.label_Zone.Size = new System.Drawing.Size(121, 13);
            this.label_Zone.TabIndex = 1;
            this.label_Zone.Text = "Зона ответственности";
            // 
            // label_AccessFor
            // 
            this.label_AccessFor.AutoSize = true;
            this.label_AccessFor.Location = new System.Drawing.Point(15, 119);
            this.label_AccessFor.Name = "label_AccessFor";
            this.label_AccessFor.Size = new System.Drawing.Size(77, 13);
            this.label_AccessFor.TabIndex = 1;
            this.label_AccessFor.Text = "Доступно для";
            // 
            // label_Priority
            // 
            this.label_Priority.AutoSize = true;
            this.label_Priority.Location = new System.Drawing.Point(15, 141);
            this.label_Priority.Name = "label_Priority";
            this.label_Priority.Size = new System.Drawing.Size(131, 13);
            this.label_Priority.TabIndex = 1;
            this.label_Priority.Text = "Приоритет отображения";
            // 
            // label_StartActive
            // 
            this.label_StartActive.AutoSize = true;
            this.label_StartActive.Location = new System.Drawing.Point(15, 171);
            this.label_StartActive.Name = "label_StartActive";
            this.label_StartActive.Size = new System.Drawing.Size(58, 13);
            this.label_StartActive.TabIndex = 1;
            this.label_StartActive.Text = "Активно с";
            // 
            // label_EndActive
            // 
            this.label_EndActive.AutoSize = true;
            this.label_EndActive.Location = new System.Drawing.Point(15, 191);
            this.label_EndActive.Name = "label_EndActive";
            this.label_EndActive.Size = new System.Drawing.Size(64, 13);
            this.label_EndActive.TabIndex = 1;
            this.label_EndActive.Text = "Активно до";
            // 
            // label_Inaccessibility
            // 
            this.label_Inaccessibility.AutoSize = true;
            this.label_Inaccessibility.Location = new System.Drawing.Point(15, 347);
            this.label_Inaccessibility.Name = "label_Inaccessibility";
            this.label_Inaccessibility.Size = new System.Drawing.Size(94, 13);
            this.label_Inaccessibility.TabIndex = 1;
            this.label_Inaccessibility.Text = "Список простоев";
            // 
            // label_EK
            // 
            this.label_EK.AutoSize = true;
            this.label_EK.Location = new System.Drawing.Point(398, 74);
            this.label_EK.Name = "label_EK";
            this.label_EK.Size = new System.Drawing.Size(21, 13);
            this.label_EK.TabIndex = 1;
            this.label_EK.Text = "ЭК";
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Location = new System.Drawing.Point(398, 96);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(60, 13);
            this.label_Category.TabIndex = 1;
            this.label_Category.Text = "Категория";
            // 
            // label_System
            // 
            this.label_System.AutoSize = true;
            this.label_System.Location = new System.Drawing.Point(398, 119);
            this.label_System.Name = "label_System";
            this.label_System.Size = new System.Drawing.Size(51, 13);
            this.label_System.TabIndex = 1;
            this.label_System.Text = "Система";
            // 
            // label_Information
            // 
            this.label_Information.AutoSize = true;
            this.label_Information.Location = new System.Drawing.Point(398, 150);
            this.label_Information.Name = "label_Information";
            this.label_Information.Size = new System.Drawing.Size(160, 13);
            this.label_Information.TabIndex = 1;
            this.label_Information.Text = "Дополнительная информация";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(16, 222);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(57, 13);
            this.label_Description.TabIndex = 1;
            this.label_Description.Text = "Описание";
            // 
            // textBox_Level
            // 
            this.textBox_Level.Location = new System.Drawing.Point(174, 71);
            this.textBox_Level.Name = "textBox_Level";
            this.textBox_Level.ReadOnly = true;
            this.textBox_Level.Size = new System.Drawing.Size(218, 20);
            this.textBox_Level.TabIndex = 2;
            this.textBox_Level.Text = "дорожный";
            // 
            // textBox_Zone
            // 
            this.textBox_Zone.Location = new System.Drawing.Point(174, 92);
            this.textBox_Zone.Name = "textBox_Zone";
            this.textBox_Zone.ReadOnly = true;
            this.textBox_Zone.Size = new System.Drawing.Size(218, 20);
            this.textBox_Zone.TabIndex = 2;
            this.textBox_Zone.Text = "88-КРАСН";
            // 
            // textBox_AccessFor
            // 
            this.textBox_AccessFor.Location = new System.Drawing.Point(174, 113);
            this.textBox_AccessFor.Name = "textBox_AccessFor";
            this.textBox_AccessFor.ReadOnly = true;
            this.textBox_AccessFor.Size = new System.Drawing.Size(218, 20);
            this.textBox_AccessFor.TabIndex = 2;
            this.textBox_AccessFor.Text = "все";
            // 
            // textBox_Priority
            // 
            this.textBox_Priority.Location = new System.Drawing.Point(174, 134);
            this.textBox_Priority.Name = "textBox_Priority";
            this.textBox_Priority.ReadOnly = true;
            this.textBox_Priority.Size = new System.Drawing.Size(218, 20);
            this.textBox_Priority.TabIndex = 2;
            this.textBox_Priority.Text = "3-Низкий";
            // 
            // textBox_StartActive
            // 
            this.textBox_StartActive.Location = new System.Drawing.Point(174, 167);
            this.textBox_StartActive.Name = "textBox_StartActive";
            this.textBox_StartActive.Size = new System.Drawing.Size(218, 20);
            this.textBox_StartActive.TabIndex = 2;
            // 
            // textBox_EndActive
            // 
            this.textBox_EndActive.Location = new System.Drawing.Point(174, 188);
            this.textBox_EndActive.Name = "textBox_EndActive";
            this.textBox_EndActive.Size = new System.Drawing.Size(218, 20);
            this.textBox_EndActive.TabIndex = 2;
            // 
            // textBox_EK
            // 
            this.textBox_EK.Location = new System.Drawing.Point(570, 73);
            this.textBox_EK.Name = "textBox_EK";
            this.textBox_EK.Size = new System.Drawing.Size(218, 20);
            this.textBox_EK.TabIndex = 2;
            this.textBox_EK.Text = "*ченить*КРАСН";
            // 
            // textBox_Category
            // 
            this.textBox_Category.Location = new System.Drawing.Point(570, 94);
            this.textBox_Category.Name = "textBox_Category";
            this.textBox_Category.Size = new System.Drawing.Size(218, 20);
            this.textBox_Category.TabIndex = 2;
            this.textBox_Category.Text = "плановые работы";
            // 
            // textBox_System
            // 
            this.textBox_System.Location = new System.Drawing.Point(570, 115);
            this.textBox_System.Name = "textBox_System";
            this.textBox_System.Size = new System.Drawing.Size(218, 20);
            this.textBox_System.TabIndex = 2;
            this.textBox_System.Text = "Электроэнергия";
            // 
            // textBox_Information
            // 
            this.textBox_Information.Location = new System.Drawing.Point(401, 171);
            this.textBox_Information.Multiline = true;
            this.textBox_Information.Name = "textBox_Information";
            this.textBox_Information.Size = new System.Drawing.Size(387, 162);
            this.textBox_Information.TabIndex = 2;
            this.textBox_Information.TextChanged += new System.EventHandler(this.textBox_Information_TextChanged);
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(16, 238);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(376, 95);
            this.textBox_Description.TabIndex = 2;
            // 
            // dataGridView_Inaccessibility
            // 
            this.dataGridView_Inaccessibility.AllowUserToAddRows = false;
            this.dataGridView_Inaccessibility.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Inaccessibility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Inaccessibility.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStartDateInaccessibility,
            this.ColEndDateInaccessibility,
            this.ColEKText});
            this.dataGridView_Inaccessibility.Location = new System.Drawing.Point(16, 363);
            this.dataGridView_Inaccessibility.Name = "dataGridView_Inaccessibility";
            this.dataGridView_Inaccessibility.RowHeadersVisible = false;
            this.dataGridView_Inaccessibility.Size = new System.Drawing.Size(772, 332);
            this.dataGridView_Inaccessibility.TabIndex = 3;
            // 
            // ColStartDateInaccessibility
            // 
            this.ColStartDateInaccessibility.HeaderText = "Начало простоя";
            this.ColStartDateInaccessibility.Name = "ColStartDateInaccessibility";
            this.ColStartDateInaccessibility.Width = 190;
            // 
            // ColEndDateInaccessibility
            // 
            this.ColEndDateInaccessibility.HeaderText = "Оконание простоя";
            this.ColEndDateInaccessibility.Name = "ColEndDateInaccessibility";
            this.ColEndDateInaccessibility.Width = 190;
            // 
            // ColEKText
            // 
            this.ColEKText.HeaderText = "ЭК";
            this.ColEKText.Name = "ColEKText";
            this.ColEKText.Width = 385;
            // 
            // Form_ElectronicNotificators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 707);
            this.Controls.Add(this.dataGridView_Inaccessibility);
            this.Controls.Add(this.textBox_EndActive);
            this.Controls.Add(this.textBox_StartActive);
            this.Controls.Add(this.textBox_Priority);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.textBox_Information);
            this.Controls.Add(this.textBox_System);
            this.Controls.Add(this.textBox_Category);
            this.Controls.Add(this.textBox_AccessFor);
            this.Controls.Add(this.textBox_EK);
            this.Controls.Add(this.textBox_Zone);
            this.Controls.Add(this.textBox_Level);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_Information);
            this.Controls.Add(this.label_System);
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.label_EK);
            this.Controls.Add(this.label_Inaccessibility);
            this.Controls.Add(this.label_EndActive);
            this.Controls.Add(this.label_StartActive);
            this.Controls.Add(this.label_Priority);
            this.Controls.Add(this.label_AccessFor);
            this.Controls.Add(this.label_Zone);
            this.Controls.Add(this.label_Level);
            this.Controls.Add(this.label1);
            this.Name = "Form_ElectronicNotificators";
            this.Text = "Генератор ЭЧ Уведомлений";
            this.Load += new System.EventHandler(this.Form_ElectronicNotificators_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Inaccessibility)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Level;
        private System.Windows.Forms.Label label_Zone;
        private System.Windows.Forms.Label label_AccessFor;
        private System.Windows.Forms.Label label_Priority;
        private System.Windows.Forms.Label label_StartActive;
        private System.Windows.Forms.Label label_EndActive;
        private System.Windows.Forms.Label label_Inaccessibility;
        private System.Windows.Forms.Label label_EK;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.Label label_System;
        private System.Windows.Forms.Label label_Information;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.TextBox textBox_Level;
        private System.Windows.Forms.TextBox textBox_Zone;
        private System.Windows.Forms.TextBox textBox_AccessFor;
        private System.Windows.Forms.TextBox textBox_Priority;
        private System.Windows.Forms.TextBox textBox_StartActive;
        private System.Windows.Forms.TextBox textBox_EndActive;
        private System.Windows.Forms.TextBox textBox_EK;
        private System.Windows.Forms.TextBox textBox_Category;
        private System.Windows.Forms.TextBox textBox_System;
        private System.Windows.Forms.TextBox textBox_Information;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.DataGridView dataGridView_Inaccessibility;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStartDateInaccessibility;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEndDateInaccessibility;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEKText;
    }
}