using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personal.App.Database.Entities;

namespace Personal.App.Database.Mappings;
public class CheckinMaping : IEntityTypeConfiguration<CheckinEntity>
{
    public void Configure(EntityTypeBuilder<CheckinEntity> builder)
    {
        builder.ToTable("Checkins");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasColumnName("Id")
            .HasColumnType("int")
            .UseIdentityColumn();

        builder.Property(x => x.EmployeeID)
            .HasColumnName("EmployeeID")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(x => x.OfficeID)
            .HasColumnName("OfficeID")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(x => x.EnterTime)
            .HasColumnName("EnterTime")
            .HasColumnType("datetime2(0)")
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(x => x.ExitTime)
            .HasColumnName("ExitTime")
            .HasColumnType("datetime2(0)")
            .HasMaxLength(200)
            .IsRequired();

        builder.HasOne(x => x.Employee)
            .WithMany(x => x.Checkins)
            .HasForeignKey(x => x.EmployeeID);

        builder.HasOne(x => x.Office)
            .WithMany(x => x.Checkins)
            .HasForeignKey(x => x.OfficeID);
    }
}
