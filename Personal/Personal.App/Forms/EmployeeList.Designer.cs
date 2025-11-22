namespace Personal.App
{
    partial class EmployeeList
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
            bRefresh = new Button();
            dgvList = new DataGridView();
            bDelete = new Button();
            bEdit = new Button();
            bAdd = new Button();
            cId = new DataGridViewTextBoxColumn();
            cName = new DataGridViewTextBoxColumn();
            cSerename = new DataGridViewTextBoxColumn();
            cProfessionId = new DataGridViewTextBoxColumn();
            cOfficeId = new DataGridViewTextBoxColumn();
            cProfession = new DataGridViewTextBoxColumn();
            cOffice = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // bRefresh
            // 
            bRefresh.Location = new Point(255, 12);
            bRefresh.Name = "bRefresh";
            bRefresh.Size = new Size(75, 23);
            bRefresh.TabIndex = 14;
            bRefresh.Text = "Refresh";
            bRefresh.UseVisualStyleBackColor = true;
            bRefresh.Click += bRefresh_Click;
            // 
            // dgvList
            // 
            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dgvList.AllowUserToResizeRows = false;
            dgvList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Columns.AddRange(new DataGridViewColumn[] { cId, cName, cSerename, cProfessionId, cOfficeId, cProfession, cOffice });
            dgvList.Location = new Point(12, 41);
            dgvList.MultiSelect = false;
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.RowHeadersVisible = false;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(1157, 442);
            dgvList.TabIndex = 13;
            // 
            // bDelete
            // 
            bDelete.Location = new Point(93, 12);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(75, 23);
            bDelete.TabIndex = 12;
            bDelete.Text = "Delete";
            bDelete.UseVisualStyleBackColor = true;
            bDelete.Click += bDelete_Click;
            // 
            // bEdit
            // 
            bEdit.Location = new Point(174, 12);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(75, 23);
            bEdit.TabIndex = 11;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = true;
            bEdit.Click += bEdit_Click;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(12, 12);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 23);
            bAdd.TabIndex = 10;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // cId
            // 
            cId.DataPropertyName = "Id";
            cId.HeaderText = "Id";
            cId.Name = "cId";
            cId.ReadOnly = true;
            cId.Width = 50;
            // 
            // cName
            // 
            cName.DataPropertyName = "Name";
            cName.HeaderText = "Name";
            cName.Name = "cName";
            cName.ReadOnly = true;
            cName.Width = 200;
            // 
            // cSerename
            // 
            cSerename.DataPropertyName = "Serename";
            cSerename.HeaderText = "Serename";
            cSerename.Name = "cSerename";
            cSerename.ReadOnly = true;
            cSerename.Width = 300;
            // 
            // cProfessionId
            // 
            cProfessionId.DataPropertyName = "ProfessionId";
            cProfessionId.HeaderText = "ProfessionId";
            cProfessionId.Name = "cProfessionId";
            cProfessionId.ReadOnly = true;
            cProfessionId.Width = 200;
            // 
            // cOfficeId
            // 
            cOfficeId.DataPropertyName = "OfficeId";
            cOfficeId.HeaderText = "OfficeId";
            cOfficeId.Name = "cOfficeId";
            cOfficeId.ReadOnly = true;
            // 
            // cProfession
            // 
            cProfession.DataPropertyName = "Position";
            cProfession.HeaderText = "Profession";
            cProfession.Name = "cProfession";
            cProfession.ReadOnly = true;
            // 
            // cOffice
            // 
            cOffice.DataPropertyName = "Office";
            cOffice.HeaderText = "Office";
            cOffice.Name = "cOffice";
            cOffice.ReadOnly = true;
            // 
            // EmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 530);
            Controls.Add(bRefresh);
            Controls.Add(dgvList);
            Controls.Add(bDelete);
            Controls.Add(bEdit);
            Controls.Add(bAdd);
            Name = "EmployeeList";
            Text = "EmployeeList";
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bRefresh;
        private DataGridView dgvList;
        private Button bDelete;
        private Button bEdit;
        private Button bAdd;
        private DataGridViewTextBoxColumn cId;
        private DataGridViewTextBoxColumn cName;
        private DataGridViewTextBoxColumn cSerename;
        private DataGridViewTextBoxColumn cProfessionId;
        private DataGridViewTextBoxColumn cOfficeId;
        private DataGridViewTextBoxColumn cProfession;
        private DataGridViewTextBoxColumn cOffice;
    }
}