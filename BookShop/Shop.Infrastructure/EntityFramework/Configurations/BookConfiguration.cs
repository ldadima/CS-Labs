﻿using BookShop;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Shop.Infrastructure.EntityFramework.Configurations
{
    [UsedImplicitly]
    public class BookConfiguration: IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable(nameof(Book), ShopContext.DefaultSchemaName);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Title).IsRequired().HasMaxLength(256);
            builder.Property(x => x.Genre).IsRequired().HasMaxLength(100);
            builder.Property(x => x.IsNew).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.CurrentPrice).IsRequired();
            builder.Property(x => x.DateDelivery).IsRequired();
        }
    }
}