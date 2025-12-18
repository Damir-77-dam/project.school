namespace Personal.App.Database.Entities;

public class SalaryReport
{
    public int OfficeId { get; set; }

    public string OfficeInfo { get; set; }

    public int EmployeeId { get; set; }

    public string FullName { get; set; }

    public int TotalTime { get; set; }

    public TimeSpan TotalTimeSpan { get { return TimeSpan.FromSeconds(TotalTime); } }
}
