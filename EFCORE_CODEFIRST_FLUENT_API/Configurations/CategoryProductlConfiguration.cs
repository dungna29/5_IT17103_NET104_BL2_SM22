using System;
using System.Collections.Generic;
using System.Text;
using EFCORE_CODEFIRST_FLUENT_API.DomainClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCORE_CODEFIRST_FLUENT_API.Configurations
{
    public class CategoryProductlConfiguration : IEntityTypeConfiguration<CategoryProduct>
    {
        public void Configure(EntityTypeBuilder<CategoryProduct> builder)
        {
            builder.ToTable("CategoryProduct");
            builder.HasKey(x => new { x.CategoryId, x.ProductId });
            builder.HasOne(x => x.Product).WithMany(c => c.CategoryProducts).HasForeignKey(c => c.ProductId);
            builder.HasOne(x => x.Category).WithMany(c => c.CategoryProducts).HasForeignKey(c => c.CategoryId);
        }
    }
}