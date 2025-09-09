using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal.App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text=="admin" && tbPassword.Text=="sigmaboy77")
            {
                MessageBox.Show("Welcome admin");
                DialogResult = DialogResult.OK;
                return;
            }
            if (tbLogin.Text == "manager" && tbPassword.Text=="sigmagirl77")
            {
                MessageBox.Show("Welcome manager");
                DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("incorect");
            }
        }
    }
}
