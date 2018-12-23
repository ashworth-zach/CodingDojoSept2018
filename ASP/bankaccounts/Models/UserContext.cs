using Microsoft.EntityFrameworkCore;
 
namespace bankaccounts.Models
{
    public class UserContext : DbContext
    {
        public UserContext (DbContextOptions<UserContext> options) : base(options) {}
        public DbSet<User> user { get; set; }
        public DbSet<Transaction> transaction { get; set; }

    }
}