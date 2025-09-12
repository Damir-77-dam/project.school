using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personal.App.Database.Entities;

namespace Personal.App.Database.Mappings;
public class CheckinMaping : IEntityTypeConfiguration<Checkin>
{
    public void Configure(EntityTypeBuilder<Checkin> builder)
    {
        builder.ToTable("Checkins");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.c)
           .HasColumnName("")
           .HasColumnType("nvarchar(200)")
           .HasMaxLength(200)
           .IsRequired();
    }
}
