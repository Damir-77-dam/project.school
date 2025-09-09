namespace Personal.App
{
    partial class LoginForm
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
            label1 = new Label();
            tbLogin = new TextBox();
            label2 = new Label();
            tbPassword = new TextBox();
            bLogin = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 43);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // tbLogin
            // 
            tbLogin.Font = new Font("Cascadia Mono", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbLogin.Location = new Point(263, 6);
            tbLogin.Margin = new Padding(6);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(296, 45);
            tbLogin.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(171, 43);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Cascadia Mono", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbPassword.Location = new Point(263, 63);
            tbPassword.Margin = new Padding(6);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(296, 45);
            tbPassword.TabIndex = 3;
            // 
            // bLogin
            // 
            bLogin.Font = new Font("Cascadia Mono", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bLogin.Location = new Point(404, 117);
            bLogin.Name = "bLogin";
            bLogin.Size = new Size(155, 55);
            bLogin.TabIndex = 4;
            bLogin.Text = "Login";
            bLogin.UseVisualStyleBackColor = true;
            bLogin.Click += bLogin_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.No;
            button2.Font = new Font("Cascadia Mono", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(12, 117);
            button2.Name = "button2";
            button2.Size = new Size(155, 55);
            button2.TabIndex = 5;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 190);
            Controls.Add(button2);
            Controls.Add(bLogin);
            Controls.Add(tbPassword);
            Controls.Add(label2);
            Controls.Add(tbLogin);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbLogin;
        private Label label2;
        private TextBox tbPassword;
        private Button bLogin;
        private Button button2;
    }
}