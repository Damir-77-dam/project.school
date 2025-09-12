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
        builder.Property(x => x.EmployeeID)
           .HasColumnName("")
           .HasColumnType("nvarchar(200)")
           .HasMaxLength(200)
           .IsRequired();
    }
}
