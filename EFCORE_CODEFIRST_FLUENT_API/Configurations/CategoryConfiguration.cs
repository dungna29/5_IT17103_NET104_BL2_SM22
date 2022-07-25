using System;
using System.Collections.Generic;
using System.Text;
using EFCORE_CODEFIRST_FLUENT_API.DomainClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCORE_CODEFIRST_FLUENT_API.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();
        }
    }
}