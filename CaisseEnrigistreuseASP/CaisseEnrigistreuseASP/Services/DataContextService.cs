using CaisseEnrigistreuseASP.Models;
using Microsoft.EntityFrameworkCore;

namespace CaisseEnrigistreuseASP.Services
{
    public class DataContextService : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Register> Registers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\CoursDotNet;Integrated Security=True");
        }
    }
}
