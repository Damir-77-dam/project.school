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
        builder.Property(x => x.CategoriPos)
            .HasColumnName("CategoriPos")
            .HasColumnType("nvarchar(200)")
            .HasMaxLength(200)
            .IsRequired();
        builder.Property(x => x.DescribtionPos)
            .HasColumnName("DescribtionPos")
            .HasColumnType("nvarchar(300)")
            .HasMaxLength(300);
        builder.Property(x => x.Position)
            .HasColumnName("Position")
            .HasColumnType("nvarchar(200)")
            .HasMaxLength(200);

    }
}
/*
 using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        // Указываем таблицу, с которой будет связана сущность
        builder.ToTable("Products");

        // --- Настройка первичного ключа ---
        builder.HasKey(p => p.ProductId);

        // --- Настройка свойств (Properties) ---

        // Настраиваем свойство Name
        builder.Property(p => p.Name)
            .IsRequired() // Поле обязательное (NOT NULL)
            .HasMaxLength(150); // Максимальная длина строки

        // Настраиваем свойство Price
        builder.Property(p => p.Price)
            .IsRequired()
            .HasColumnType("decimal(18, 2)"); // Явно указываем тип данных в БД

        // Настраиваем свойство Sku
        builder.Property(p => p.Sku)
            .HasColumnName("StockKeepingUnit") // Задаем другое имя для колонки в таблице
            .HasMaxLength(50);

        // Настраиваем свойство CreatedDate
        builder.Property(p => p.CreatedDate)
            .HasDefaultValueSql("GETDATE()"); // Устанавливаем значение по умолчанию на уровне БД (для SQL Server)
                                               // Используйте "NOW()" для PostgreSQL или "CURRENT_TIMESTAMP" для MySQL/SQLite

        // --- Настройка индексов ---
        // Создаем уникальный индекс для Sku, чтобы артикулы не повторялись
        builder.HasIndex(p => p.Sku)
            .IsUnique();
    }
}*/
