using Microsoft.EntityFrameworkCore;
using Personal.App.Database.Context;

namespace Personal.App
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private async void bGo_Click(object sender, EventArgs e)
        {
            try
            {
                using var context = PersonalDbContextFactory.CreateDbContext();
                var list = await context.Checkins
                    .GroupBy(x => x.EmployeeID)
                    .Select(g => new TotalTimeInOffice
                    {
                        EmployeeId = g.Key,
                        TotalTime = TimeSpan.FromSeconds(g.Sum(x => EF.Functions.DateDiffSecond(x.EnterTime, x.ExitTime))),
                        OfficeId = 1,
                        FullName = "",
                        OfficeName = "",
                    })
                    .ToListAsync();
                dgvList.DataSource = list;
            }
            catch { }
        }
    }
}

public class TotalTimeInOffice
{
    public int OfficeId { get; set; }

    public string OfficeName { get; set; }

    public int EmployeeId { get; set; }

    public string FullName { get; set; }

    public TimeSpan TotalTime { get; set; }
}

