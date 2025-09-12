using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personal.App.Database.Entities;

namespace Personal.App.Database.Mappings;
public class CheckinMaping : IEntityTypeConfiguration<CheckinEntity>
{
    public void Configure(EntityTypeBuilder<CheckinEntity> builder)
    {
        builder.ToTable("CheckinsEntity");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.EmployeeID)
            .HasColumnName("EmployeeID")
            .HasColumnType("nvarchar(200)")
            .HasMaxLength(200)
            .IsRequired();
        builder.Property(x => x.Eventtime)
            .HasColumnName("Eventtime")
            .HasColumnType("nvarchar(200)")
            .HasMaxLength(200)
            .IsRequired();
        builder.Property(x => x.OfficeID)
            .HasColumnName("OfficeID")
            .HasColumnType("nvarchar(200)")
            .HasMaxLength(200)
            .IsRequired();
        builder.Property(x => x.TypeEvent)
            .HasColumnName("TypeID")
            .HasColumnType("nvarchar(200)")
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
