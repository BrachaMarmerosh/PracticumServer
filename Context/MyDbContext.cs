using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Entities;

namespace Context
{
    public class MyDbContext : DbContext, Icontext
    {
        public DbSet<User> Users { get ; set ; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localDb)\msSQlLocalDb;database=FullStackBrachiM;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelbulider)
        {
            base.OnModelCreating(modelbulider);
        }
    }
}