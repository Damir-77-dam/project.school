using HidSharp;
using SharpDX.Multimedia;
using SharpDX.RawInput;
using System.IO.Ports;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Personal.App;

public partial class CheckinForm : Form
{
    private int _isMiddleButton;

    public CheckinForm()
    {
        InitializeComponent();
    }

    private void tbBarcode_TextChanged(object sender, EventArgs e)
    {
        if (tbCardode.TextLength == 13)
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
        if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Yes)
        {
            loginToolStripMenuItem.Visible = false;
            logoutToolStripMenuItem.Visible = true;
            reportToolStripMenuItem.Visible = true;
            label1.Visible = false;
            tbCardode.Visible = false;
        }
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
        tbCardode.Visible = true;
    }

    private void profashionalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new ProfessionList().Show();
    }

    private void officeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new OfficeList().Show();
    }

    private void sOtrudnikiToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new EmployeeList().Show();
    }

    private void CheckinForm_Click(object sender, EventArgs e)
    {
        if (_isMiddleButton == 2)
        {
            officeToolStripMenuItem.Visible = true;
            profashionalToolStripMenuItem.Visible = true;
            sOtrudnikiToolStripMenuItem.Visible = true;
            loginToolStripMenuItem.Visible = false;
            logoutToolStripMenuItem.Visible = true;
            reportToolStripMenuItem.Visible = true;
            label1.Visible = false;
            tbCardode.Visible = false;
        }
    }

    private void CheckinForm_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Middle)
        {
            _isMiddleButton++;
            return;
        }
        _isMiddleButton = 0;
    }

    static SerialPort sp;
    static StringBuilder lineBuf = new StringBuilder();


    ushort vid = 0x264A; // замените на ваш
    ushort pid = 0x1017; // замените на ваш
    private void button1_Click(object sender, EventArgs e)
    {
        SharpDX.RawInput.Device.RegisterDevice(UsagePage.Generic, UsageId.KeyboardAA, DeviceFlags.InputSink, Handle);
        var dev = DeviceList.Local.GetHidDevices(vid, pid).FirstOrDefault();
        if (dev == null) { Console.WriteLine("HID устройство не найдено."); return; }

        if (!dev.TryOpen(out var stream)) { Console.WriteLine("Не удалось открыть HID."); return; }

        Console.WriteLine($"Открыт {dev.DevicePath}. Жду репорты...");
        var buf = new byte[dev.GetMaxInputReportLength()];

        while (true)
        {
            int n = stream.Read(buf, 0, buf.Length);
            if (n <= 0) continue;

            // Обычно 0-й байт — ID репорта. Полезные данные с индекса 1.
            string s = Encoding.ASCII.GetString(buf, 1, n - 1);
            var hex = Regex.Replace(s, "[^0-9A-Fa-f]", "");
            if (hex.Length == 12) hex = hex.Substring(0, 10);
            if (hex.Length == 10)
            {
                Console.WriteLine("EMID UID: " + hex.ToUpperInvariant());
            }
            else
            {
                Console.WriteLine("RAW: " + BitConverter.ToString(buf, 0, n));
            }
        }
    }
}



