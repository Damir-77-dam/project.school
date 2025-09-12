namespace Personal.App.Database.Entities;

public class Office
{
    public int Id { get; set; }

    public string Country { get; set; }

    public string City { get; set; }

    public string PostIndex { get; set; }

    public string Street { get; set; }

    public string MobileNumber { get; set; }

    public List<Employee> Employees { get; set; }

    public List<CheckinEntity> Checkins { get; set; }
}
