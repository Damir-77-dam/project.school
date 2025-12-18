using Microsoft.EntityFrameworkCore;
using Personal.App.Database.Context;
using Personal.App.Database.Entities;

namespace Personal.App
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            dgvList.AutoGenerateColumns = false;
        }

        private async void bGo_Click(object sender, EventArgs e)
        {
            try
            {
                using var context = PersonalDbContextFactory.CreateDbContext();
                var data = await context.Database.SqlQueryRaw<SalaryReport>("With totals as (\r\n  SELECT [EmployeeID], Sum(DATEDIFF(second, EnterTime, ExitTime)) as TotalTime\r\n    FROM [Checkins] as c\r\n    Group by [EmployeeID]\r\n)\r\nSELECT o.Country + ' ' + o.City + ' ' + o.PostIndex + ' ' + o.Street as OfficeInfo\r\n      ,[Name] + ' ' + [Serename] as FullName\r\n      ,[ProfessionId]\r\n      ,[OfficeId]\r\n      ,[CardCode]\r\n      ,[totals].[EmployeeID]\r\n      ,[totals].[TotalTime]\r\n  FROM totals\r\n  JOIN [Employees] e ON totals.[EmployeeID] = e.Id\r\n  JOIN [Offices] o ON e.OfficeId = [o].[Id]")
                    .ToListAsync();
                dgvList.DataSource = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(e);
            }
        }
    }
}

