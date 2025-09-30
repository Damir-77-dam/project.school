using Microsoft.EntityFrameworkCore;
using Personal.App.Database.Context;

namespace Personal.App;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var builder = new DbContextOptionsBuilder<PersonalDbContext>();
        builder.UseSqlServer(PersonalDbContextFactory.ConnectionString_Test);
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