namespace Personal.App
{
    partial class EditOffice
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
            bSave = new Button();
            bCancel = new Button();
            tbPositionCategory = new TextBox();
            lOfficeCategory = new Label();
            tbPositionDescription = new TextBox();
            lOfficeDescription = new Label();
            tbPosition = new TextBox();
            lOfficeName = new Label();
            tbId = new TextBox();
            lId = new Label();
            SuspendLayout();
            // 
            // bSave
            // 
            bSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bSave.Location = new Point(590, 134);
            bSave.Name = "bSave";
            bSave.Size = new Size(75, 23);
            bSave.TabIndex = 19;
            bSave.Text = "Save";
            bSave.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            bCancel.DialogResult = DialogResult.Cancel;
            bCancel.Location = new Point(11, 134);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(75, 23);
            bCancel.TabIndex = 18;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            // 
            // tbPositionCategory
            // 
            tbPositionCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPositionCategory.Location = new Point(219, 105);
            tbPositionCategory.Name = "tbPositionCategory";
            tbPositionCategory.Size = new Size(446, 23);
            tbPositionCategory.TabIndex = 17;
            // 
            // lOfficeCategory
            // 
            lOfficeCategory.Location = new Point(11, 108);
            lOfficeCategory.Name = "lOfficeCategory";
            lOfficeCategory.Size = new Size(202, 23);
            lOfficeCategory.TabIndex = 16;
            lOfficeCategory.Text = "Office Category";
            // 
            // tbPositionDescription
            // 
            tbPositionDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPositionDescription.Location = new Point(219, 76);
            tbPositionDescription.Name = "tbPositionDescription";
            tbPositionDescription.Size = new Size(446, 23);
            tbPositionDescription.TabIndex = 15;
            // 
            // lOfficeDescription
            // 
            lOfficeDescription.Location = new Point(11, 79);
            lOfficeDescription.Name = "lOfficeDescription";
            lOfficeDescription.Size = new Size(202, 23);
            lOfficeDescription.TabIndex = 14;
            lOfficeDescription.Text = "Office Description";
            // 
            // tbPosition
            // 
            tbPosition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPosition.Location = new Point(219, 47);
            tbPosition.Name = "tbPosition";
            tbPosition.Size = new Size(446, 23);
            tbPosition.TabIndex = 13;
            // 
            // lOfficeName
            // 
            lOfficeName.Location = new Point(11, 50);
            lOfficeName.Name = "lOfficeName";
            lOfficeName.Size = new Size(202, 23);
            lOfficeName.TabIndex = 12;
            lOfficeName.Text = "Office Name\r\n";
            // 
            // tbId
            // 
            tbId.Location = new Point(219, 18);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(100, 23);
            tbId.TabIndex = 11;
            // 
            // lId
            // 
            lId.Location = new Point(11, 21);
            lId.Name = "lId";
            lId.Size = new Size(202, 23);
            lId.TabIndex = 10;
            lId.Text = "Id";
            // 
            // EditOffice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 175);
            Controls.Add(bSave);
            Controls.Add(bCancel);
            Controls.Add(tbPositionCategory);
            Controls.Add(lOfficeCategory);
            Controls.Add(tbPositionDescription);
            Controls.Add(lOfficeDescription);
            Controls.Add(tbPosition);
            Controls.Add(lOfficeName);
            Controls.Add(tbId);
            Controls.Add(lId);
            Name = "EditOffice";
            Text = "EditOffice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bSave;
        private Button bCancel;
        private TextBox tbPositionCategory;
        private Label lOfficeCategory;
        private TextBox tbPositionDescription;
        private Label lOfficeDescription;
        private TextBox tbPosition;
        private Label lOfficeName;
        private TextBox tbId;
        private Label lId;
    }
}