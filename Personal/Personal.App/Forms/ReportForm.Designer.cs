namespace Personal.App
{
    partial class ReportForm
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
            dgvList = new DataGridView();
            monthCalendar1 = new MonthCalendar();
            bGo = new Button();
            cOfficeId = new DataGridViewTextBoxColumn();
            cOfficeInfo = new DataGridViewTextBoxColumn();
            cFullName = new DataGridViewTextBoxColumn();
            cEmployeeId = new DataGridViewTextBoxColumn();
            cTotalTime = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // dgvList
            // 
            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dgvList.AllowUserToResizeRows = false;
            dgvList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Columns.AddRange(new DataGridViewColumn[] { cOfficeId, cOfficeInfo, cFullName, cEmployeeId, cTotalTime });
            dgvList.Location = new Point(12, 192);
            dgvList.MultiSelect = false;
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.RowHeadersVisible = false;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(962, 445);
            dgvList.TabIndex = 14;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 18);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 15;
            // 
            // bGo
            // 
            bGo.Location = new Point(194, 157);
            bGo.Name = "bGo";
            bGo.Size = new Size(75, 23);
            bGo.TabIndex = 16;
            bGo.Text = "Go";
            bGo.UseVisualStyleBackColor = true;
            bGo.Click += bGo_Click;
            // 
            // cOfficeId
            // 
            cOfficeId.DataPropertyName = "OfficeId";
            cOfficeId.HeaderText = "OfficeId";
            cOfficeId.Name = "cOfficeId";
            cOfficeId.ReadOnly = true;
            cOfficeId.Visible = false;
            cOfficeId.Width = 50;
            // 
            // cOfficeInfo
            // 
            cOfficeInfo.DataPropertyName = "OfficeInfo";
            cOfficeInfo.HeaderText = "OfficeInfo";
            cOfficeInfo.Name = "cOfficeInfo";
            cOfficeInfo.ReadOnly = true;
            cOfficeInfo.Width = 200;
            // 
            // cFullName
            // 
            cFullName.DataPropertyName = "FullName";
            cFullName.HeaderText = "FullName";
            cFullName.Name = "cFullName";
            cFullName.ReadOnly = true;
            cFullName.Width = 300;
            // 
            // cEmployeeId
            // 
            cEmployeeId.DataPropertyName = "EmployeeId";
            cEmployeeId.HeaderText = "EmployeeId";
            cEmployeeId.Name = "cEmployeeId";
            cEmployeeId.ReadOnly = true;
            cEmployeeId.Visible = false;
            cEmployeeId.Width = 200;
            // 
            // cTotalTime
            // 
            cTotalTime.DataPropertyName = "TotalTimeSpan";
            cTotalTime.HeaderText = "TotalTime";
            cTotalTime.Name = "cTotalTime";
            cTotalTime.ReadOnly = true;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 645);
            Controls.Add(bGo);
            Controls.Add(monthCalendar1);
            Controls.Add(dgvList);
            Name = "ReportForm";
            Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvList;
        private DataGridViewTextBoxColumn cOfficeName;
        private MonthCalendar monthCalendar1;
        private Button bGo;
        private DataGridViewTextBoxColumn cOfficeId;
        private DataGridViewTextBoxColumn cOfficeInfo;
        private DataGridViewTextBoxColumn cFullName;
        private DataGridViewTextBoxColumn cEmployeeId;
        private DataGridViewTextBoxColumn cTotalTime;
    }
}