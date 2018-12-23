using Microsoft.EntityFrameworkCore;
 
namespace chefdishes.Models
{
    public class AllContext : DbContext
    {
        public AllContext (DbContextOptions<AllContext> options) : base(options) {}
        public DbSet<Chef> chef { get; set; }
        public DbSet<Dish> dish { get; set; }

    }
}