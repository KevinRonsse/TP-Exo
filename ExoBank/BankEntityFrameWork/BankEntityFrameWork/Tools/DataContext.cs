using BankEntityFrameWork.Classes;
using Microsoft.EntityFrameworkCore;

namespace BankEntityFrameWork.Tools
{
    public class DataContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DataContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\CoursDotNet;Integrated Security=True");
        }
    }
}
