namespace Personal.App
{
    partial class Checkin
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
            tbBarcode = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            administratorToolStripMenuItem = new ToolStripMenuItem();
            managerToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            officeToolStripMenuItem = new ToolStripMenuItem();
            profashionalToolStripMenuItem = new ToolStripMenuItem();
            sOtrudnikiToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbBarcode
            // 
            tbBarcode.Font = new Font("Cascadia Mono", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbBarcode.Location = new Point(303, 70);
            tbBarcode.Name = "tbBarcode";
            tbBarcode.Size = new Size(254, 45);
            tbBarcode.TabIndex = 0;
            tbBarcode.TextChanged += tbBarcode_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(285, 43);
            label1.TabIndex = 1;
            label1.Text = "Employe's Code";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, logoutToolStripMenuItem, officeToolStripMenuItem, profashionalToolStripMenuItem, sOtrudnikiToolStripMenuItem, reportToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administratorToolStripMenuItem, managerToolStripMenuItem });
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(49, 20);
            loginToolStripMenuItem.Text = "Login";
            // 
            // administratorToolStripMenuItem
            // 
            administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            administratorToolStripMenuItem.Size = new Size(180, 22);
            administratorToolStripMenuItem.Text = "Administrator";
            administratorToolStripMenuItem.Click += administratorToolStripMenuItem_Click;
            // 
            // managerToolStripMenuItem
            // 
            managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            managerToolStripMenuItem.Size = new Size(180, 22);
            managerToolStripMenuItem.Text = "Manager";
            managerToolStripMenuItem.Click += administratorToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(57, 20);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Visible = false;
            // 
            // officeToolStripMenuItem
            // 
            officeToolStripMenuItem.Name = "officeToolStripMenuItem";
            officeToolStripMenuItem.Size = new Size(51, 20);
            officeToolStripMenuItem.Text = "Office";
            officeToolStripMenuItem.Visible = false;
            // 
            // profashionalToolStripMenuItem
            // 
            profashionalToolStripMenuItem.Name = "profashionalToolStripMenuItem";
            profashionalToolStripMenuItem.Size = new Size(85, 20);
            profashionalToolStripMenuItem.Text = "Profashional";
            profashionalToolStripMenuItem.Visible = false;
            // 
            // sOtrudnikiToolStripMenuItem
            // 
            sOtrudnikiToolStripMenuItem.Name = "sOtrudnikiToolStripMenuItem";
            sOtrudnikiToolStripMenuItem.Size = new Size(75, 20);
            sOtrudnikiToolStripMenuItem.Text = "SOtrudniki";
            sOtrudnikiToolStripMenuItem.Visible = false;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(54, 20);
            reportToolStripMenuItem.Text = "Report";
            reportToolStripMenuItem.Visible = false;
            // 
            // Checkin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tbBarcode);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Checkin";
            Text = "Checkin";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbBarcode;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem administratorToolStripMenuItem;
        private ToolStripMenuItem managerToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem officeToolStripMenuItem;
        private ToolStripMenuItem profashionalToolStripMenuItem;
        private ToolStripMenuItem sOtrudnikiToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
    }
}