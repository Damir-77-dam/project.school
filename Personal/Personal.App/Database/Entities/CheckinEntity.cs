namespace Personal.App.Database.Entities;
public class CheckinEntity
{
    public int Id { get; set; }

    public DateTime EnterTime { get; set; }

    public DateTime ExitTime { get; set; }

    public int EmployeeID { get; set; }

    public int OfficeID { get; set; }

    public Employee Employee { get; set; }

    public Office Office { get; set; }
}
