namespace Personal.App
{
    partial class EditEmployee
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
            lOfficeId = new Label();
            bSave = new Button();
            bCancel = new Button();
            lProffesionId = new Label();
            tbSerename = new TextBox();
            lSerename = new Label();
            tbName = new TextBox();
            lName = new Label();
            tbId = new TextBox();
            lId = new Label();
            cbOffice = new ComboBox();
            cbProfession = new ComboBox();
            lCardCode = new Label();
            tbCardCode = new TextBox();
            SuspendLayout();
            // 
            // lOfficeId
            // 
            lOfficeId.Location = new Point(7, 127);
            lOfficeId.Name = "lOfficeId";
            lOfficeId.Size = new Size(202, 23);
            lOfficeId.TabIndex = 34;
            lOfficeId.Text = "Office";
            // 
            // bSave
            // 
            bSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bSave.Location = new Point(585, 278);
            bSave.Name = "bSave";
            bSave.Size = new Size(75, 23);
            bSave.TabIndex = 33;
            bSave.Text = "Save";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // bCancel
            // 
            bCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bCancel.DialogResult = DialogResult.Cancel;
            bCancel.Location = new Point(7, 278);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(75, 23);
            bCancel.TabIndex = 32;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            // 
            // lProffesionId
            // 
            lProffesionId.Location = new Point(7, 98);
            lProffesionId.Name = "lProffesionId";
            lProffesionId.Size = new Size(202, 23);
            lProffesionId.TabIndex = 30;
            lProffesionId.Text = "Proffesion";
            // 
            // tbSerename
            // 
            tbSerename.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSerename.Location = new Point(214, 66);
            tbSerename.Name = "tbSerename";
            tbSerename.Size = new Size(440, 23);
            tbSerename.TabIndex = 29;
            // 
            // lSerename
            // 
            lSerename.Location = new Point(7, 69);
            lSerename.Name = "lSerename";
            lSerename.Size = new Size(202, 23);
            lSerename.TabIndex = 28;
            lSerename.Text = "Serename";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbName.Location = new Point(214, 37);
            tbName.Name = "tbName";
            tbName.Size = new Size(440, 23);
            tbName.TabIndex = 27;
            // 
            // lName
            // 
            lName.Location = new Point(7, 40);
            lName.Name = "lName";
            lName.Size = new Size(202, 23);
            lName.TabIndex = 26;
            lName.Text = "Name";
            // 
            // tbId
            // 
            tbId.Location = new Point(214, 8);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(100, 23);
            tbId.TabIndex = 25;
            // 
            // lId
            // 
            lId.Location = new Point(7, 11);
            lId.Name = "lId";
            lId.Size = new Size(202, 23);
            lId.TabIndex = 24;
            lId.Text = "Id";
            // 
            // cbOffice
            // 
            cbOffice.DisplayMember = "FullInfo";
            cbOffice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOffice.FormattingEnabled = true;
            cbOffice.Location = new Point(215, 124);
            cbOffice.Name = "cbOffice";
            cbOffice.Size = new Size(439, 23);
            cbOffice.TabIndex = 36;
            cbOffice.ValueMember = "Id";
            // 
            // cbProfession
            // 
            cbProfession.DisplayMember = "Position";
            cbProfession.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProfession.FormattingEnabled = true;
            cbProfession.Location = new Point(215, 95);
            cbProfession.Name = "cbProfession";
            cbProfession.Size = new Size(439, 23);
            cbProfession.TabIndex = 37;
            cbProfession.ValueMember = "Id";
            // 
            // lCardCode
            // 
            lCardCode.Location = new Point(7, 156);
            lCardCode.Name = "lCardCode";
            lCardCode.Size = new Size(202, 23);
            lCardCode.TabIndex = 38;
            lCardCode.Text = "CardCode";
            // 
            // tbCardCode
            // 
            tbCardCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbCardCode.Location = new Point(215, 153);
            tbCardCode.Name = "tbCardCode";
            tbCardCode.Size = new Size(440, 23);
            tbCardCode.TabIndex = 39;
            // 
            // EditEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 309);
            Controls.Add(tbCardCode);
            Controls.Add(lCardCode);
            Controls.Add(cbProfession);
            Controls.Add(cbOffice);
            Controls.Add(lOfficeId);
            Controls.Add(bSave);
            Controls.Add(bCancel);
            Controls.Add(lProffesionId);
            Controls.Add(tbSerename);
            Controls.Add(lSerename);
            Controls.Add(tbName);
            Controls.Add(lName);
            Controls.Add(tbId);
            Controls.Add(lId);
            Name = "EditEmployee";
            Text = "EditEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbOfficeId;
        private Label lOfficeId;
        private Button bSave;
        private Button bCancel;
        private TextBox tbProffesionId;
        private Label lProffesionId;
        private TextBox tbSerename;
        private Label lSerename;
        private TextBox tbName;
        private Label lName;
        private TextBox tbId;
        private Label lId;
        private ComboBox cbOffice;
        private ComboBox cbProfession;
        private Label lCardCode;
        private TextBox tbCardCode;
    }
}