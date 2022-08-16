using Microsoft.EntityFrameworkCore;
using Petiteannonce.Models;

namespace Petiteannonce.Services
{
    public class DataContextService : DbContext
    {
        public DbSet<Categorie> Categories { get; set; }

        public DbSet<Utilisateur> Utilisateurs { get; set; }

        public DbSet<Annonce> Annonces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (LocalDb)\CoursDotNet; Integrated Security = True");
        }
    }
}
