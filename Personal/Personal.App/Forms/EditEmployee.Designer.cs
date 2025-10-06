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
            tbProffesion = new TextBox();
            lProffesion = new Label();
            tbOfficeId = new TextBox();
            lOfficeId = new Label();
            bSave = new Button();
            bCancel = new Button();
            tbProffesionId = new TextBox();
            lProffesionId = new Label();
            tbSerename = new TextBox();
            lSerename = new Label();
            tbName = new TextBox();
            lName = new Label();
            tbId = new TextBox();
            lId = new Label();
            tbCheckinEntity = new TextBox();
            lOffice = new Label();
            tbOffice = new TextBox();
            lCheckinEntity = new Label();
            SuspendLayout();
            // 
            // tbProffesion
            // 
            tbProffesion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbProffesion.Location = new Point(214, 153);
            tbProffesion.Name = "tbProffesion";
            tbProffesion.Size = new Size(446, 23);
            tbProffesion.TabIndex = 37;
            // 
            // lProffesion
            // 
            lProffesion.Location = new Point(7, 156);
            lProffesion.Name = "lProffesion";
            lProffesion.Size = new Size(202, 23);
            lProffesion.TabIndex = 36;
            lProffesion.Text = "Proffesion";
            // 
            // tbOfficeId
            // 
            tbOfficeId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbOfficeId.Location = new Point(214, 124);
            tbOfficeId.Name = "tbOfficeId";
            tbOfficeId.Size = new Size(446, 23);
            tbOfficeId.TabIndex = 35;
            // 
            // lOfficeId
            // 
            lOfficeId.Location = new Point(7, 127);
            lOfficeId.Name = "lOfficeId";
            lOfficeId.Size = new Size(202, 23);
            lOfficeId.TabIndex = 34;
            lOfficeId.Text = "OfficeId";
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
            // tbProffesionId
            // 
            tbProffesionId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbProffesionId.Location = new Point(214, 95);
            tbProffesionId.Name = "tbProffesionId";
            tbProffesionId.Size = new Size(446, 23);
            tbProffesionId.TabIndex = 31;
            // 
            // lProffesionId
            // 
            lProffesionId.Location = new Point(7, 98);
            lProffesionId.Name = "lProffesionId";
            lProffesionId.Size = new Size(202, 23);
            lProffesionId.TabIndex = 30;
            lProffesionId.Text = "ProffesionId";
            // 
            // tbSerename
            // 
            tbSerename.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSerename.Location = new Point(214, 66);
            tbSerename.Name = "tbSerename";
            tbSerename.Size = new Size(446, 23);
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
            tbName.Size = new Size(446, 23);
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
            // tbCheckinEntity
            // 
            tbCheckinEntity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbCheckinEntity.Location = new Point(214, 211);
            tbCheckinEntity.Name = "tbCheckinEntity";
            tbCheckinEntity.Size = new Size(446, 23);
            tbCheckinEntity.TabIndex = 41;
            // 
            // lOffice
            // 
            lOffice.Location = new Point(7, 185);
            lOffice.Name = "lOffice";
            lOffice.Size = new Size(202, 23);
            lOffice.TabIndex = 40;
            lOffice.Text = "Office";
            // 
            // tbOffice
            // 
            tbOffice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbOffice.Location = new Point(214, 182);
            tbOffice.Name = "tbOffice";
            tbOffice.Size = new Size(446, 23);
            tbOffice.TabIndex = 39;
            // 
            // lCheckinEntity
            // 
            lCheckinEntity.Location = new Point(7, 214);
            lCheckinEntity.Name = "lCheckinEntity";
            lCheckinEntity.Size = new Size(202, 23);
            lCheckinEntity.TabIndex = 38;
            lCheckinEntity.Text = "CheckinEntity";
            // 
            // EditEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 309);
            Controls.Add(tbCheckinEntity);
            Controls.Add(lOffice);
            Controls.Add(tbOffice);
            Controls.Add(lCheckinEntity);
            Controls.Add(tbProffesion);
            Controls.Add(lProffesion);
            Controls.Add(tbOfficeId);
            Controls.Add(lOfficeId);
            Controls.Add(bSave);
            Controls.Add(bCancel);
            Controls.Add(tbProffesionId);
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

        private TextBox tbProffesion;
        private Label lProffesion;
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
        private TextBox tbCheckinEntity;
        private Label lOffice;
        private TextBox tbOffice;
        private Label lCheckinEntity;
    }
}