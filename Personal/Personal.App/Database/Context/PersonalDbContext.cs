using Microsoft.EntityFrameworkCore;
using Personal.App.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal.App.Database.Context;

public class PersonalDbContext : DbContext 
{
    public PersonalDbContext(DbContextOptions<PersonalDbContext> options)
        : base(options)
    {

    }
    public DbSet<CheckinEntity> Checkins { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Office> Offices { get; set; }
    public DbSet<Ppofeshional> Ppofeshionals { get; set; }
}
