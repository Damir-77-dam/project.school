namespace Personal.App.Database.Entities;
public class Checkin
{
    public int Id { get; set; }

    public DateTime Eventtime { get; set; }

    public string TypeEvent { get; set; }

    public int EmployeeID { get; set; }

    public int OfficeID { get; set; }
}
