﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Eshop.Inventories
{
    public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.ToTable(EshopConsts.DbTablePrefix + "Inventories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.SKU)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(x => x.StockQuantity)
                .IsRequired();
        }
    }
}
