using System;
using System.Collections.Generic;
using System.Text;
using EFCORE_CODEFIRST_FLUENT_API.DomainClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCORE_CODEFIRST_FLUENT_API.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetail");
            builder.HasKey(x => new { x.OrderId, x.ProductId });
            builder.HasOne(x => x.Order).WithMany(c => c.OrderDetails).HasForeignKey(c => c.OrderId);
            builder.HasOne(x => x.Product).WithMany(c => c.OrderDetails).HasForeignKey(c => c.ProductId);
        }
    }
}