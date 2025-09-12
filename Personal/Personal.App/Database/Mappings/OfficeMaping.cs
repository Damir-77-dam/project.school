using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personal.App.Database.Entities;

namespace Personal.App.Database.Mappings;
public class OfficeMaping : IEntityTypeConfiguration<Office>
{
    public void Configure(EntityTypeBuilder<Office> builder)
    {
        builder.ToTable("Offices");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasColumnName("Id")
            .HasColumnType("int")
            .UseIdentityColumn();
        builder.Property(x => x.City)
            .HasColumnName("City")
            .HasColumnType("nvarchar(200)")
            .HasMaxLength(200)
            .IsRequired();
        builder.Property(x => x.Country)
            .HasColumnName("Country")
            .HasColumnType("nvarchar(200)")
            .HasMaxLength(200)
            .IsRequired();
        builder.Property(x => x.MobileNumber)
            .HasColumnName("MobileNumber")
            .HasColumnType("nvarchar(200)")
            .HasMaxLength(200)
            .IsRequired();
        builder.Property(x => x.PostIndex)
            .HasColumnName("PostIndex")
            .HasColumnType("nvarchar(200)")
            .HasMaxLength(200)
            .IsRequired();
        builder.Property(x => x.Street)
            .HasColumnName("Street")
            .HasColumnType("nvarchar(200)")
            .HasMaxLength(200)
            .IsRequired();
    }
}
