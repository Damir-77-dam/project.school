namespace Personal.App
{
    partial class OfficeList
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
            cCountry = new DataGridViewTextBoxColumn();
            cCity = new DataGridViewTextBoxColumn();
            cPostIndex = new DataGridViewTextBoxColumn();
            cStreet = new DataGridViewTextBoxColumn();
            cMobileNumber = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // bRefresh
            // 
            bRefresh.Location = new Point(255, 17);
            bRefresh.Name = "bRefresh";
            bRefresh.Size = new Size(75, 23);
            bRefresh.TabIndex = 9;
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
            dgvList.Columns.AddRange(new DataGridViewColumn[] { cId, cCountry, cCity, cPostIndex, cStreet, cMobileNumber });
            dgvList.Location = new Point(12, 46);
            dgvList.MultiSelect = false;
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.RowHeadersVisible = false;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(967, 469);
            dgvList.TabIndex = 8;
            // 
            // bDelete
            // 
            bDelete.Location = new Point(93, 17);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(75, 23);
            bDelete.TabIndex = 7;
            bDelete.Text = "Delete";
            bDelete.UseVisualStyleBackColor = true;
            bDelete.Click += bDelete_Click;
            // 
            // bEdit
            // 
            bEdit.Location = new Point(174, 17);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(75, 23);
            bEdit.TabIndex = 6;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = true;
            bEdit.Click += bEdit_Click;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(12, 17);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 23);
            bAdd.TabIndex = 5;
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
            // cCountry
            // 
            cCountry.DataPropertyName = "Country";
            cCountry.HeaderText = "Country";
            cCountry.Name = "cCountry";
            cCountry.ReadOnly = true;
            cCountry.Width = 200;
            // 
            // cCity
            // 
            cCity.DataPropertyName = "City";
            cCity.HeaderText = "City";
            cCity.Name = "cCity";
            cCity.ReadOnly = true;
            cCity.Width = 300;
            // 
            // cPostIndex
            // 
            cPostIndex.DataPropertyName = "PostIndex";
            cPostIndex.HeaderText = "Post code";
            cPostIndex.Name = "cPostIndex";
            cPostIndex.ReadOnly = true;
            cPostIndex.Width = 200;
            // 
            // cStreet
            // 
            cStreet.DataPropertyName = "Street";
            cStreet.HeaderText = "Street";
            cStreet.Name = "cStreet";
            cStreet.ReadOnly = true;
            // 
            // cMobileNumber
            // 
            cMobileNumber.DataPropertyName = "MobileNumber";
            cMobileNumber.HeaderText = "Mobile number";
            cMobileNumber.Name = "cMobileNumber";
            cMobileNumber.ReadOnly = true;
            // 
            // OfficeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 541);
            Controls.Add(bRefresh);
            Controls.Add(dgvList);
            Controls.Add(bDelete);
            Controls.Add(bEdit);
            Controls.Add(bAdd);
            Name = "OfficeList";
            Text = "OfficeList";
            Load += OfficeList_Load;
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
        private DataGridViewTextBoxColumn cCountry;
        private DataGridViewTextBoxColumn cCity;
        private DataGridViewTextBoxColumn cPostIndex;
        private DataGridViewTextBoxColumn cStreet;
        private DataGridViewTextBoxColumn cMobileNumber;
    }
}