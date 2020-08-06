using System;
using System.Data.Entity;
using TestTask_WF.Models;

namespace TestTask_WF
{
    class MyDbContext : DbContext
    {
        public MyDbContext(): base("TestTask_DbConnection")
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<ActivityType> ActivityTypies { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<WorkTime> WorkTimes { get; set; }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<Employee>()
                .HasIndex(u => u.Login) // для уникальности логинов
                .IsUnique();
        }
    }
}
