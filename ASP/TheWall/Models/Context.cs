using Microsoft.EntityFrameworkCore;
    
namespace TheWall.Models
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options) : base(options) {}
        public DbSet<User> user { get; set; }
        public DbSet<Message> message { get; set; }
        public DbSet<Like> like{get;set;}
        public DbSet<Comment> comment{get;set;}

    }
}