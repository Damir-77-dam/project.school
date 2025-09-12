using Microsoft.EntityFrameworkCore;
using Personal.App.Database.Context;

namespace Personal.App;

internal static class Program
{
    private const string ConnectionString_MigrationTest = "Server=.;Database=Personal_MigrationTest;User Id=sa;Password=Benjamin~12;TrustServerCertificate=True";
    //private const string ConnectionString = "Server=.;Database=Personal;User Id=sa;Password=Benjamin~12;TrustServerCertificate=True";

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var builder = new DbContextOptionsBuilder<PersonalDbContext>();
        builder.UseSqlServer(ConnectionString_MigrationTest);
        var context = new PersonalDbContext(builder.Options);
        context.ChangeTracker.Clear();
        var pending = context.Database.GetPendingMigrations();
        var applied = context.Database.GetAppliedMigrations();
        context.Database.Migrate();


        //To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new CheckinForm());
    }
}