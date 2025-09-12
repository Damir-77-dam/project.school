using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Personal.App.Database.Context;

namespace Personal.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var options = new DbContextOptions<PersonalDbContext>();
            //var options = Options.Create<DbContextOptions<PersonalDbContext>>();
            var context = new PersonalDbContext(options);
            context.Database.Migrate();
            
            
            
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new CheckinForm());
        }
    }
}