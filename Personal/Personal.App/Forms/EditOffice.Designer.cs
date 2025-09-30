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
            tbPostIndex = new TextBox();
            lPostIndex = new Label();
            tbCity = new TextBox();
            lCity = new Label();
            tbCountry = new TextBox();
            lCountry = new Label();
            tbId = new TextBox();
            lId = new Label();
            tbMobileNumber = new TextBox();
            lMobileNumber = new Label();
            tbStreet = new TextBox();
            lStreet = new Label();
            SuspendLayout();
            // 
            // bSave
            // 
            bSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bSave.Location = new Point(590, 261);
            bSave.Name = "bSave";
            bSave.Size = new Size(75, 23);
            bSave.TabIndex = 19;
            bSave.Text = "Save";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // bCancel
            // 
            bCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bCancel.DialogResult = DialogResult.Cancel;
            bCancel.Location = new Point(12, 261);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(75, 23);
            bCancel.TabIndex = 18;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            // 
            // tbPostIndex
            // 
            tbPostIndex.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPostIndex.Location = new Point(219, 105);
            tbPostIndex.Name = "tbPostIndex";
            tbPostIndex.Size = new Size(446, 23);
            tbPostIndex.TabIndex = 17;
            // 
            // lPostIndex
            // 
            lPostIndex.Location = new Point(12, 108);
            lPostIndex.Name = "lPostIndex";
            lPostIndex.Size = new Size(202, 23);
            lPostIndex.TabIndex = 16;
            lPostIndex.Text = "Post code";
            // 
            // tbCity
            // 
            tbCity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbCity.Location = new Point(219, 76);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(446, 23);
            tbCity.TabIndex = 15;
            // 
            // lCity
            // 
            lCity.Location = new Point(12, 79);
            lCity.Name = "lCity";
            lCity.Size = new Size(202, 23);
            lCity.TabIndex = 14;
            lCity.Text = "City";
            // 
            // tbCountry
            // 
            tbCountry.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbCountry.Location = new Point(219, 47);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(446, 23);
            tbCountry.TabIndex = 13;
            // 
            // lCountry
            // 
            lCountry.Location = new Point(12, 50);
            lCountry.Name = "lCountry";
            lCountry.Size = new Size(202, 23);
            lCountry.TabIndex = 12;
            lCountry.Text = "Country";
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
            lId.Location = new Point(12, 21);
            lId.Name = "lId";
            lId.Size = new Size(202, 23);
            lId.TabIndex = 10;
            lId.Text = "Id";
            // 
            // tbMobileNumber
            // 
            tbMobileNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbMobileNumber.Location = new Point(219, 163);
            tbMobileNumber.Name = "tbMobileNumber";
            tbMobileNumber.Size = new Size(446, 23);
            tbMobileNumber.TabIndex = 23;
            // 
            // lMobileNumber
            // 
            lMobileNumber.Location = new Point(12, 166);
            lMobileNumber.Name = "lMobileNumber";
            lMobileNumber.Size = new Size(202, 23);
            lMobileNumber.TabIndex = 22;
            lMobileNumber.Text = "Mobile number";
            // 
            // tbStreet
            // 
            tbStreet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbStreet.Location = new Point(219, 134);
            tbStreet.Name = "tbStreet";
            tbStreet.Size = new Size(446, 23);
            tbStreet.TabIndex = 21;
            // 
            // lStreet
            // 
            lStreet.Location = new Point(12, 137);
            lStreet.Name = "lStreet";
            lStreet.Size = new Size(202, 23);
            lStreet.TabIndex = 20;
            lStreet.Text = "Street";
            // 
            // EditOffice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 302);
            Controls.Add(tbMobileNumber);
            Controls.Add(lMobileNumber);
            Controls.Add(tbStreet);
            Controls.Add(lStreet);
            Controls.Add(bSave);
            Controls.Add(bCancel);
            Controls.Add(tbPostIndex);
            Controls.Add(lPostIndex);
            Controls.Add(tbCity);
            Controls.Add(lCity);
            Controls.Add(tbCountry);
            Controls.Add(lCountry);
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
        private TextBox tbPostIndex;
        private Label lPostIndex;
        private TextBox tbCity;
        private Label lCity;
        private TextBox tbCountry;
        private Label lCountry;
        private TextBox tbId;
        private Label lId;
        private TextBox tbMobileNumber;
        private Label lMobileNumber;
        private TextBox tbStreet;
        private Label lStreet;
    }
}