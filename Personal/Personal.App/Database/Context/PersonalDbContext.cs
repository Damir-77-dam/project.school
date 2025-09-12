using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Personal.App.Database.Entities;

namespace Personal.App.Database.Context;

public class PersonalDbContext : DbContext
{
    public PersonalDbContext(DbContextOptions<PersonalDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var typesToRegister = Assembly.GetAssembly(typeof(PersonalDbContext)).GetTypes()
            .Where(t => t.GetInterfaces()
                .Any(gi => gi.IsGenericType && gi.GetGenericTypeDefinition()
                == typeof(IEntityTypeConfiguration<>)))
            .ToList();

        foreach (var type in typesToRegister)
        {
            dynamic configurationInstance = Activator.CreateInstance(type);
            modelBuilder.ApplyConfiguration(configurationInstance);
        }

        foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // This suppresses the exception for pending model changes.
        // The recommended approach is to add a new migration instead.
        optionsBuilder.ConfigureWarnings(warnings =>
            warnings.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
    }
    public DbSet<CheckinEntity> Checkins { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Office> Offices { get; set; }
    public DbSet<Ppofeshional> Ppofeshionals { get; set; }
}
