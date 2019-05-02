using ClassTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassTest.Configurations
{
    internal class LoginConfiguration : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseSqlServerIdentityColumn();
            builder.Property(x => x.UserName).HasMaxLength(30).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(30).IsRequired();

        }
    }
}
