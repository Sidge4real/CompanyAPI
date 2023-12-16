using CompanyAPI.entities;
using Microsoft.EntityFrameworkCore;

namespace CompanyAPI.contexts
{
    public class CorporationDbContext : DbContext
    {
        public CorporationDbContext(DbContextOptions options) : base(options){}
        public DbSet<Corporation> corporations { get; set; }
        public DbSet<Goal> goals { get; set; }
        public DbSet<Company> companies { get; set; }

    }
}
