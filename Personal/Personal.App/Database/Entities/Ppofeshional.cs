namespace Personal.App.Database.Entities;
public class Ppofeshional
{
    public int Id { get; set; }

    public string Position { get; set; }

    public string DescribtionPos { get; set; }

    public string CategoriPos { get; set; }

    public List<Employee> Employees { get; set; }
}
