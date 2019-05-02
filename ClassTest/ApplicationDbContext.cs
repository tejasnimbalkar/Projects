using ClassTest.Configurations;
using ClassTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassTest
{
    public class ApplicationDbContext : DbContext
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Login> Login { get; set; }
        public DbSet<Student> Student { get; set; }
    
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LoginConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
        }
    }
}
