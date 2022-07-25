using System;
using System.Collections.Generic;
using System.Text;
using EFCORE_CODEFIRST_FLUENT_API.DomainClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCORE_CODEFIRST_FLUENT_API.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();
            builder.Property(c => c.OrderDate).HasDefaultValue(DateTime.Now);
            builder.Property(c => c.ShipPhoneNumber).IsRequired();
            builder.Property(c => c.ShipName).IsRequired().HasMaxLength(200);
        }
    }
}