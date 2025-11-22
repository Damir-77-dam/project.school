namespace Personal.App.Database.Entities;
public class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Serename { get; set; }

    public int ProfessionId { get; set; }

    public int OfficeId { get; set; }

    public string CardCode { get; set; }

    public Profession Profession { get; set; }

    public Office Office { get; set; }

    public List<CheckinEntity> Checkins { get; set; }
}
