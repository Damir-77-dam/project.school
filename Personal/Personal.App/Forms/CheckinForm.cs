namespace Personal.App;

public partial class CheckinForm : Form
{
    public CheckinForm()
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

    private void loginToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var loginForm = new LoginForm();
        var dialogResult = loginForm.ShowDialog();
        if (dialogResult == DialogResult.OK)
        {
            officeToolStripMenuItem.Visible = true;
            profashionalToolStripMenuItem.Visible = true;
            sOtrudnikiToolStripMenuItem.Visible = true;
        }
        loginToolStripMenuItem.Visible = false;
        logoutToolStripMenuItem.Visible = true;
        reportToolStripMenuItem.Visible = true;
        label1.Visible = false;
        tbBarcode.Visible = false;
    }

    private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        loginToolStripMenuItem.Visible = true;
        logoutToolStripMenuItem.Visible = false;
        officeToolStripMenuItem.Visible = false;
        profashionalToolStripMenuItem.Visible = false;
        sOtrudnikiToolStripMenuItem.Visible = false;
        reportToolStripMenuItem.Visible = false;
        label1.Visible = true;
        tbBarcode.Visible = true;
    }

    private void profashionalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new ProfessionList().Show();
    }

    private void officeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new OfficeList().Show();
    }
}
