using CompanyAPI.entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CompanyAPI.contexts
{
    public class CorporationDbContext : DbContext
    {
        public CorporationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Corporation> corporations { get; set; }
        public DbSet<Goal> goals { get; set; }
        public DbSet<Company> companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Corporation>().HasData(
                new Corporation { Id = 1, Name = "Corporation 1", Description = "Description for Corporation 1", Image = "corporation1.jpg" },
                new Corporation { Id = 2, Name = "Corporation 2", Description = "Description for Corporation 2", Image = "corporation2.jpg" }
            );

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Company 1", Description = "Description for Company 1", Image = "company1.jpg", Sector = "Technology" },
                new Company { Id = 2, Name = "Company 2", Description = "Description for Company 2", Image = "company2.jpg", Sector = "Finance" },
                new Company { Id = 3, Name = "Company 3", Description = "Description for Company 3", Image = "company3.jpg", Sector = "Healthcare" }
            );

            modelBuilder.Entity<Goal>().HasData(
                new Goal { Id = 1, Name = "Goal 1", Description = "Description for Goal 1", Image = "goal1.jpg" },
                new Goal { Id = 2, Name = "Goal 2", Description = "Description for Goal 2", Image = "goal2.jpg" },
                new Goal { Id = 3, Name = "Goal 3", Description = "Description for Goal 3", Image = "goal3.jpg" }
            );

            base.OnModelCreating(modelBuilder);
  
        }
    }
}
