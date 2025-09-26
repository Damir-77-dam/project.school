namespace Personal.App
{
    partial class ProfessionList
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
            bAdd = new Button();
            bEdit = new Button();
            bDelete = new Button();
            dgvList = new DataGridView();
            cId = new DataGridViewTextBoxColumn();
            cPosition = new DataGridViewTextBoxColumn();
            cPositionDescription = new DataGridViewTextBoxColumn();
            cPositionCategory = new DataGridViewTextBoxColumn();
            bRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // bAdd
            // 
            bAdd.Location = new Point(12, 12);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 23);
            bAdd.TabIndex = 0;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // bEdit
            // 
            bEdit.Location = new Point(93, 12);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(75, 23);
            bEdit.TabIndex = 1;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = true;
            bEdit.Click += bEdit_Click;
            // 
            // bDelete
            // 
            bDelete.Location = new Point(174, 12);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(75, 23);
            bDelete.TabIndex = 2;
            bDelete.Text = "Delete";
            bDelete.UseVisualStyleBackColor = true;
            bDelete.Click += bDelete_Click;
            // 
            // dgvList
            // 
            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dgvList.AllowUserToResizeRows = false;
            dgvList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Columns.AddRange(new DataGridViewColumn[] { cId, cPosition, cPositionDescription, cPositionCategory });
            dgvList.Location = new Point(12, 41);
            dgvList.MultiSelect = false;
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.RowHeadersVisible = false;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(868, 417);
            dgvList.TabIndex = 3;
            // 
            // cId
            // 
            cId.DataPropertyName = "Id";
            cId.HeaderText = "Id";
            cId.Name = "cId";
            cId.ReadOnly = true;
            cId.Width = 50;
            // 
            // cPosition
            // 
            cPosition.DataPropertyName = "Position";
            cPosition.HeaderText = "Position Title";
            cPosition.Name = "cPosition";
            cPosition.ReadOnly = true;
            cPosition.Width = 200;
            // 
            // cPositionDescription
            // 
            cPositionDescription.DataPropertyName = "PositionDescription";
            cPositionDescription.HeaderText = "Position Description";
            cPositionDescription.Name = "cPositionDescription";
            cPositionDescription.ReadOnly = true;
            cPositionDescription.Width = 300;
            // 
            // cPositionCategory
            // 
            cPositionCategory.DataPropertyName = "PositionCategory";
            cPositionCategory.HeaderText = "Position Category";
            cPositionCategory.Name = "cPositionCategory";
            cPositionCategory.ReadOnly = true;
            cPositionCategory.Width = 200;
            // 
            // bRefresh
            // 
            bRefresh.Location = new Point(255, 12);
            bRefresh.Name = "bRefresh";
            bRefresh.Size = new Size(75, 23);
            bRefresh.TabIndex = 4;
            bRefresh.Text = "Refresh";
            bRefresh.UseVisualStyleBackColor = true;
            bRefresh.Click += bRefresh_Click;
            // 
            // ProfessionList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 470);
            Controls.Add(bRefresh);
            Controls.Add(dgvList);
            Controls.Add(bDelete);
            Controls.Add(bEdit);
            Controls.Add(bAdd);
            Name = "ProfessionList";
            Text = "ProfessionList";
            Load += ProfessionList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bAdd;
        private Button bEdit;
        private Button bDelete;
        private DataGridView dgvList;
        private DataGridViewTextBoxColumn cId;
        private DataGridViewTextBoxColumn cPosition;
        private DataGridViewTextBoxColumn cPositionDescription;
        private DataGridViewTextBoxColumn cPositionCategory;
        private Button bRefresh;
    }
}