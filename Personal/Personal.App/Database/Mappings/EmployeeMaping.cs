using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personal.App.Database.Entities;

namespace Personal.App.Database.Mappings;
public class EmployeeMaping : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasColumnName("Id")
            .HasColumnType("int")
            .UseIdentityColumn();
        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasColumnType("nvarchar(200)")
            .HasMaxLength(200)
            .IsRequired();
        builder.Property(x => x.OfficeId)
            .HasColumnName("OfficeId")
            .HasColumnType("int")
            .IsRequired();
        builder.Property(x => x.ProfessionId)
            .HasColumnName("ProfessionId")
            .HasColumnType("int")
            .IsRequired();
        builder.Property(x => x.Serename)
            .HasColumnName("Serename")
            .HasColumnType("nvarchar(200)")
            .HasMaxLength(200)
            .IsRequired();

        builder.HasOne(x => x.Profession)
            .WithMany(x => x.Employees)
            .HasForeignKey(x => x.ProfessionId);

        builder.HasOne(x => x.Office)
            .WithMany(x => x.Employees)
            .HasForeignKey(x => x.OfficeId);
    }
}
