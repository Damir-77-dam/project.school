namespace Personal.App
{
    partial class EditProfession
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
            lId = new Label();
            tbId = new TextBox();
            tbPosition = new TextBox();
            lPositionTitle = new Label();
            tbPositionDescription = new TextBox();
            lPositionDescription = new Label();
            tbPositionCategory = new TextBox();
            lPositionCategory = new Label();
            bCancel = new Button();
            bSave = new Button();
            SuspendLayout();
            // 
            // lId
            // 
            lId.Location = new Point(12, 15);
            lId.Name = "lId";
            lId.Size = new Size(202, 23);
            lId.TabIndex = 0;
            lId.Text = "Id";
            // 
            // tbId
            // 
            tbId.Location = new Point(220, 12);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(100, 23);
            tbId.TabIndex = 1;
            // 
            // tbPosition
            // 
            tbPosition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPosition.Location = new Point(220, 41);
            tbPosition.Name = "tbPosition";
            tbPosition.Size = new Size(446, 23);
            tbPosition.TabIndex = 3;
            // 
            // lPositionTitle
            // 
            lPositionTitle.Location = new Point(12, 44);
            lPositionTitle.Name = "lPositionTitle";
            lPositionTitle.Size = new Size(202, 23);
            lPositionTitle.TabIndex = 2;
            lPositionTitle.Text = "Position Title";
            // 
            // tbPositionDescription
            // 
            tbPositionDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPositionDescription.Location = new Point(220, 70);
            tbPositionDescription.Name = "tbPositionDescription";
            tbPositionDescription.Size = new Size(446, 23);
            tbPositionDescription.TabIndex = 5;
            // 
            // lPositionDescription
            // 
            lPositionDescription.Location = new Point(12, 73);
            lPositionDescription.Name = "lPositionDescription";
            lPositionDescription.Size = new Size(202, 23);
            lPositionDescription.TabIndex = 4;
            lPositionDescription.Text = "Position Description";
            // 
            // tbPositionCategory
            // 
            tbPositionCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPositionCategory.Location = new Point(220, 99);
            tbPositionCategory.Name = "tbPositionCategory";
            tbPositionCategory.Size = new Size(446, 23);
            tbPositionCategory.TabIndex = 7;
            // 
            // lPositionCategory
            // 
            lPositionCategory.Location = new Point(12, 102);
            lPositionCategory.Name = "lPositionCategory";
            lPositionCategory.Size = new Size(202, 23);
            lPositionCategory.TabIndex = 6;
            lPositionCategory.Text = "Position Category";
            // 
            // bCancel
            // 
            bCancel.DialogResult = DialogResult.Cancel;
            bCancel.Location = new Point(12, 128);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(75, 23);
            bCancel.TabIndex = 8;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            bSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bSave.Location = new Point(591, 128);
            bSave.Name = "bSave";
            bSave.Size = new Size(75, 23);
            bSave.TabIndex = 9;
            bSave.Text = "Save";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // EditProfession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 163);
            Controls.Add(bSave);
            Controls.Add(bCancel);
            Controls.Add(tbPositionCategory);
            Controls.Add(lPositionCategory);
            Controls.Add(tbPositionDescription);
            Controls.Add(lPositionDescription);
            Controls.Add(tbPosition);
            Controls.Add(lPositionTitle);
            Controls.Add(tbId);
            Controls.Add(lId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EditProfession";
            Text = "Edit Profession";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lId;
        private TextBox tbId;
        private TextBox tbPosition;
        private Label lPositionTitle;
        private TextBox tbPositionDescription;
        private Label lPositionDescription;
        private TextBox tbPositionCategory;
        private Label lPositionCategory;
        private Button bCancel;
        private Button bSave;
    }
}