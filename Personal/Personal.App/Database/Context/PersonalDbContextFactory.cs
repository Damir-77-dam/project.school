using Microsoft.EntityFrameworkCore;

namespace Personal.App.Database.Context;

public static class PersonalDbContextFactory
{
    public const string ConnectionString_Test = "Server=.;Database=Personal_Test;Integrated Security=True;TrustServerCertificate=True";

    public static PersonalDbContext CreateDbContext()
    {
        var optionsBuilder = new DbContextOptionsBuilder<PersonalDbContext>();

        // Configure your database provider and connection string here.
        // For this example, we're using SQLite, which creates a simple database file.
        // The database file 'blogging.db' will be created in the same directory as the executable.
        optionsBuilder.UseSqlServer(ConnectionString_Test);

        return new PersonalDbContext(optionsBuilder.Options);
    }
}