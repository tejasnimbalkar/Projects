using ClassTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassTest.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseSqlServerIdentityColumn();
            builder.Property(x => x.FirstName).HasMaxLength(30).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(30).IsRequired();
            builder.Property(x => x.Gender).HasMaxLength(30).IsRequired();
            builder.Property(x => x.DOB).HasColumnType("DateTime");
            builder.Property(x => x.Address).HasMaxLength(30).IsRequired();
            builder.Property(x => x.Highest_Qualification).HasMaxLength(30).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(30).IsRequired();
            builder.Property(x => x.PhoneNo).HasMaxLength(30).IsRequired();
            builder.Property(x => x.Hobbies).HasMaxLength(30).IsRequired();

        }
    }
}
