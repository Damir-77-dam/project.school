using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personal.App.Database.Entities;

namespace Personal.App.Database.Mappings;

public class ProfessionMaping : IEntityTypeConfiguration<Ppofeshional>
{
    public void Configure(EntityTypeBuilder<Ppofeshional> builder)
    {
        builder.ToTable("Profeshionals");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasColumnName("Id")
            .HasColumnType("int")
            .UseIdentityColumn();
        builder.Property(x => x.CategoriPos)
            .HasColumnName("CategoriPos")
            .HasColumnType("nvarchar(200)")
            .HasMaxLength(200)
            .IsRequired();
        builder.Property(x => x.DescribtionPos)
            .HasColumnName("DescribtionPos")
            .HasColumnType("nvarchar(300)")
            .HasMaxLength(300)
            .IsRequired();
        builder.Property(x => x.Position)
            .HasColumnName("Position")
            .HasColumnType("nvarchar(200)")
            .HasMaxLength(200)
            .IsRequired();
    }
}
