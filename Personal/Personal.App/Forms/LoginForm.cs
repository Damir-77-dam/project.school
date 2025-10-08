namespace Personal.App;

public partial class LoginForm : Form
{
    private int _isMiddleButton;

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

    private void LoginForm_Click(object sender, EventArgs e)
    {
        if (_isMiddleButton == 2)
        {
            DialogResult = DialogResult.OK;
        }
    }

    private void LoginForm_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Middle)
        {
            _isMiddleButton++;
            return;
        }
        _isMiddleButton = 0;
    }
}
