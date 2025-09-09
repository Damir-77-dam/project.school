using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal.App;

public partial class Checkin : Form
{
    public Checkin()
    {
        InitializeComponent();
    }

    private void tbBarcode_TextChanged(object sender, EventArgs e)
    {
        if (tbBarcode.TextLength == 13)
        {
            MessageBox.Show("Test");
        }
    }

    private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LoginForm loginForm = new LoginForm();
        DialogResult dialogResult = loginForm.ShowDialog();
        if (dialogResult == DialogResult.Yes)
        {
            MessageBox.Show("Login ok");
            loginToolStripMenuItem.Visible = false;
            logoutToolStripMenuItem.Visible = true;
            officeToolStripMenuItem.Visible = true;
            profashionalToolStripMenuItem.Visible = true;
            sOtrudnikiToolStripMenuItem.Visible = true;
            reportToolStripMenuItem.Visible = true;
        }
    }
}
