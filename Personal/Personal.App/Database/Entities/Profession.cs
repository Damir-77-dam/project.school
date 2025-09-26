namespace Personal.App.Database.Entities;

public class Profession
{
    public int Id { get; set; }

    public string Position { get; set; }

    public string PositionDescription { get; set; }

    public string PositionCategory { get; set; }

    public List<Employee> Employees { get; set; }
}
