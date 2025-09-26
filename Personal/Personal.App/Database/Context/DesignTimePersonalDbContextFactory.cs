using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Personal.App.Database.Context;

public class DesignTimePersonalDbContextFactory : IDesignTimeDbContextFactory<PersonalDbContext>
{
    private const string ConnectionString_MigrationTest = "Server=.;Database=Personal_MigrationTest;User Id=sa;Password=Benjamin~12;TrustServerCertificate=True";

    public PersonalDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PersonalDbContext>();

        // Configure your database provider and connection string here.
        // For this example, we're using SQLite, which creates a simple database file.
        // The database file 'blogging.db' will be created in the same directory as the executable.
        optionsBuilder.UseSqlServer(ConnectionString_MigrationTest);

        return new PersonalDbContext(optionsBuilder.Options);
    }
}