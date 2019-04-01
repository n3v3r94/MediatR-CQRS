using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimerERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimelERP.Persistence.Configurations
{
    public class ConfigurationTestERP : IEntityTypeConfiguration<TestERP>
    {
        public void Configure(EntityTypeBuilder<TestERP> builder)
        {
            builder.Property(e => e.TestERPId).HasColumnName("TestERPId");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
