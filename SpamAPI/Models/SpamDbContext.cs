using Microsoft.EntityFrameworkCore;

namespace SpamAPI.Models
{
    public class SpamDbContext : DbContext
    {
        public DbSet<Message> Message { get; set; }

        public SpamDbContext(DbContextOptions<SpamDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>().ToTable("Message");
        }
    }
}