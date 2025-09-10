namespace Personal.App;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void bLogin_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(tbLogin.Text))
        {
            MessageBox.Show("Empty login name");
            return;
        }
        if (string.IsNullOrWhiteSpace(tbPassword.Text))
        {
            MessageBox.Show("Empty password");
            return;
        }
        if (tbLogin.Text == "admin" && tbPassword.Text == "sigmaboy77")
        {
            MessageBox.Show("Welcome admin");
            DialogResult = DialogResult.OK;
            return;
        }
        if (tbLogin.Text == "manager" && tbPassword.Text == "sigmagirl77")
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
